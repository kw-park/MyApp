Imports System.Configuration

Public Class MenuForm
    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "START")

        'すべてのキーとその値を取得
        Dim key As String
        For Each key In ConfigurationManager.AppSettings.AllKeys
            LogWrite(key, ConfigurationManager.AppSettings(key))
        Next key

        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "END")
    End Sub

    Private Sub BtnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "START")

        Dim form As Form = New InitForm
        Me.Hide()
        form.ShowDialog()
        If form.DialogResult = DialogResult.OK Then
            LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "OK?", form.DialogResult)
        Else
            LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "OR?", form.DialogResult)
        End If
        Me.Show()

        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "END")
    End Sub
End Class
