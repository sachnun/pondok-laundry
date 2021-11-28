Imports MySql.Data.MySqlClient
Module ModuleKoneksi
    Public StrSQL As String
    Public StrCN As String
    Public vServer As String
    Public vUser As String
    Public vPass As String
    Public vDatabase As String

    Public CN As New MySqlConnection
    Public dAdapter As MySqlDataAdapter
    Public RdData As MySqlDataReader
    Public dSet As DataSet
    Public Status As Boolean
    Public vPetugas As String
    Public Brs As Integer
    Public StatReport As Byte
End Module
