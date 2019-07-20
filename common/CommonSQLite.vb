Imports System.Data.SQLite
Imports System.IO
Imports System.Text
Module CommonSQLite
    Public Sub InitSetting()
        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "START")

        Try
            Using con As New SQLiteConnection("Data Source=MyApp.db")
                con.Open()

                Using cmd As SQLiteCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT count(*) FROM sqlite_master " &
                        "WHERE type='table' AND name='M_Environment'"
                    If CInt(cmd.ExecuteScalar()) = 0 Then
                        cmd.CommandText = "CREATE TABLE M_Environment (ID INTEGER PRIMARY KEY, Name NVARCHAR(128), Sort INTEGER, R_TimeStamp TIMESTAMP DEFAULT (datetime(CURRENT_TIMESTAMP,'localtime')))"
                        cmd.ExecuteNonQuery()

                        cmd.CommandText = "INSERT INTO M_Environment (Name, Sort) VALUES('Test1', 10)"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "INSERT INTO M_Environment (Name, Sort) VALUES('Test2', 20)"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "INSERT INTO M_Environment (Name, Sort) VALUES('Test3', 30)"
                        cmd.ExecuteNonQuery()
                    End If

                End Using
            End Using
        Catch ex As Exception
            LogWrite(ex.Message)
        End Try

        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "END")
    End Sub


    Public Function GetDatatable(ByVal tableName As String) As DataTable
        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "START 0")

        Return GetDatatable(tableName, String.Format("SELECT * FROM {0}", tableName))

        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "End")
    End Function
    Public Function GetDatatable(ByVal tableName As String, ByVal query As String) As DataTable
        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "START")

        LogWrite(String.Format("Query =[{0}]", query))
        Try
            Using con As New SQLiteConnection("Data Source=MyApp.db")
                con.Open()

                Dim ds As New DataSet
                Dim da As New SQLiteDataAdapter(query, con)
                da.Fill(ds, tableName)
                Return ds.Tables(tableName)
            End Using
        Catch ex As Exception
            LogWrite(ex.Message)
        Finally
            GetDatatable = Nothing
            LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "End")
        End Try
    End Function

    Public Function SetUpdateDataTable(ByVal data As DataTable) As Integer
        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "START 0")

        Return SetUpdateDataTable(String.Format("SELECT * FROM {0}", data.TableName), data)

        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "End 0")
    End Function
    Public Function SetUpdateDataTable(ByVal query As String, ByVal data As DataTable) As Integer
        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "START")

        Dim i As Integer = -1
        Try
            Using con As New SQLiteConnection("Data Source=MyApp.db")
                Dim ds As New DataSet
                Dim da As New SQLiteDataAdapter(query, con)
                Dim builder As SQLiteCommandBuilder = New SQLiteCommandBuilder(da)

                i = da.Update(data)

                LogWrite("Update count = " & i)
            End Using
        Catch ex As Exception
            LogWrite(ex.Message)
        Finally
            SetUpdateDataTable = i
            LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "End")
        End Try
    End Function

    Public Sub GetData()
        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "START")

        LogWrite(System.Reflection.MethodBase.GetCurrentMethod().Name, "End")
    End Sub
End Module
