<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Keluar
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
        Me.LblTgl = New System.Windows.Forms.Label
        Me.LblJam = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtJamMSK = New System.Windows.Forms.TextBox
        Me.CboJns = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtTarif = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtPlat = New System.Windows.Forms.TextBox
        Me.TxtKd = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTgl
        '
        Me.LblTgl.AutoSize = True
        Me.LblTgl.BackColor = System.Drawing.Color.Transparent
        Me.LblTgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTgl.ForeColor = System.Drawing.Color.Red
        Me.LblTgl.Location = New System.Drawing.Point(618, 24)
        Me.LblTgl.Name = "LblTgl"
        Me.LblTgl.Size = New System.Drawing.Size(97, 25)
        Me.LblTgl.TabIndex = 3
        Me.LblTgl.Text = "Tanggal"
        '
        'LblJam
        '
        Me.LblJam.AutoSize = True
        Me.LblJam.BackColor = System.Drawing.Color.Transparent
        Me.LblJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJam.ForeColor = System.Drawing.Color.Red
        Me.LblJam.Location = New System.Drawing.Point(749, 24)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(55, 25)
        Me.LblJam.TabIndex = 4
        Me.LblJam.Text = "Jam"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtJamMSK)
        Me.GroupBox1.Controls.Add(Me.CboJns)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtTarif)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtPlat)
        Me.GroupBox1.Controls.Add(Me.TxtKd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 166)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'TxtJamMSK
        '
        Me.TxtJamMSK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJamMSK.Location = New System.Drawing.Point(560, 107)
        Me.TxtJamMSK.Name = "TxtJamMSK"
        Me.TxtJamMSK.ReadOnly = True
        Me.TxtJamMSK.Size = New System.Drawing.Size(327, 31)
        Me.TxtJamMSK.TabIndex = 19
        '
        'CboJns
        '
        Me.CboJns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboJns.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboJns.FormattingEnabled = True
        Me.CboJns.Location = New System.Drawing.Point(281, 66)
        Me.CboJns.Name = "CboJns"
        Me.CboJns.Size = New System.Drawing.Size(197, 32)
        Me.CboJns.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(16, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 29)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "PLAT NO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(16, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(249, 29)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "JENIS KENDARAAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(16, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "KODE MASUK"
        '
        'TxtTarif
        '
        Me.TxtTarif.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTarif.Location = New System.Drawing.Point(560, 26)
        Me.TxtTarif.Name = "TxtTarif"
        Me.TxtTarif.ReadOnly = True
        Me.TxtTarif.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTarif.Size = New System.Drawing.Size(327, 80)
        Me.TxtTarif.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(484, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "TARIF"
        '
        'TxtPlat
        '
        Me.TxtPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlat.Location = New System.Drawing.Point(281, 107)
        Me.TxtPlat.Name = "TxtPlat"
        Me.TxtPlat.Size = New System.Drawing.Size(197, 31)
        Me.TxtPlat.TabIndex = 12
        '
        'TxtKd
        '
        Me.TxtKd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKd.Location = New System.Drawing.Point(281, 26)
        Me.TxtKd.Name = "TxtKd"
        Me.TxtKd.Size = New System.Drawing.Size(197, 31)
        Me.TxtKd.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnClose)
        Me.GroupBox2.Controls.Add(Me.BtnCancel)
        Me.GroupBox2.Controls.Add(Me.BtnSave)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(901, 71)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Blue
        Me.BtnClose.Location = New System.Drawing.Point(755, 19)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(129, 38)
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.Text = "KELUAR"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Blue
        Me.BtnCancel.Location = New System.Drawing.Point(621, 19)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(129, 38)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Blue
        Me.BtnSave.Location = New System.Drawing.Point(486, 19)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(129, 38)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Frm_Keluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(928, 370)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblJam)
        Me.Controls.Add(Me.LblTgl)
        Me.Name = "Frm_Keluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTgl As System.Windows.Forms.Label
    Friend WithEvents LblJam As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTarif As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPlat As System.Windows.Forms.TextBox
    Friend WithEvents TxtKd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CboJns As System.Windows.Forms.ComboBox
    Friend WithEvents TxtJamMSK As System.Windows.Forms.TextBox
End Class
