<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPosDetail
    'Inherits System.Windows.Forms.Form
    Inherits Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNetTotal = New System.Windows.Forms.Label()
        Me.txtNetTotal = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmbTax = New System.Windows.Forms.ComboBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPalette = New System.Windows.Forms.ComboBox()
        Me.dgvData = New Krypton.Toolkit.KryptonDataGridView()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(117, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(177, 26)
        Me.txtSearch.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ค้นหารหัสสินค้า:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(300, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(412, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ตัวอย่างข้อมูลให้กด 01 - 22 ตามด้วย Enter เพื่อทำการค้นหาสินค้า"
        '
        'lblNetTotal
        '
        Me.lblNetTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNetTotal.AutoSize = True
        Me.lblNetTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNetTotal.Location = New System.Drawing.Point(440, 516)
        Me.lblNetTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNetTotal.Name = "lblNetTotal"
        Me.lblNetTotal.Size = New System.Drawing.Size(165, 19)
        Me.lblNetTotal.TabIndex = 55
        Me.lblNetTotal.Text = "จำนวนเงินรวมทั้งสิ้น :"
        Me.lblNetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNetTotal
        '
        Me.txtNetTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNetTotal.BackColor = System.Drawing.Color.Crimson
        Me.txtNetTotal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNetTotal.ForeColor = System.Drawing.Color.Yellow
        Me.txtNetTotal.Location = New System.Drawing.Point(613, 510)
        Me.txtNetTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNetTotal.Name = "txtNetTotal"
        Me.txtNetTotal.ReadOnly = True
        Me.txtNetTotal.Size = New System.Drawing.Size(135, 30)
        Me.txtNetTotal.TabIndex = 6
        Me.txtNetTotal.TabStop = False
        Me.txtNetTotal.Text = "txtNetTotal"
        Me.txtNetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVat
        '
        Me.txtVat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVat.BackColor = System.Drawing.Color.Cornsilk
        Me.txtVat.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVat.ForeColor = System.Drawing.Color.Blue
        Me.txtVat.Location = New System.Drawing.Point(613, 476)
        Me.txtVat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.ReadOnly = True
        Me.txtVat.Size = New System.Drawing.Size(135, 30)
        Me.txtVat.TabIndex = 5
        Me.txtVat.TabStop = False
        Me.txtVat.Text = "txtVat"
        Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(482, 448)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(123, 19)
        Me.lblTotal.TabIndex = 53
        Me.lblTotal.Text = "รวมจำนวนเงิน :"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.BackColor = System.Drawing.Color.LightCyan
        Me.txtTotal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Blue
        Me.txtTotal.Location = New System.Drawing.Point(613, 442)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(135, 30)
        Me.txtTotal.TabIndex = 4
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "txtTotal"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(755, 44)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 32)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "จบโปรแกรม"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cmbTax
        '
        Me.cmbTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbTax.FormattingEnabled = True
        Me.cmbTax.Location = New System.Drawing.Point(452, 476)
        Me.cmbTax.Name = "cmbTax"
        Me.cmbTax.Size = New System.Drawing.Size(153, 27)
        Me.cmbTax.TabIndex = 3
        '
        'lblTax
        '
        Me.lblTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTax.Location = New System.Drawing.Point(383, 479)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(62, 19)
        Me.lblTax.TabIndex = 57
        Me.lblTax.Text = "คิดภาษี"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Select PaletteMode"
        '
        'cmbPalette
        '
        Me.cmbPalette.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbPalette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPalette.FormattingEnabled = True
        Me.cmbPalette.Location = New System.Drawing.Point(8, 460)
        Me.cmbPalette.Name = "cmbPalette"
        Me.cmbPalette.Size = New System.Drawing.Size(241, 26)
        Me.cmbPalette.TabIndex = 2
        '
        'dgvData
        '
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.Location = New System.Drawing.Point(8, 44)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(740, 391)
        Me.dgvData.TabIndex = 1
        '
        'frmPosDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 544)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.cmbPalette)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.cmbTax)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblNetTotal)
        Me.Controls.Add(Me.txtNetTotal)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(887, 583)
        Me.Name = "frmPosDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point Of Sale for Detail with Krypton DataGridView - coDe bY: Thongkorn Tubtimkro" &
    "b"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNetTotal As System.Windows.Forms.Label
    Friend WithEvents txtNetTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmbTax As System.Windows.Forms.ComboBox
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPalette As ComboBox
    Friend WithEvents dgvData As Krypton.Toolkit.KryptonDataGridView
End Class
