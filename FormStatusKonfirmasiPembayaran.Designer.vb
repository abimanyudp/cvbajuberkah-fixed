<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatusKonfirmasiPembayaran
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ID_Pembeli = New System.Windows.Forms.ColumnHeader()
        Me.Nama_Konsumen = New System.Windows.Forms.ColumnHeader()
        Me.Alamat = New System.Windows.Forms.ColumnHeader()
        Me.Kode_Pos = New System.Windows.Forms.ColumnHeader()
        Me.Barang = New System.Windows.Forms.ColumnHeader()
        Me.Qty = New System.Windows.Forms.ColumnHeader()
        Me.Total_Harga = New System.Windows.Forms.ColumnHeader()
        Me.Status = New System.Windows.Forms.ColumnHeader()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID_Pembeli, Me.Nama_Konsumen, Me.Alamat, Me.Kode_Pos, Me.Barang, Me.Qty, Me.Total_Harga, Me.Status})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(486, 300)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID_Pembeli
        '
        Me.ID_Pembeli.Text = "ID"
        '
        'Nama_Konsumen
        '
        Me.Nama_Konsumen.Text = "Nama Konsumen"
        '
        'Alamat
        '
        Me.Alamat.Text = "Alamat"
        '
        'Kode_Pos
        '
        Me.Kode_Pos.Text = "Kode Pos"
        '
        'Barang
        '
        Me.Barang.Text = "Barang"
        '
        'Qty
        '
        Me.Qty.Text = "Qty"
        '
        'Total_Harga
        '
        Me.Total_Harga.Text = "TOTAL HARGA"
        '
        'Status
        '
        Me.Status.Text = "STATUS PEMBAYARAN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cvbajuberkah.My.Resources.Resources.buktitransfer
        Me.PictureBox1.Location = New System.Drawing.Point(519, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(641, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Status :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(692, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "DITERIMA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(773, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "DITOLAK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 322)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 40)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "<---"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormStatusKonfirmasiPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 374)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "FormStatusKonfirmasiPembayaran"
        Me.Text = "Status Konfirmasi Pembayaran"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Nama_Konsumen As ColumnHeader
    Friend WithEvents Alamat As ColumnHeader
    Friend WithEvents Kode_Pos As ColumnHeader
    Friend WithEvents Barang As ColumnHeader
    Friend WithEvents Qty As ColumnHeader
    Friend WithEvents Total_Harga As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ID_Pembeli As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
