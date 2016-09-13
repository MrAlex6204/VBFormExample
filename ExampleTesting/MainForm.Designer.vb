<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 24)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(269, 239)
        Me.cmdNuevo.TabIndex = 0
        Me.cmdNuevo.Text = "Ejecutar nuevo dispositivo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.Navy
        Me.lblStatus.Font = New System.Drawing.Font("Consolas", 10.25!)
        Me.lblStatus.ForeColor = System.Drawing.Color.Silver
        Me.lblStatus.Location = New System.Drawing.Point(9, 279)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(272, 34)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Status: "
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 322)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmdNuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.Text = "Formulario Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
