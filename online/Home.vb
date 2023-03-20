Public Class Home

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click



    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Form1.Show()

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub AutoModeToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub IDFetcherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDFetcherToolStripMenuItem.Click
        cnf.Show()
    End Sub

    Private Sub IDFeederToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDFeederToolStripMenuItem.Click
        Form2.Show()

    End Sub
End Class