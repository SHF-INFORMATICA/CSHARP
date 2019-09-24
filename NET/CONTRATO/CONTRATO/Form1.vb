Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmContrato

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdlGeral.CarregaINI()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles cmdSair.Click
        End
    End Sub

    Private Sub tbrOpcaoGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click

    End Sub

    Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
        txtContrato.Text = ""
        txtDescricao.Text = ""
        txtCnpjCpf.Text = ""
        txtPessoa.Text = ""
        txtDtCad.Text = ""
        txtFim.Text = ""
        txtContrato.Focus()
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Mostra_dados()
    End Sub

    Private Sub Mostra_dados()
        Using con As SqlConnection = AbreBancoDados()
            Try
                con.Open()

                Dim sql As String = "select * from pessoa"
                Dim cmd As SqlCommand = New SqlCommand(sql, con)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable

                'MsgBox(dt.Rows.Item)

                da.Fill(dt)
                grdGrid.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub GRAVA_REGISTRO()
        If Trim(txtContrato.Text) = "" Then
            MsgBox("Numero contrato inválido.")
            txtContrato.Focus()
        End If
        If Trim(txtDescricao.Text) = "" Then
            MsgBox("Descrição contrato inválido.")
            txtDescricao.Focus()
        End If
        If Trim(txtCnpjCpf.Text) = "" Then
            MsgBox("Cliente não informado.")
            txtCnpjCpf.Focus()
        End If
        If Trim(txtDtCad.Text) = "" Then
            MsgBox("Data Contrato não informado.")
            txtDtCad.Focus()
        End If
        If Trim(txtFim.Text) = "" Then
            MsgBox("Data Contrato não informado.")
            txtDtCad.Focus()
        End If

        Using con As SqlConnection = AbreBancoDados()
            Try
                con.Open()

                Dim sql As String = "select * from pessoa"
                Dim cmd As SqlCommand = New SqlCommand(sql, con)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable

                MsgBox(dt.Rows().Count())

                da.Fill(dt)
                'grdGrid.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
End Class
