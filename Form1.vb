﻿Imports System.Data.SQLite
Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub BtnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        MsgBox("BtnInit_Click")
        Try
            Using con As New SQLiteConnection("Data Source=MyApp.db")
                con.Open()
                Using cmd As SQLiteCommand = con.CreateCommand()
                    'SELECT count(*) FROM sqlite_master WHERE type="table" AND name="M_Environment"
                    cmd.CommandText = "CREATE TABLE M_Environment (ID INTEGER PRIMARY KEY, Name NVARCHAR(128), Sort INTEGER, R_TimeStamp TIMESTAMP DEFAULT (datetime(CURRENT_TIMESTAMP,'localtime')))"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "INSERT INTO M_Environment (Name, Sort) VALUES('Test1', 10)"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "INSERT INTO M_Environment (Name, Sort) VALUES('Test2', 20)"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "INSERT INTO M_Environment (Name, Sort) VALUES('Test3', 30)"
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("MyAppデータベース作成成功", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Msg(CType(New Object() {"MyAppデータベース作成成功", Me.Text}, Object))
            Msg(New Object() {"MyAppデータベース作成成功", Me.Text})
        Catch ex As Exception
            MessageBox.Show("MyAppデータベース作成失敗" + Environment.NewLine + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Msg(CType(New Object() {"MyAppデータベース作成失敗" + Environment.NewLine + ex.Message, Me.Text}, Object))
            Msg("MyAppデータベース作成失敗" + Environment.NewLine + ex.Message, Me.Text)
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

            'For i As Integer = 0 To param.Length - 1
            '    If (TypeOf param(i) Is Integer) Then
            '        writer.WriteLine($"{i + 1}番目はintで、値は{param(i)}です")
            '    ElseIf (TypeOf param(i) Is Array) Then
            '        writer.WriteLine($"{i + 1}番目は配列です")
            '    Else
            '        writer.WriteLine($"{i + 1}番目は想定外の型です")
            '    End If
            'Next
        End Using ' ここでTextWriterオブジェクトのDisposeメソッドが呼び出される
        'End Using ' ここでFileStreamオブジェクトのDisposeメソッドが呼び出される

    End Sub
End Class