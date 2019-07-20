Imports System.Configuration

Public Class MenuForm
    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "START")

        'すべてのキーとその値を取得
        Dim key As String
        For Each key In ConfigurationManager.AppSettings.AllKeys
            LogWrite(key, ConfigurationManager.AppSettings(key))
        Next key


    End Sub
End Class