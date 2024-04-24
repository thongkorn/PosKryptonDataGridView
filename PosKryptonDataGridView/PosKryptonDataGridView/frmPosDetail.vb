#Region "ABOUT"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: http://www.facebook.com/g2gnet (for Thailand)
' / Facebook: http://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gsoft.com
' /
' / Purpose: Demonstrate search product from DataTable and calculate product sales results.
' / Microsoft Visual Basic .NET (2017 - .Net Framework 4.6.2+)
' / Krypton Toolkit for .Net Framework 4.6.2+ (80.24.3.64)
' / https://www.nuget.org/packages/Krypton.Toolkit
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Imports Krypton.Toolkit
Public Class frmPosDetail

    Private Sub frmPosDetail_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F8
                '/ Remove Row
                Call DeleteRow("btnDelRow")
        End Select
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / S T A R T ... H E R E
    ' / --------------------------------------------------------------------------------
    Private Sub frmPosDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True  '/ สามารถกดปุ่มฟังค์ชั่นคีย์ลงในฟอร์มได้
        '// ตั้งค่าให้กับ Krypton DataGridView แบบ Run Time
        Call InitializeGrid()
        '// Set all TextBox Control to Zero and ReadOnly except txtSearch.
        For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
            If tb.Name <> "txtSearch" Then
                tb.Text = "0.00"
                tb.ReadOnly = True
            End If
        Next
        With cmbTax
            .Items.Add("ไม่คิดภาษี")
            .Items.Add("รวมภาษีใน (7%)")
            .Items.Add("แยกภาษีนอก (7%)")
        End With
        cmbTax.SelectedIndex = 1    '// Include VAT
        '// กำหนดฟอร์มให้เป็นแบบ Global ขึ้นอยู่กับ Palette ที่เราเลือกจาก ComboBox (cmbPalette)
        Me.PaletteMode = PaletteMode.Global
        '// ลองใช้ KryptonThemeComboBox ดูแล้วมันออกเอ๋อๆเป็นบางครั้ง คือไม่แสดงผลข้อมูลออกมา ก็เลยใช้แบบ Manual เอานี่แหละครับ
        With cmbPalette
            .Items.Add("ProfessionalSystem")
            .Items.Add("ProfessionalOffice2003")
            .Items.Add("Office2007DarkGray")
            .Items.Add("Office2007Blue")
            .Items.Add("Office2007BlueDarkMode")
            .Items.Add("Office2007BlueLightMode")
            .Items.Add("Office2007Silver")
            .Items.Add("Office2007SilverDarkMode")
            .Items.Add("Office2007SilverLightMode")
            .Items.Add("Office2007White")
            .Items.Add("Office2007Black")
            .Items.Add("Office2007BlackDarkMode")
            .Items.Add("Office2010DarkGray")
            .Items.Add("Office2010Blue")
            .Items.Add("Office2010BlueDarkMode")
            .Items.Add("Office2010BlueLightMode")
            .Items.Add("Office2010Silver")
            .Items.Add("Office2010SilverDarkMode")
            .Items.Add("Office2010SilverLightMode")
            .Items.Add("Office2010White")
            .Items.Add("Office2010Black")
            .Items.Add("Office2010BlackDarkMode")
            .Items.Add("Office2013DarkGray")
            .Items.Add("Office2013LightGray")
            .Items.Add("Office2013White")
        End With
        With cmbPalette
            .SelectedIndex = 19
            .ItemHeight = 10
            .IntegralHeight = False
        End With
        '// ตัวอย่างหากต้องการเลือก Palette Mode ให้กับ Krypton DataGridView โดยเฉพาะ
        'dgvData.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Silver
    End Sub

    ' / --------------------------------------------------------------------------------------------
    ' / Change Palette Mode.
    ' / --------------------------------------------------------------------------------------------
    Private Sub cmbPalette_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbPalette.SelectedIndexChanged
        Dim manager As New KryptonManager()
        Select Case cmbPalette.SelectedIndex
            Case 0
                manager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
            Case 1
                manager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
            Case 2
                manager.GlobalPaletteMode = PaletteMode.Office2007DarkGray
            Case 3
                manager.GlobalPaletteMode = PaletteMode.Office2007Blue
            Case 4
                manager.GlobalPaletteMode = PaletteMode.Office2007BlueDarkMode
            Case 5
                manager.GlobalPaletteMode = PaletteMode.Office2007BlueLightMode
            Case 6
                manager.GlobalPaletteMode = PaletteMode.Office2007Silver
            Case 7
                manager.GlobalPaletteMode = PaletteMode.Office2007SilverDarkMode
            Case 8
                manager.GlobalPaletteMode = PaletteMode.Office2007SilverLightMode
            Case 9
                manager.GlobalPaletteMode = PaletteMode.Office2007White
            Case 10
                manager.GlobalPaletteMode = PaletteMode.Office2007Black
            Case 11
                manager.GlobalPaletteMode = PaletteMode.Office2007BlackDarkMode
            Case 12
                manager.GlobalPaletteMode = PaletteMode.Office2010DarkGray
            Case 13
                manager.GlobalPaletteMode = PaletteMode.Office2010Blue
            Case 14
                manager.GlobalPaletteMode = PaletteMode.Office2010BlueDarkMode
            Case 15
                manager.GlobalPaletteMode = PaletteMode.Office2010BlueLightMode
            Case 16
                manager.GlobalPaletteMode = PaletteMode.Office2010Silver
            Case 17
                manager.GlobalPaletteMode = PaletteMode.Office2010SilverDarkMode
            Case 18
                manager.GlobalPaletteMode = PaletteMode.Office2010SilverLightMode
            Case 19
                manager.GlobalPaletteMode = PaletteMode.Office2010White
            Case 20
                manager.GlobalPaletteMode = PaletteMode.Office2010Black
            Case 21
                manager.GlobalPaletteMode = PaletteMode.Office2010BlackDarkMode
            Case 22
                manager.GlobalPaletteMode = PaletteMode.Office2013DarkGray
            Case 23
                manager.GlobalPaletteMode = PaletteMode.Office2013LightGray
            Case 24
                manager.GlobalPaletteMode = PaletteMode.Office2013White
        End Select
        txtSearch.Focus()
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / S A M P L E ... D A T A T A B L E (Products)
    ' / --------------------------------------------------------------------------------
    Function GetDataTable() As DataTable
        '// Add Column
        Dim DT As New DataTable
        With DT.Columns
            .Add("ProductPK", GetType(Integer)) '<< Index = 0
            .Add("ProductID", GetType(String))    '<< 1
            .Add("ProductName", GetType(String)) '<< 2
            .Add("UnitPrice", GetType(Double)) '<< 3
            '// ในส่วนของการรวมจำนวนเงิน (Total) จำนวน X ราคา เราจะไม่เก็บในฐานข้อมูลให้เปลืองพื้นที่ แต่จะให้โปรแกรมคำนวณให้แทน
        End With
        '// ... Add rows for data.
        '/ ProductPK, ProductID, ProductName, UnitPrice
        '/ เหมือนการ Query เพื่อนำเอาเฉพาะข้อมูลที่ต้องการมาใช้งานเท่านั้น
        With DT.Rows
            .Add(1, "01", "กาแฟร้อน", "100.00")
            .Add(2, "02", "กาแฟเย็น", "60.00")
            .Add(3, "03", "คาปูชิโน่", "75.00")
            .Add(4, "04", "คาปูชิโน่ - ลาเต้", "80.00")
            .Add(5, "05", "เอ็กซ์เพรสโซ่", "90.00")
            .Add(6, "06", "Classic Chicken", "20.00")
            .Add(7, "07", "Mexicana", "25.00")
            .Add(8, "08", "Lemon Shrimp", "30.00")
            .Add(9, "09", "Bacon", "40.00")
            .Add(10, "10", "Spicy Shrimp", "45.00")
            .Add(11, "11", "Tex Supreme", "50.00")
            .Add(12, "12", "Fish", "55.00")
            .Add(13, "13", "Pepsi Can", "20.00")
            .Add(14, "14", "Coke Can", "20.00")
            .Add(15, "15", "7Up Can", "20.00")
            .Add(16, "16", "Pepsi 2 ลิตร", "50.00")
            .Add(17, "17", "Coke 2 ลิตร", "50.00")
            .Add(18, "18", "น้ำเปล่า", "15.00")
            .Add(20, "19", "เบียร์สิงห์ (กระป๋อง)", "50.00")
            .Add(21, "20", "น้ำเย็น", "20.00")
            .Add(19, "21", "เหล้าขาว (เป็ก)", "100.00")
            .Add(22, "22", "เหล้าขาว (กลม)", "1,000.00")
        End With
        Return DT
    End Function

    ' / -------------------------------------------------------------------------------------
    ' / ตั้งค่าเริ่มต้นให้กับ Krypton DataGridView แบบ Run Time (ใช้โค้ดทั้งหมด)
    ' / -------------------------------------------------------------------------------------
    Private Sub InitializeGrid()
        With dgvData
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            '// Need to modify each cell.
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .ReadOnly = False
            '// Automatically set the width.
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '// Font for RowTemplate.
            .RowTemplate.DefaultCellStyle.Font = New Font("Tahoma", 11, FontStyle.Regular)
            .RowTemplate.MinimumHeight = 32
            '// Header.
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 11, FontStyle.Bold)
            '// Show alternating colors in even and odd rows.
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            '// Set ColumnHeadersHeightSizeMode before adjusting row heights.
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 36
            '// GridStyles
            '.GridStyles.Style = DataGridViewStyle.List
            .GridStyles.Style = DataGridViewStyle.Mixed
            '.GridStyles.Style = DataGridViewStyle.Sheet
            .BorderStyle = BorderStyle.Fixed3D

            '// Declare Krypton DataGridView columns type.
            Dim PK As New KryptonDataGridViewTextBoxColumn()
            Dim ProductID As New KryptonDataGridViewTextBoxColumn()
            Dim ProductName As New KryptonDataGridViewTextBoxColumn()
            Dim Quantity As New KryptonDataGridViewTextBoxColumn()
            Dim UnitPrice As New KryptonDataGridViewTextBoxColumn()
            Dim Total As New KryptonDataGridViewTextBoxColumn()
            '// Add new Columns.
            dgvData.Columns.AddRange(New DataGridViewColumn() {
                                     PK, ProductID, ProductName, Quantity, UnitPrice, Total
                                    })
            '/ Index = 0
            With PK
                .Name = "PK"
                .HeaderText = "PK"
                .Visible = False
            End With
            '/ Index = 1
            With ProductID
                .Name = "ProductID"
                .HeaderText = "รหัสสินค้า"
                .ReadOnly = True
            End With
            '/ Index = 2
            With ProductName
                .Name = "ProductName"
                .HeaderText = "ชื่อสินค้า"
                .ReadOnly = True
            End With
            '/ Index = 3
            With Quantity
                .Name = "Quantity"
                .HeaderText = "จำนวน"
                .DefaultCellStyle.Format = "0"
            End With
            '/ Index = 4
            With UnitPrice
                .Name = "UnitPrice"
                .HeaderText = "ราคาต่อหน่วย"
                .DefaultCellStyle.Format = "0.00"
            End With
            '/ Index = 5
            With Total
                .Name = "Total"
                .HeaderText = "รวมเงิน"
                .DefaultCellStyle.Format = "0.00"
                .ReadOnly = True
            End With
            '// เพิ่มปุ่มลบ (Index = 6)
            Dim btnDelRow As New KryptonDataGridViewButtonColumn()
            dgvData.Columns.Add(btnDelRow)
            With btnDelRow
                .HeaderText = "ลบ-F8"
                .Text = "ลบ"
                .UseColumnTextForButtonValue = True
                .Width = 80
                '.ButtonStyle = ButtonStyle.ButtonSpec
                .SortMode = DataGridViewColumnSortMode.NotSortable  '/ Not sort order but can click header for delete row.
                .HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            '/ Alignment MiddleRight only columns 3 to 5.
            For i As Byte = 3 To 5
                .Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight '/ Header Alignment
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight '/ Cell Alignment
            Next
        End With
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / การค้นหาข้อมูลในช่อง TextBox และค้นหาว่ามีข้อมูลรายการสินค้าอยู่ในแถวรายการตารางกริดหรือไม่
    ' / หากไม่มี ก็ให้เพิ่มแถวเข้าไปใหม่
    ' / หากมี ก็ให้เพิ่มจำนวนขึ้นไปอีก 1 Unit.
    ' / --------------------------------------------------------------------------------
    Private Sub txtSearch_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        '// เมื่อกดคีย์ ENTER เพื่อเริ่มต้นการค้นหาข้อมูล
        If e.KeyChar = Chr(13) Then
            '/ Replace some word for reserved in DataBase.
            txtSearch.Text = txtSearch.Text.Trim.Replace("'", "").Replace("*", "").Replace("%", "")
            e.Handled = True    '// ปิดเสียง
            '/ สร้าง DataTable สมมุติขึ้นมา (เหมือนกับการดึงข้อมูลจาก DataBase เข้ามาเพื่อทำการค้นหา)
            Dim DT As DataTable = GetDataTable()
            '/ ค้นหาข้อมูลจาก DataTable แล้วรับค่ามาใส่ไว้ใน DataRow
            '/ การค้นหาข้อมูลแบบ String จะต้องใส่เครื่องหมาย Single Quote ครอบเอาไว้ เช่น ProductID = '01'
            Dim r() As DataRow = DT.Select(" ProductID = " & "'" & txtSearch.Text.Trim & "'")
            '/ ตัวแปรบูลีน Flag แจ้งการค้นหาข้อมูลในตารางกริด (True = พบรายการในแถว, False = ไม่พบ)
            Dim blnExist As Boolean = False
            '// หากพบข้อมูลใน DataTable
            If r.Count > 0 Then
                '/ ต้องค้นหาข้อมูลจากตารางกริดก่อน เพื่อค้นหาว่ามีรายการสินค้าเดิมหรือไม่?
                '/ หากในตารางกริดยังไม่มีแถวรายการ ก็จะข้าม For Loop นี้ไปเพิ่มรายการใหม่ทันที
                For iRow As Integer = 0 To dgvData.RowCount - 1
                    '/ ทดสอบด้วย Primary Key r(0).Item(0) หรือ Product ID r(0).Item(1) ก็ได้
                    If r(0).Item(0) = dgvData.Rows(iRow).Cells(0).Value Then
                        '/ เมื่อพบรายการเดิม ก็ให้เพิ่มจำนวนขึ้น 1 
                        dgvData.Rows(iRow).Cells(3).Value += 1
                        '/ Flag แจ้งว่าพบข้อมูลเดิมแล้ว
                        blnExist = True
                        '/ เมื่อเจอสินค้าเดิมในตารางกริดแล้ว ไม่ว่าจะอยู่แถวลำดับที่เท่าไหร่ ก็ให้ออกจาก For Loop การค้นหาได้เลย
                        '/ เพราะรายการสินค้าใดๆ จะต้องมีอยู่เพียงแค่รายการเดียว ไม่ต้องเสียเวลาวนรอบกลับไปทำให้จนครบจำนวนแถว
                        Exit For
                    End If
                Next
                '/ กรณีที่พบสินค้าในตารางกริด กำหนด blnExist = True ทำให้ Not True = False จะทำให้ข้ามเงื่อนไขนี้ออกไป
                '/ กรณีที่ไม่พบข้อมูลสินค้าเดิมในตารางกริด กำหนด blnExist = False ทำให้ Not False = True เพิ่มรายการสินค้าแถวใหม่เข้าไปในตารางกริดได้
                If Not blnExist Then
                    '/ เขียนเอาไว้หน่อยจะได้ไม่ลืมว่าแต่ละหลักเราเก็บค่าอะไร
                    '/ Primary Key, Product ID, Product Name, Quantity, UnitPrice, Total
                    dgvData.Rows.Add(r(0).Item(0), r(0).Item(1), r(0).Item(2), "1", Format(CDbl(r(0).Item(3).ToString), "0.00"), "0.00")
                End If
                '/ หากไม่ใช้ NOT ก็จะต้องเขียนโปรแกรมแบบนี้ แต่โค้ดจะไม่สวยงาม
                '/ If blnExist = True Then
                '/     ไม่ต้องทำอะไร
                '/ Else
                '/     ทำคำสั่งเพิ่มรายการแถว
                '/ End If
                DT.Dispose()
                '// คำนวณผลรวมใหม่
                Call CalSumTotal()
            End If
            txtSearch.Clear()
            txtSearch.Focus()
        End If
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Calcualte sum of Total (Column Index = 5)
    ' / ทำทุกครั้งที่มีการเพิ่ม/ลบแถวรายการ หรือมีการเปลี่ยนแปลงค่าในเซลล์ Quantity, UnitPrice
    ' / เพื่อคำนวณหาจำนวนเงินใหม่
    ' / --------------------------------------------------------------------------------
    Private Sub CalSumTotal()
        txtTotal.Text = "0.00"
        '/ วนรอบตามจำนวนแถวที่มีอยู่ปัจจุบัน
        For i As Integer = 0 To dgvData.RowCount - 1
            '/ หลักสุดท้ายของตารางกริด = [จำนวน x ราคา]
            dgvData.Rows(i).Cells(5).Value = Format(dgvData.Rows(i).Cells(3).Value * dgvData.Rows(i).Cells(4).Value, "#,##0.00")
            '/ นำค่าจาก Total มารวมกันเพื่อแสดงผลในสรุปผลรวม (x = x + y)
            txtTotal.Text = Format(CDbl(txtTotal.Text) + CDbl(dgvData.Rows(i).Cells(5).Value), "#,##0.00")
        Next
        '// TAX - การคิดภาษี
        Dim SumPrice As Double = CDbl(txtTotal.Text)
        Select Case cmbTax.SelectedIndex
            '// ไม่คิดภาษี
            Case 0
                txtTotal.Text = Format(SumPrice, "#,##0.00")
                txtVat.Text = "0.00"
                '// รวมจำนวนเงินทั้งหมด
                txtNetTotal.Text = Format(CDbl(txtTotal.Text), "#,##0.00")
                '// หรือ txtNetTotal.Text = Format(SumPrice, "#,##0.00")

                '// รวมภาษี (Include Tax)
            Case 1
                '// คิดภาษี 7%
                txtVat.Text = Format(SumPrice - (SumPrice / 1.07), "#,##0.00")
                '// หาราคาสินค้าที่แท้จริงก่อน ... โดยเอาราคาสินค้าทั้งหมดลบออกจากภาษี
                txtTotal.Text = Format(SumPrice - CDbl(txtVat.Text), "#,##0.00")
                '// รวมจำนวนเงินทั้งหมด
                txtNetTotal.Text = Format(SumPrice, "#,##0.00")

                '// แยกภาษี (Exclude Tax)
            Case 2
                txtTotal.Text = Format(SumPrice, "#,##0.00")
                '// คิดแยกภาษี 7%
                txtVat.Text = Format(CDbl(txtTotal.Text) * 7 / 100, "#,##0.00")
                '// รวมจำนวนเงินทั้งหมด + ภาษี
                txtNetTotal.Text = Format(CDbl(txtTotal.Text) + CDbl(txtVat.Text), "#,##0.00")
        End Select
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / โปรแกรมย่อยในการลบแถวรายการที่เลือกออกไป
    ' / --------------------------------------------------------------------------------
    Private Sub DeleteRow(ByVal ColName As String)
        If dgvData.RowCount = 0 Then Return
        '/ ColName เป็นชื่อของหลัก Index = 6 ของตารางกริด (ไปดูที่โปรแกรมย่อย InitializeGrid)
        If ColName = "btnDelRow" Then
            '// ลบรายการแถวที่เลือกออกไป
            dgvData.Rows.Remove(dgvData.CurrentRow)
            '/ เมื่อแถวรายการถูกลบออกไป ต้องไปคำนวณหาค่าผลรวมใหม่
            Call CalSumTotal()
        End If
        txtSearch.Focus()
    End Sub

    Private Sub dgvData_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellClick
        Select Case e.ColumnIndex
            '// Delete Button
            Case 6
                'MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString)
                Call DeleteRow("btnDelRow")
        End Select
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / เหตุการณ์นี้จะเกิดขึ้นเมื่อแก้ไขรายการในเซลล์เรียบร้อยแล้วกด Enter
    ' / --------------------------------------------------------------------------------
    Private Sub dgvData_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellEndEdit
        '/ เกิดการเปลี่ยนแปลงค่าในหลัก Index ที่ 3 หรือ 4
        '/ ให้คำนวณราคารวมใหม่ จำนวน X ราคา
        Select Case e.ColumnIndex
            '/ Column Index = 3 (Quantity), Column Index = 4 (UnitPrice)
            Case 3, 4
                '/ Quantity
                '/ การดัก Error กรณีไม่มีค่าอะไรในเซลล์ ให้ใส่ค่า 0 ลงไปแทน (จริงๆกรณีจำนวนสินค้าต้องกำหนดขั้นต่ำไว้ที่ 1)
                If dgvData.Rows(e.RowIndex).Cells(3).Value Is Nothing OrElse dgvData.Rows(e.RowIndex).Cells(3).Value.ToString() = "" Then dgvData.Rows(e.RowIndex).Cells(3).Value = "0"
                Dim Quantity As Integer = dgvData.Rows(e.RowIndex).Cells(3).Value
                '/ UnitPrice
                If dgvData.Rows(e.RowIndex).Cells(4).Value Is Nothing OrElse dgvData.Rows(e.RowIndex).Cells(4).Value.ToString() = "" Then dgvData.Rows(e.RowIndex).Cells(4).Value = "0.00"
                Dim UnitPrice As Double = dgvData.Rows(e.RowIndex).Cells(4).Value
                dgvData.Rows(e.RowIndex).Cells(4).Value = Format(CDbl(dgvData.Rows(e.RowIndex).Cells(4).Value), "0.00")

                '/ Quantity x UnitPrice
                dgvData.Rows(e.RowIndex).Cells(5).Value = CDbl((Quantity * UnitPrice).ToString("#,##0.00"))
                '/ Calculate Summary
                Call CalSumTotal()
        End Select
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / เมื่อเริ่มกดคีย์ในหลักที่ 3 และ 4 (Quantity-Integer, UnitPrice-Double)
    ' / --------------------------------------------------------------------------------
    Private Sub dgvData_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvData.EditingControlShowing
        '// Or use the index columns of DataGridView.
        'Select Case dgvData.Columns(dgvData.CurrentCell.ColumnIndex).Index
        '    Case 1
        '
        'End Select

        '// Don't forget to specify the Column Name earlier as well (InitializeGrid sub program).
        Select Case dgvData.Columns(dgvData.CurrentCell.ColumnIndex).Name
        '// อย่าลืมกำหนดชื่อ Column Name มาก่อนหน้านี้ด้วย (โปรแกรมย่อย InitializeGrid)
            Case "Quantity", "UnitPrice"
                If TypeOf e.Control Is Krypton.Toolkit.KryptonDataGridViewTextBoxEditingControl Then
                    Dim editingControl As Krypton.Toolkit.KryptonDataGridViewTextBoxEditingControl = TryCast(e.Control, Krypton.Toolkit.KryptonDataGridViewTextBoxEditingControl)
                    '// Event Handler for intercepts keystrokes.
                    AddHandler editingControl.KeyPress, AddressOf KryptonDataGridViewKeyPress
                End If
        End Select
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / ดักค่าการกดคีย์เฉพาะตัวเลขในเซลล์เท่านั้น
    ' / --------------------------------------------------------------------------------
    Private Sub KryptonDataGridViewKeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case dgvData.CurrentCell.ColumnIndex
            Case 3   '// Quantity is Integer (กรณีเลขจำนวนเต็ม)
                '// Allow numeric digits (0-9) in the TextBox.
                If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True

            Case 4  '// UnitPrice is Double (กรณีเลขจำนวนทศนิยม)
                '// Allow numeric digits (0-9) and the decimal point (.) only one in the TextBox.
                If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then e.Handled = True
                '// Check for an existing decimal point in the cell.
                Dim tb As KryptonDataGridViewTextBoxEditingControl = DirectCast(sender, KryptonDataGridViewTextBoxEditingControl)
                If e.KeyChar = "." AndAlso tb.Text.Contains(".") Then e.Handled = True
        End Select
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / เลือกการคำนวณภาษี
    ' / --------------------------------------------------------------------------------
    Private Sub cmbTax_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTax.SelectedIndexChanged
        Call CalSumTotal()
        txtSearch.Focus()
    End Sub

    Private Sub frmPosDetail_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
