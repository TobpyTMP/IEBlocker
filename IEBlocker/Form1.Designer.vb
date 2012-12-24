<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BlockerStoppenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlockerStartenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeimStartVonWindowsStartenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlockerBeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Blocker = New System.Windows.Forms.Timer(Me.components)
        Me.Unblocker = New System.Windows.Forms.Timer(Me.components)
        Me.Checker = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.NotifyIcon1.BalloonTipText = "Internet Explorer Blockieren"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Tag = "Blockieren Sie den Windows Internet Explorer"
        Me.NotifyIcon1.Text = "IE Blocker"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlockerStoppenToolStripMenuItem, Me.BlockerStartenToolStripMenuItem, Me.ToolStripSeparator2, Me.BeimStartVonWindowsStartenToolStripMenuItem, Me.ToolStripSeparator1, Me.BlockerBeendenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(242, 104)
        Me.ContextMenuStrip1.Text = "IE Blocker"
        '
        'BlockerStoppenToolStripMenuItem
        '
        Me.BlockerStoppenToolStripMenuItem.Name = "BlockerStoppenToolStripMenuItem"
        Me.BlockerStoppenToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.BlockerStoppenToolStripMenuItem.Text = "Blocker Stoppen"
        '
        'BlockerStartenToolStripMenuItem
        '
        Me.BlockerStartenToolStripMenuItem.Enabled = False
        Me.BlockerStartenToolStripMenuItem.Name = "BlockerStartenToolStripMenuItem"
        Me.BlockerStartenToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.BlockerStartenToolStripMenuItem.Text = "Blocker starten"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(238, 6)
        '
        'BeimStartVonWindowsStartenToolStripMenuItem
        '
        Me.BeimStartVonWindowsStartenToolStripMenuItem.Checked = True
        Me.BeimStartVonWindowsStartenToolStripMenuItem.CheckOnClick = True
        Me.BeimStartVonWindowsStartenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BeimStartVonWindowsStartenToolStripMenuItem.Name = "BeimStartVonWindowsStartenToolStripMenuItem"
        Me.BeimStartVonWindowsStartenToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.BeimStartVonWindowsStartenToolStripMenuItem.Text = "Beim start von Windows starten"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(238, 6)
        '
        'BlockerBeendenToolStripMenuItem
        '
        Me.BlockerBeendenToolStripMenuItem.Name = "BlockerBeendenToolStripMenuItem"
        Me.BlockerBeendenToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.BlockerBeendenToolStripMenuItem.Text = "Blocker Beenden"
        '
        'Blocker
        '
        '
        'Unblocker
        '
        '
        'Checker
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 262)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BlockerStoppenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlockerStartenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BlockerBeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Blocker As System.Windows.Forms.Timer
    Friend WithEvents Unblocker As System.Windows.Forms.Timer
    Friend WithEvents Checker As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BeimStartVonWindowsStartenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
