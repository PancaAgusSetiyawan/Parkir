<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_User
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtPass = New System.Windows.Forms.TextBox
        Me.TxtId = New System.Windows.Forms.TextBox
        Me.TxtJab = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.GrdUser = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrdUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(14, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "JABATAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(14, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "USER ID"
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(174, 58)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(237, 29)
        Me.TxtPass.TabIndex = 11
        '
        'TxtId
        '
        Me.TxtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(174, 17)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(237, 29)
        Me.TxtId.TabIndex = 10
        '
        'TxtJab
        '
        Me.TxtJab.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJab.Location = New System.Drawing.Point(174, 101)
        Me.TxtJab.Name = "TxtJab"
        Me.TxtJab.Size = New System.Drawing.Size(237, 29)
        Me.TxtJab.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 127)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Blue
        Me.BtnClose.Location = New System.Drawing.Point(256, 74)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(121, 47)
        Me.BtnClose.TabIndex = 27
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Blue
        Me.BtnSave.Location = New System.Drawing.Point(14, 74)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(121, 47)
        Me.BtnSave.TabIndex = 26
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Blue
        Me.BtnCancel.Location = New System.Drawing.Point(256, 21)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(121, 47)
        Me.BtnCancel.TabIndex = 25
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.Blue
        Me.BtnEdit.Location = New System.Drawing.Point(135, 21)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(121, 47)
        Me.BtnEdit.TabIndex = 24
        Me.BtnEdit.Text = "EDIT"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Blue
        Me.BtnDelete.Location = New System.Drawing.Point(135, 74)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(121, 47)
        Me.BtnDelete.TabIndex = 23
        Me.BtnDelete.Text = "DELETE"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.Blue
        Me.BtnAdd.Location = New System.Drawing.Point(14, 21)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(121, 47)
        Me.BtnAdd.TabIndex = 22
        Me.BtnAdd.Text = "ADD"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GrdUser
        '
        Me.GrdUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdUser.Location = New System.Drawing.Point(424, 16)
        Me.GrdUser.Name = "GrdUser"
        Me.GrdUser.Size = New System.Drawing.Size(441, 260)
        Me.GrdUser.TabIndex = 18
        '
        'Frm_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(874, 292)
        Me.Controls.Add(Me.GrdUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtJab)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtId)
        Me.Name = "Frm_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_User"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GrdUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents TxtJab As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents GrdUser As System.Windows.Forms.DataGridView
End Class
