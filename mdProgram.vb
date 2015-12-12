Imports Microsoft.VisualBasic.FileIO.FileSystem
Module mdProgram
    Public folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\博文评教全自动\"
    Public isListMode As Boolean = False
    Public dfUserName As String = ""
    Public dfUserPass As String = ""
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
End Module
