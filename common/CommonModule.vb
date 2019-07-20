Imports System.Configuration
Imports System.IO
Imports System.Text

Module CommonModule

    Public Sub LogWrite(ParamArray param As Object())
        '標準出力
        ConsolOutput(String.Join(", ", param))

        ' ファイルを開く
        Dim fs As String = GetConfig(LOG_PREFIX) & DateTime.Now.ToString(GetConfig(LOG_DATE)) + GetConfig(LOG_EXTENSION)
        ' TextWriterオブジェクトを得る
        Using writer As TextWriter = New StreamWriter(fs, True, Encoding.UTF8)
            ' TextWriterを使って、文字列をファイルに書き込む
            writer.WriteLine(DateTime.Now.ToString(DATE_FORMAT) & " " & String.Join(", ", param))

        End Using ' ここでTextWriterオブジェクトのDisposeメソッドが呼び出される

    End Sub

    Public Function GetConfig(ByVal Key) As Object
        Try
            Return ConfigurationManager.AppSettings(Key)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Sub ConsolOutput(ByVal str As String)
#If DEBUG Then
        '標準出力
        Console.Out.WriteLine(str)
#End If
    End Sub

End Module
