Imports Microsoft.VisualBasic.FileIO.FileSystem
Module mdProgram
    Private fileDld As Net.WebClient
    Public folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\博文评教全自动\"
    Public isListMode As Boolean = False
    Public dfUserName As String = ""
    Public dfUserPass As String = ""
    Public otUserName As String = ""
    Public otUserPass As String = ""
    Public isProvidingOthers As Boolean = False
    Public allCommons As New List(Of String)
    '====
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    'OSVersion
    Public osMajorVersion As Integer
    Dim os As OperatingSystem = Environment.OSVersion
    Public Sub ReadSettings()
        osMajorVersion = os.Version.Major
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        If FileExists(folderPath & "config.ini") = False Then Exit Sub
        isListMode = GetINI("Settings", "isListMode", False)
        dfUserName = GetINI("Settings", "dfUserName", "")
        dfUserPass = GetINI("Settings", "dfUserPass", "")
    End Sub
    Public Sub SaveSettings()
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        WriteINI("Settings", "isListMode", isListMode)
        WriteINI("Settings", "dfUserName", dfUserName)
        WriteINI("Settings", "dfUserPass", dfUserPass)
    End Sub
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, Optional ByVal iniName As String = "\config.ini") As String
        Dim Str As String = ""
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), folderPath & iniName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, Optional ByVal iniName As String = "\config.ini") As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, folderPath & iniName)
    End Function

    '账号密码提供器
    Public Class AccountProvider
        Public Shared Function GetUserName() As String
            Return IIf(isProvidingOthers, otUserName, dfUserName)
        End Function
        Public Shared Function GetUserPass() As String
            Return IIf(isProvidingOthers, otUserPass, dfUserPass)
        End Function
        Public Shared Function isOtMode() As Boolean
            Return isProvidingOthers
        End Function
        Public Shared Function SwitchModeToOt() As Boolean
            otUserPass = ""
            isProvidingOthers = True
            Return True
        End Function
        Public Shared Function SwitchModeToDf() As Boolean
            isProvidingOthers = False
            Return True
        End Function
        Public Shared Function SetUserName(ByVal un As String) As Boolean
            If isProvidingOthers Then
                otUserName = un
            Else
                dfUserName = un
            End If
            Return True
        End Function
        Public Shared Function SetUserPass(ByVal up As String) As Boolean
            If isProvidingOthers Then
                otUserPass = up
            Else
                dfUserPass = up
            End If
            Return True
        End Function

    End Class
    '其他评价提供器
    Public Class CommonsProvider
        Public Shared Function getCommon() As String
            If allCommons.Count = 0 Then Exit Function
            Dim r As New Random
            Return allCommons(r.Next(0, allCommons.Count - 1))
        End Function
        Public Shared Function loadCommons() As Integer
            allCommons.Clear()
            If Dir(folderPath & "commons.txt") <> "" Then
                FileOpen(1, folderPath & "commons.txt", OpenAccess.Read)
                Do Until EOF(1)
                    allCommons.Add(LineInput(1))
                Loop
                FileClose(1)
            End If
            Return allCommons.Count
        End Function
        Public Shared Function canBeUsed() As Boolean
            If Dir(folderPath & "commons.txt") <> "" Then
                loadCommons()
                Return True
            End If
            If MsgBox("是否需要下载在线评论库？" & vbCrLf & "当然你也可以在" & folderPath & "下新建一个 commons.txt 文件，一个评论一行，自动抽取", MsgBoxStyle.YesNo, "评论") = MsgBoxResult.Yes Then
                downloadFile("https://dl.nimitzdev.org/zfang/commons.txt", folderPath & "commons.txt")
            End If
            If Dir(folderPath & "commons.txt") <> "" Then
                loadCommons()
                Return True
            End If
            Return False
        End Function
    End Class
    '下载器
    Public Sub downloadFile(ByVal Url As String, ByVal Path As String)
        If Url = "-" Then Exit Sub
        Try
            fileDld = New Net.WebClient
            fileDld.DownloadFile(New Uri(Url), Path)
        Catch ex As Exception
            MsgBox("配置文件下载错误，请稍后再试")
        End Try
    End Sub
End Module