Imports System.Data.SQLite
Imports System.IO
Imports System.Text

Public Class InitSetting

    Private Sub InitSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Msg("InitSetting_Load")
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

                Dim ds As New DataSet
                Dim da As New SQLiteDataAdapter("SELECT * FROM M_Environment", con)
                da.Fill(ds, "M_Environment")
                Me.dgvDataList.DataSource = ds.Tables("M_Environment")
            End Using
        Catch ex As Exception
            Msg(ex.Message)
        End Try
    End Sub

    Private Sub BtnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Msg("BtnList_Click")
        Try
            Using con As New SQLiteConnection("Data Source=MyApp.db")
                Dim ds As New DataSet
                Dim da As New SQLiteDataAdapter("SELECT * FROM M_Environment", con)
                da.Fill(ds, "M_Environment")
                Me.dgvDataList.DataSource = ds.Tables("M_Environment")
            End Using
        Catch ex As Exception
            Msg(ex.Message)
        End Try
    End Sub

    Private Sub Msg(ParamArray param As Object())
        '標準出力
        Console.Out.WriteLine(String.Join(", ", param))

        ' ファイルを開く
        'Using fs As FileStream = File.OpenWrite(".\\MyApp_" + DateTime.Now.ToString("YYYYMMDD") + ".log")
        Dim fs As String = ".\\MyApp_" + DateTime.Now.ToString("yyyyMMdd") + ".log"
        ' TextWriterオブジェクトを得る
        Using writer As TextWriter = New StreamWriter(fs, True, Encoding.UTF8)
            ' TextWriterを使って、文字列をファイルに書き込む
            writer.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff ") + String.Join(", ", param))

        End Using ' ここでTextWriterオブジェクトのDisposeメソッドが呼び出される

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Msg("BtnUpdate_Click")

    End Sub
End Class
