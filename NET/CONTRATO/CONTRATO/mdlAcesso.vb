Imports System
Imports System.Data
Imports System.Data.SqlClient

Module mdlAcesso
    Public Function AbreBancoDados() As SqlConnection
        Dim sql As String = "Server=" & mdlGeral.SERVIDOR_MEGASIM & ";Database=" & mdlGeral.NOME_BANCO_DADOS & ";User Id=sa;Password=ejsnenas"
        Return New SqlConnection(sql)
    End Function
End Module
