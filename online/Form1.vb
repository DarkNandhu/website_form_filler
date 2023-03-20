
Public Class Form1
    Dim con As Odbc.OdbcConnection
    Dim com As Odbc.OdbcCommand
    Dim ada As Odbc.OdbcDataAdapter
    Dim ds As Data.DataSet
    Dim dv As DataView
    Dim drv As DataRowView
    Dim ada1 As Odbc.OdbcDataAdapter
    Dim ds1 As Data.DataSet
    Dim dv1 As DataView
    Dim drv1 As DataRowView
    Dim d As System.DateTime
    Dim ex As Odbc.OdbcException
    Dim a, b, co As String
    Dim c, z, y, x, p, t As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If Val(TextBox4.Text) = 0 Then
                drv = dv(0)
                drv1 = dv1(TextBox1.Text)
                TextBox2.Text = drv1(0)

                c = 0
                y = c + 3
                x = c + 1

                While c < z
                    TextBox5.Text = drv1(x)
                    TextBox5.Text = TextBox5.Text.Trim
                    p = TextBox5.Text.Length
                    co = TextBox5.Text.ElementAt(0)
                    TextBox6.AppendText(co)
                    TextBox6.Text = TextBox6.Text.ToUpper()
                    t = 1
                    While t < p
                        If TextBox5.Text.ElementAt(t) = " " Then
                            co = TextBox5.Text.ElementAt(t)
                            TextBox6.AppendText(co)
                            co = TextBox5.Text.ElementAt(t + 1)
                            co = co.ToUpper()
                            TextBox6.AppendText(co)
                            t = t + 2
                            Else
                                co = TextBox5.Text.ElementAt(t)
                            TextBox6.AppendText(co)
                            t = t + 1
                            End If

                    End While
                    p = TextBox6.Text.Length
                    If TextBox6.Text.ElementAt(p - 1) = "." Or TextBox6.Text.ElementAt(p - 1) = " " Then
                        Label2.Text = TextBox6.Text
                        Label2.Text = Label2.Text.Substring(0, Label2.Text.Length - 1)
                        TextBox6.Text = Label2.Text
                        TextBox6.Text.Trim()
                    End If
                    p = TextBox6.Text.Length
                    If TextBox6.Text.ElementAt(p - 1) = " " Or TextBox6.Text.ElementAt(p - 1) = "." Then
                        Label2.Text = TextBox6.Text
                        Label2.Text = Label2.Text.Substring(0, Label2.Text.Length - 1)
                        TextBox6.Text = Label2.Text
                        TextBox6.Text.Trim()
                    End If
                    p = TextBox6.Text.Length
                    If TextBox6.Text.ElementAt(0) = " " Or TextBox6.Text.ElementAt(p - 1) = "." Then
                        Label2.Text = TextBox6.Text
                        Label2.Text = Label2.Text.Substring(1, Label2.Text.Length)
                        TextBox6.Text = Label2.Text
                        TextBox6.Text.Trim()
                    End If

                    TextBox6.Text.Trim()
                   
                    If TextBox6.Text = "Null" Or TextBox6.Text = "NULL" Or TextBox6.Text = "null" Then
                        TextBox6.Text = ""

                    End If
                    WebBrowser1.Document.GetElementById(drv(y)).SetAttribute("value", TextBox6.Text)
                    y = y + 1
                    x = x + 1
                    TextBox6.Text = ""

                    c = c + 1
                End While
                If Val(TextBox2.Text) > 0 Then
                    com = New Odbc.OdbcCommand
                    com.CommandText = "delete from " & a & " where sno=" & Val(TextBox2.Text) - 1 & ""
                    com.Connection = con
                    com.ExecuteNonQuery()
                End If
            ElseIf Val(TextBox4.Text) > 0 Then
                Dim Box As MsgBoxResult = MsgBox("Are you sure you want to skip this record", MsgBoxStyle.YesNo)
                If Box = MsgBoxResult.Yes Then
                    drv = dv(0)
                    drv1 = dv1(TextBox1.Text)
                    TextBox2.Text = drv1(0)

                    c = 0
                    y = c + 3
                    x = c + 1

                    While c < z
                        TextBox5.Text = drv1(x)
                        TextBox5.Text.Trim()

                        WebBrowser1.Document.GetElementById(drv(y)).SetAttribute("value", TextBox5.Text)
                        y = y + 1
                        x = x + 1

                        c = c + 1
                    End While
                End If
            End If






        Catch ex As Exception
            MsgBox(" No data Found Check your Access sheet or check your internet")
        End Try
        TextBox1.Text = Val(TextBox1.Text) + 1
        TextBox4.Text = 1

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        con = New Odbc.OdbcConnection("DSN=data")
        con.Open()

       
        TextBox1.Text = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Navigate(drv(2))
        TextBox4.Text = 0
        ProgressBar1.Visible = True










    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ProgressBar1.Value = 0

        ProgressBar1.Visible = False

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ProgressBar1.Visible = True

        Try

            ada = New Odbc.OdbcDataAdapter("select * from data where fname='" & TextBox3.Text & "'", con)
            ds = New DataSet()
            ada.Fill(ds, "data")
            dv = New Data.DataView(ds.Tables("data"))
            drv = dv(0)
            a = drv(0)
            z = drv(1)
            WebBrowser1.Navigate(drv(2))

            ada1 = New Odbc.OdbcDataAdapter("select * from " & a & "", con)
            ds1 = New DataSet()
            ada1.Fill(ds1, a)
            dv1 = New Data.DataView(ds1.Tables(a))
            drv1 = dv1(0)
            Button1.Enabled = True
            Button2.Enabled = True


        Catch ex As Exception
            MsgBox("The table name you specified has no values in it")

        End Try
    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged


        If e.CurrentProgress > 0 Then
            ProgressBar1.Increment(e.CurrentProgress)




        End If




    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub WebBrowser1_SystemColorsChanged(sender As Object, e As EventArgs) Handles WebBrowser1.SystemColorsChanged

    End Sub
End Class
