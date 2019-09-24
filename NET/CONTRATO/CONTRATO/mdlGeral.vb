Imports System.IO

Module mdlGeral
    Public SERVIDOR_MEGASIM As String
    Public NOME_BANCO_DADOS As String

    Public Sub CarregaINI()
        Dim ArqIni As IO.StreamReader
        'Dim CaminhoArq As String = Application.StartupPath & "c:\megasim\megasim.ini"
        Dim CaminhoArq As String = "c:\megasim\megasim.ini"
        Dim linhaTexto As String

        'MsgBox(CaminhoArq)

        If IO.File.Exists(CaminhoArq) Then
            ArqIni = New IO.StreamReader(CaminhoArq)
            linhaTexto = ArqIni.ReadLine

            If linhaTexto <> Nothing Then _
                SERVIDOR_MEGASIM = linhaTexto & vbCrLf

            linhaTexto = ArqIni.ReadLine
            If linhaTexto <> Nothing Then _
                NOME_BANCO_DADOS = linhaTexto & vbCrLf

            'While linhaTexto <> Nothing
            'MsgBox(linhaTexto & vbCrLf)


            'linhaTexto = ArqIni.ReadLine
            'End While
            ArqIni.Close()
        Else
            MessageBox.Show("Arquivo não existe")
        End If
    End Sub

End Module
