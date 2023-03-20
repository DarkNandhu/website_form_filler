Public Class cnf
    Dim con As Odbc.OdbcConnection
    Dim com As Odbc.OdbcCommand
    Dim a, b, c As String
    Dim ex As Odbc.OdbcException

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

   
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            com = New Odbc.OdbcCommand
                com.CommandText = "insert into data(fname,path) values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
            com.Connection = con
            com.ExecuteNonQuery()
            WebBrowser1.Navigate(TextBox2.Text)
            MsgBox("Created,Start your configuration")
            TextBox1.Visible = False
            TextBox2.Visible = False
            Button2.Visible = False
            Button1.Visible = True
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = True
            TextBox6.Visible = True
            TextBox4.Visible = True
            Button3.Visible = True

                ProgressBar1.Visible = True

        ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Please fill First")
        ElseIf TextBox1.Text = "" Then
            MsgBox("Please fill a file name you want to access")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please fill an appropriate path")


            End If
        Catch ex As Exception
            MsgBox("Please Create a new table name")

        End Try
    End Sub

    Private Sub cnf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New Odbc.OdbcConnection("DSN=data")
        con.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = Val(TextBox4.Text) + 1
        TextBox5.Text = TextBox3.Text + TextBox4.Text
        a = TextBox5.Text
        TextBox6.Text = WebBrowser1.Document.ActiveElement.GetAttribute("id")
        Try


            If TextBox5.Text = "data1" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data1='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data2" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data2='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data3" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data3='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data4" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data4='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data5" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data5='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data6" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data6='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data7" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data7='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data8" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data8='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data9" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data9='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data10" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data10='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data11" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data11='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data12" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data12='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data13" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data13='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data14" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data14='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data15" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data15='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data16" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data16='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data17" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data colo=" & TextBox4.Text & ",set data17='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data18" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data colo=" & TextBox4.Text & ",set data18='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data19" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data colo=" & TextBox4.Text & ",set data19='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()

            ElseIf TextBox5.Text = "data20" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data20='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data21" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data21='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data22" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data22='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data23" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data23='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data24" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data24='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data25" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data25='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data26" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data26='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data27" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data27='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data28" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data28='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data29" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data29='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()
            ElseIf TextBox5.Text = "data30" Then
                com = New Odbc.OdbcCommand
                com.CommandText = "update data set colo=" & TextBox4.Text & ",data30='" & TextBox6.Text & "' where fname='" & TextBox1.Text & "'"
                com.Connection = con
                com.ExecuteNonQuery()

            End If
        Catch ex As Exception
            MsgBox("Out Of limit, The limit is only 30")


        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Val(TextBox4.Text) > 0 Then

            MsgBox("data stored successfully, You Are ready to use the form filler now")
            Me.Close()


        Else
            MsgBox("You had not configured anything ")

        End If

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ProgressBar1.Visible = False
    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged

        If e.CurrentProgress > 0 Then
            ProgressBar1.Increment(e.CurrentProgress)




        End If

    End Sub
End Class