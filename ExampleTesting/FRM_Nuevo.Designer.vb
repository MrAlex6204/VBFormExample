<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Nuevo
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
        Me.cmdNotificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdNotificar
        '
        Me.cmdNotificar.Location = New System.Drawing.Point(12, 12)
        Me.cmdNotificar.Name = "cmdNotificar"
        Me.cmdNotificar.Size = New System.Drawing.Size(303, 37)
        Me.cmdNotificar.TabIndex = 0
        Me.cmdNotificar.Text = "Realizar Notificacion"
        Me.cmdNotificar.UseVisualStyleBackColor = True
        '
        'FRM_Nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 61)
        Me.Controls.Add(Me.cmdNotificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_Nuevo"
        Me.ShowIcon = False
        Me.Text = "Nuevo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdNotificar As System.Windows.Forms.Button
End Class
