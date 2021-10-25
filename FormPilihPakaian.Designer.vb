<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPilihPakaian
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cvbajuberkah.My.Resources.Resources.T_SHIRT
        Me.PictureBox1.Location = New System.Drawing.Point(81, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(624, 486)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"Graphics T-Shirt", "Baju Muslim Pria", "Baju Muslim Wanita", "Jaket Denim", "Celana Denim"})
        Me.ListBox1.Location = New System.Drawing.Point(8, 554)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(449, 94)
        Me.ListBox1.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"S", "M", "L", "XL"})
        Me.ComboBox1.Location = New System.Drawing.Point(474, 554)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(292, 23)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Text = "Ukuran"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(506, 590)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 23)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "100 produk"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(506, 619)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(260, 23)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "Rp. 50.000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(470, 593)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Stok :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(461, 619)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Harga :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(506, 665)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Masuk ke Keranjang"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(705, 665)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(110, 665)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 10
        '
        'FormPilihPakaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 823)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormPilihPakaian"
        Me.Text = "Pilih Pakaian"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
