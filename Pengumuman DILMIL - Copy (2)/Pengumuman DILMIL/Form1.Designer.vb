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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_waktu = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_waktu = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_belpulang = New System.Windows.Forms.TextBox()
        Me.lbl_belpulang = New System.Windows.Forms.Label()
        Me.txt_p1 = New System.Windows.Forms.TextBox()
        Me.lbl_p1 = New System.Windows.Forms.Label()
        Me.txt_p2 = New System.Windows.Forms.TextBox()
        Me.lbl_p2 = New System.Windows.Forms.Label()
        Me.txt_p3 = New System.Windows.Forms.TextBox()
        Me.lbl_p3 = New System.Windows.Forms.Label()
        Me.txt_p4 = New System.Windows.Forms.TextBox()
        Me.lbl_p4 = New System.Windows.Forms.Label()
        Me.txt_p5 = New System.Windows.Forms.TextBox()
        Me.lbl_p5 = New System.Windows.Forms.Label()
        Me.lbl_timenow = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.GantiJamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Location = New System.Drawing.Point(267, 30)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(208, 13)
        Me.lbl_nama.TabIndex = 0
        Me.lbl_nama.Text = "PENGADILAN MILITER I-05 PONTIANAK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PENGUMUMAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bel Pagi"
        '
        'btn_waktu
        '
        Me.btn_waktu.Location = New System.Drawing.Point(0, 226)
        Me.btn_waktu.Name = "btn_waktu"
        Me.btn_waktu.Size = New System.Drawing.Size(716, 23)
        Me.btn_waktu.TabIndex = 4
        Me.btn_waktu.Text = "Software Otomatis, Tidak Bisa Ganti Jam"
        Me.btn_waktu.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'txt_waktu
        '
        Me.txt_waktu.Location = New System.Drawing.Point(222, 127)
        Me.txt_waktu.Name = "txt_waktu"
        Me.txt_waktu.Size = New System.Drawing.Size(100, 20)
        Me.txt_waktu.TabIndex = 8
        Me.txt_waktu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_belpulang
        '
        Me.txt_belpulang.Location = New System.Drawing.Point(397, 127)
        Me.txt_belpulang.Name = "txt_belpulang"
        Me.txt_belpulang.Size = New System.Drawing.Size(100, 20)
        Me.txt_belpulang.TabIndex = 12
        Me.txt_belpulang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_belpulang
        '
        Me.lbl_belpulang.AutoSize = True
        Me.lbl_belpulang.Location = New System.Drawing.Point(417, 98)
        Me.lbl_belpulang.Name = "lbl_belpulang"
        Me.lbl_belpulang.Size = New System.Drawing.Size(58, 13)
        Me.lbl_belpulang.TabIndex = 11
        Me.lbl_belpulang.Text = "Bel Pulang"
        '
        'txt_p1
        '
        Me.txt_p1.Location = New System.Drawing.Point(37, 196)
        Me.txt_p1.Name = "txt_p1"
        Me.txt_p1.Size = New System.Drawing.Size(100, 20)
        Me.txt_p1.TabIndex = 14
        Me.txt_p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_p1
        '
        Me.lbl_p1.AutoSize = True
        Me.lbl_p1.Location = New System.Drawing.Point(46, 167)
        Me.lbl_p1.Name = "lbl_p1"
        Me.lbl_p1.Size = New System.Drawing.Size(81, 13)
        Me.lbl_p1.TabIndex = 13
        Me.lbl_p1.Text = "Pengumuman 1"
        '
        'txt_p2
        '
        Me.txt_p2.Location = New System.Drawing.Point(166, 196)
        Me.txt_p2.Name = "txt_p2"
        Me.txt_p2.Size = New System.Drawing.Size(100, 20)
        Me.txt_p2.TabIndex = 16
        Me.txt_p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_p2
        '
        Me.lbl_p2.AutoSize = True
        Me.lbl_p2.Location = New System.Drawing.Point(175, 167)
        Me.lbl_p2.Name = "lbl_p2"
        Me.lbl_p2.Size = New System.Drawing.Size(81, 13)
        Me.lbl_p2.TabIndex = 15
        Me.lbl_p2.Text = "Pengumuman 2"
        '
        'txt_p3
        '
        Me.txt_p3.Location = New System.Drawing.Point(306, 196)
        Me.txt_p3.Name = "txt_p3"
        Me.txt_p3.Size = New System.Drawing.Size(100, 20)
        Me.txt_p3.TabIndex = 18
        Me.txt_p3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_p3
        '
        Me.lbl_p3.AutoSize = True
        Me.lbl_p3.Location = New System.Drawing.Point(317, 167)
        Me.lbl_p3.Name = "lbl_p3"
        Me.lbl_p3.Size = New System.Drawing.Size(81, 13)
        Me.lbl_p3.TabIndex = 17
        Me.lbl_p3.Text = "Pengumuman 3"
        '
        'txt_p4
        '
        Me.txt_p4.Location = New System.Drawing.Point(436, 196)
        Me.txt_p4.Name = "txt_p4"
        Me.txt_p4.Size = New System.Drawing.Size(100, 20)
        Me.txt_p4.TabIndex = 20
        Me.txt_p4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_p4
        '
        Me.lbl_p4.AutoSize = True
        Me.lbl_p4.Location = New System.Drawing.Point(445, 167)
        Me.lbl_p4.Name = "lbl_p4"
        Me.lbl_p4.Size = New System.Drawing.Size(81, 13)
        Me.lbl_p4.TabIndex = 19
        Me.lbl_p4.Text = "Pengumuman 4"
        '
        'txt_p5
        '
        Me.txt_p5.Location = New System.Drawing.Point(570, 196)
        Me.txt_p5.Name = "txt_p5"
        Me.txt_p5.Size = New System.Drawing.Size(100, 20)
        Me.txt_p5.TabIndex = 22
        Me.txt_p5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_p5
        '
        Me.lbl_p5.AutoSize = True
        Me.lbl_p5.Location = New System.Drawing.Point(573, 167)
        Me.lbl_p5.Name = "lbl_p5"
        Me.lbl_p5.Size = New System.Drawing.Size(81, 13)
        Me.lbl_p5.TabIndex = 21
        Me.lbl_p5.Text = "Pengumuman 5"
        '
        'lbl_timenow
        '
        Me.lbl_timenow.AutoSize = True
        Me.lbl_timenow.Location = New System.Drawing.Point(640, 50)
        Me.lbl_timenow.Name = "lbl_timenow"
        Me.lbl_timenow.Size = New System.Drawing.Size(64, 13)
        Me.lbl_timenow.TabIndex = 23
        Me.lbl_timenow.Text = "HH:mm:ss tt"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(592, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(42, 20)
        Me.TextBox1.TabIndex = 25
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(91, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(716, 25)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantiJamToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton1.Text = "Menu"
        '
        'GantiJamToolStripMenuItem
        '
        Me.GantiJamToolStripMenuItem.Name = "GantiJamToolStripMenuItem"
        Me.GantiJamToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.GantiJamToolStripMenuItem.Text = "Test"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 252)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_timenow)
        Me.Controls.Add(Me.txt_p5)
        Me.Controls.Add(Me.lbl_p5)
        Me.Controls.Add(Me.txt_p4)
        Me.Controls.Add(Me.lbl_p4)
        Me.Controls.Add(Me.txt_p3)
        Me.Controls.Add(Me.lbl_p3)
        Me.Controls.Add(Me.txt_p2)
        Me.Controls.Add(Me.lbl_p2)
        Me.Controls.Add(Me.txt_p1)
        Me.Controls.Add(Me.lbl_p1)
        Me.Controls.Add(Me.txt_belpulang)
        Me.Controls.Add(Me.lbl_belpulang)
        Me.Controls.Add(Me.txt_waktu)
        Me.Controls.Add(Me.btn_waktu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_nama)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PENGUMUMAN PENGADILAN MILITER I-05"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nama As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_waktu As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txt_waktu As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_belpulang As System.Windows.Forms.TextBox
    Friend WithEvents lbl_belpulang As System.Windows.Forms.Label
    Friend WithEvents txt_p1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_p1 As System.Windows.Forms.Label
    Friend WithEvents txt_p2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_p2 As System.Windows.Forms.Label
    Friend WithEvents txt_p3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_p3 As System.Windows.Forms.Label
    Friend WithEvents txt_p4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_p4 As System.Windows.Forms.Label
    Friend WithEvents txt_p5 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_p5 As System.Windows.Forms.Label
    Friend WithEvents lbl_timenow As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents GantiJamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
