<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.notelp = New System.Windows.Forms.TextBox()
        Me.update = New System.Windows.Forms.Button()
        Me.tmblhapus = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.tmblbaru = New System.Windows.Forms.Button()
        Me.kodekonsumen = New System.Windows.Forms.TextBox()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama                 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alamat               :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No Telp             :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Location = New System.Drawing.Point(32, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(600, 195)
        Me.DataGridView1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "kode konsumen :"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(127, 57)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(200, 20)
        Me.nama.TabIndex = 7
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(127, 88)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(200, 20)
        Me.alamat.TabIndex = 8
        '
        'notelp
        '
        Me.notelp.Location = New System.Drawing.Point(127, 120)
        Me.notelp.MaxLength = 13
        Me.notelp.Name = "notelp"
        Me.notelp.Size = New System.Drawing.Size(200, 20)
        Me.notelp.TabIndex = 9
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(476, 399)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(75, 23)
        Me.update.TabIndex = 10
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'tmblhapus
        '
        Me.tmblhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tmblhapus.Location = New System.Drawing.Point(557, 399)
        Me.tmblhapus.Name = "tmblhapus"
        Me.tmblhapus.Size = New System.Drawing.Size(75, 23)
        Me.tmblhapus.TabIndex = 11
        Me.tmblhapus.Text = "Hapus"
        Me.tmblhapus.UseVisualStyleBackColor = False
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(113, 390)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(75, 23)
        Me.simpan.TabIndex = 12
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'tmblbaru
        '
        Me.tmblbaru.Location = New System.Drawing.Point(32, 390)
        Me.tmblbaru.Name = "tmblbaru"
        Me.tmblbaru.Size = New System.Drawing.Size(75, 23)
        Me.tmblbaru.TabIndex = 13
        Me.tmblbaru.Text = "Baru"
        Me.tmblbaru.UseVisualStyleBackColor = True
        '
        'kodekonsumen
        '
        Me.kodekonsumen.Location = New System.Drawing.Point(127, 28)
        Me.kodekonsumen.Name = "kodekonsumen"
        Me.kodekonsumen.ReadOnly = True
        Me.kodekonsumen.Size = New System.Drawing.Size(200, 20)
        Me.kodekonsumen.TabIndex = 14
        '
        'textsearch
        '
        Me.textsearch.Location = New System.Drawing.Point(433, 28)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(118, 20)
        Me.textsearch.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(557, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 434)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textsearch)
        Me.Controls.Add(Me.kodekonsumen)
        Me.Controls.Add(Me.tmblbaru)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.tmblhapus)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.notelp)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Konsumen"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents alamat As System.Windows.Forms.TextBox
    Friend WithEvents notelp As System.Windows.Forms.TextBox
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents tmblhapus As System.Windows.Forms.Button
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents tmblbaru As System.Windows.Forms.Button
    Friend WithEvents kodekonsumen As System.Windows.Forms.TextBox
    Friend WithEvents textsearch As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
