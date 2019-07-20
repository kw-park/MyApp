Imports System.Data.SQLite
Imports System.IO
Imports System.Text

Public Class InitForm

    Private Sub InitSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "START")

        CommonSQLite.InitSetting()
        Me.dgvDataList.DataSource = CommonSQLite.GetDatatable("M_Environment")

        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "END")
    End Sub

    Private Sub BtnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "START")

        Me.dgvDataList.DataSource = CommonSQLite.GetDatatable("M_Environment")

        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "END")
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "START")

        CommonSQLite.SetUpdateDataTable(Me.dgvDataList.DataSource)
        Me.dgvDataList.DataSource = CommonSQLite.GetDatatable("M_Environment")

        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "END")
    End Sub
End Class

