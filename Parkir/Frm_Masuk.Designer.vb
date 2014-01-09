<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Masuk
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
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblTanggal = New System.Windows.Forms.Label
        Me.LblJam = New System.Windows.Forms.Label
        Me.TxtKd_parkir = New System.Windows.Forms.TextBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.tSLABEL = New System.Windows.Forms.Label
        Me.BtnOk = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.BackColor = System.Drawing.Color.Transparent
        Me.LblTanggal.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTanggal.ForeColor = System.Drawing.Color.Red
        Me.LblTanggal.Location = New System.Drawing.Point(511, 21)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(200, 38)
        Me.LblTanggal.TabIndex = 1
        Me.LblTanggal.Text = "TANGGAL"
        '
        'LblJam
        '
        Me.LblJam.AutoSize = True
        Me.LblJam.BackColor = System.Drawing.Color.Transparent
        Me.LblJam.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJam.ForeColor = System.Drawing.Color.Red
        Me.LblJam.Location = New System.Drawing.Point(717, 21)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(95, 38)
        Me.LblJam.TabIndex = 2
        Me.LblJam.Text = "JAM"
        '
        'TxtKd_parkir
        '
        Me.TxtKd_parkir.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKd_parkir.Location = New System.Drawing.Point(286, 385)
        Me.TxtKd_parkir.Name = "TxtKd_parkir"
        Me.TxtKd_parkir.ReadOnly = True
        Me.TxtKd_parkir.Size = New System.Drawing.Size(309, 47)
        Me.TxtKd_parkir.TabIndex = 3
        Me.TxtKd_parkir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 500
        '
        'tSLABEL
        '
        Me.tSLABEL.AutoSize = True
        Me.tSLABEL.BackColor = System.Drawing.Color.Transparent
        Me.tSLABEL.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSLABEL.ForeColor = System.Drawing.Color.Red
        Me.tSLABEL.Location = New System.Drawing.Point(127, 447)
        Me.tSLABEL.Name = "tSLABEL"
        Me.tSLABEL.Size = New System.Drawing.Size(238, 57)
        Me.tSLABEL.TabIndex = 4
        Me.tSLABEL.Text = "TANGGAL"
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnOk.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.ForeColor = System.Drawing.Color.Red
        Me.BtnOk.Image = Global.Parkir.My.Resources.Resources.PANAH
        Me.BtnOk.Location = New System.Drawing.Point(286, 135)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(309, 244)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'Frm_Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(879, 513)
        Me.Controls.Add(Me.tSLABEL)
        Me.Controls.Add(Me.TxtKd_parkir)
        Me.Controls.Add(Me.LblJam)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.BtnOk)
        Me.Name = "Frm_Masuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Masuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblTanggal As System.Windows.Forms.Label
    Friend WithEvents LblJam As System.Windows.Forms.Label
    Friend WithEvents TxtKd_parkir As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents tSLABEL As System.Windows.Forms.Label
End Class
