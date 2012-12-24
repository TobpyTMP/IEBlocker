Public Class Form1
    Dim autostartpfad As String = Application.ExecutablePath
    Dim autostartpfad1 As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "/" & IO.Path.GetFileName(autostartpfad)
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0.01
        Me.ShowInTaskbar = False
        Blocker.Start()
        Try
            IO.File.Copy(autostartpfad, autostartpfad1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BlockerBeendenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BlockerBeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BlockerStoppenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BlockerStoppenToolStripMenuItem.Click
        If BlockerStoppenToolStripMenuItem.Pressed Then
            NotifyIcon1.Icon = My.Resources.IEda
            Blocker.Stop()
        End If
        BlockerStoppenToolStripMenuItem.Enabled = False
        BlockerStartenToolStripMenuItem.Enabled = True

    End Sub

    Private Sub BlockerStartenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BlockerStartenToolStripMenuItem.Click
        If BlockerStartenToolStripMenuItem.Pressed Then
            NotifyIcon1.Icon = My.Resources.IEBlock
            Blocker.Start()
        End If
        BlockerStartenToolStripMenuItem.Enabled = False
        BlockerStoppenToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Checker_Tick(sender As System.Object, e As System.EventArgs) Handles Checker.Tick
        For Each iexplore In Process.GetProcessesByName(Name)
            Blocker.Start()
        Next




    End Sub

    Private Sub Blocker_Tick(sender As System.Object, e As System.EventArgs) Handles Blocker.Tick
        Try
            Name = "iexplore"
            For Each iexplore In Process.GetProcessesByName(Name)
                iexplore.Kill()
            Next
        Catch : End Try

    End Sub

    Private Sub BeimStartVonWindowsStartenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BeimStartVonWindowsStartenToolStripMenuItem.Click
        If BeimStartVonWindowsStartenToolStripMenuItem.CheckState = CheckState.Checked Then
            Try
                IO.File.Copy(autostartpfad, autostartpfad1)
            Catch ex As Exception
            End Try
        End If

        If BeimStartVonWindowsStartenToolStripMenuItem.CheckState = CheckState.Unchecked Then
            Try
                IO.File.Delete(autostartpfad1)
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub Unblocker_Tick(sender As System.Object, e As System.EventArgs) Handles Unblocker.Tick

    End Sub
End Class

