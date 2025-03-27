Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for TestReport
''' </summary>
Public Class TestReport
    Inherits XtraReport

    Private TopMargin As TopMarginBand

    Private ReportHeader As ReportHeaderBand

    Private label1 As XRLabel

    Private GroupHeader1 As GroupHeaderBand

    Private table1 As XRTable

    Private tableRow1 As XRTableRow

    Private tableCell1 As XRTableCell

    Private tableCell2 As XRTableCell

    Private tableCell3 As XRTableCell

    Private Detail As DetailBand

    Private table2 As XRTable

    Private tableRow2 As XRTableRow

    Private tableCell4 As XRTableCell

    Private tableCell5 As XRTableCell

    Private tableCell6 As XRTableCell

    Private pictureBox1 As XRPictureBox

    Private BottomMargin As BottomMarginBand

    Private pageInfo1 As XRPageInfo

    Private pageInfo2 As XRPageInfo

    Private Title As XRControlStyle

    Private DetailCaption1 As XRControlStyle

    Private DetailData1 As XRControlStyle

    Private DetailData3_Odd As XRControlStyle

    Private PageInfo As XRControlStyle

    Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()
    '
    ' TODO: Add constructor logic here
    '
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestReport))
        TopMargin = New TopMarginBand()
        ReportHeader = New ReportHeaderBand()
        label1 = New XRLabel()
        GroupHeader1 = New GroupHeaderBand()
        table1 = New XRTable()
        tableRow1 = New XRTableRow()
        tableCell1 = New XRTableCell()
        tableCell2 = New XRTableCell()
        tableCell3 = New XRTableCell()
        Detail = New DetailBand()
        table2 = New XRTable()
        tableRow2 = New XRTableRow()
        tableCell4 = New XRTableCell()
        tableCell5 = New XRTableCell()
        tableCell6 = New XRTableCell()
        pictureBox1 = New XRPictureBox()
        BottomMargin = New BottomMarginBand()
        pageInfo1 = New XRPageInfo()
        pageInfo2 = New XRPageInfo()
        Title = New XRControlStyle()
        DetailCaption1 = New XRControlStyle()
        DetailData1 = New XRControlStyle()
        DetailData3_Odd = New XRControlStyle()
        PageInfo = New XRControlStyle()
        sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(components)
        CType(table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' TopMargin
        ' 
        TopMargin.Name = "TopMargin"
        ' 
        ' ReportHeader
        ' 
        ReportHeader.Controls.AddRange(New XRControl() {label1})
        ReportHeader.HeightF = 60F
        ReportHeader.Name = "ReportHeader"
        ' 
        ' label1
        ' 
        label1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
        label1.Name = "label1"
        label1.SizeF = New System.Drawing.SizeF(638F, 24.19433F)
        label1.StyleName = "Title"
        label1.Text = "NWind Categories"
        ' 
        ' GroupHeader1
        ' 
        GroupHeader1.Controls.AddRange(New XRControl() {table1})
        GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail
        GroupHeader1.HeightF = 28F
        GroupHeader1.Name = "GroupHeader1"
        ' 
        ' table1
        ' 
        table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
        table1.Name = "table1"
        table1.Rows.AddRange(New XRTableRow() {tableRow1})
        table1.SizeF = New System.Drawing.SizeF(650F, 28F)
        ' 
        ' tableRow1
        ' 
        tableRow1.Cells.AddRange(New XRTableCell() {tableCell1, tableCell2, tableCell3})
        tableRow1.Name = "tableRow1"
        tableRow1.Weight = 1R
        ' 
        ' tableCell1
        ' 
        tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
        tableCell1.Name = "tableCell1"
        tableCell1.StyleName = "DetailCaption1"
        tableCell1.StylePriority.UseBorders = False
        tableCell1.StylePriority.UseTextAlignment = False
        tableCell1.Text = "Category ID"
        tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        tableCell1.Weight = 0.34163161057692309R
        ' 
        ' tableCell2
        ' 
        tableCell2.Name = "tableCell2"
        tableCell2.StyleName = "DetailCaption1"
        tableCell2.Text = "Category Name"
        tableCell2.Weight = 0.427702871469351R
        ' 
        ' tableCell3
        ' 
        tableCell3.Name = "tableCell3"
        tableCell3.StyleName = "DetailCaption1"
        tableCell3.Text = "Picture"
        tableCell3.Weight = 0.23066551795372597R
        ' 
        ' Detail
        ' 
        Detail.Controls.AddRange(New XRControl() {table2})
        Detail.HeightF = 25F
        Detail.Name = "Detail"
        ' 
        ' table2
        ' 
        table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
        table2.Name = "table2"
        table2.OddStyleName = "DetailData3_Odd"
        table2.Rows.AddRange(New XRTableRow() {tableRow2})
        table2.SizeF = New System.Drawing.SizeF(650F, 25F)
        ' 
        ' tableRow2
        ' 
        tableRow2.Cells.AddRange(New XRTableCell() {tableCell4, tableCell5, tableCell6})
        tableRow2.Name = "tableRow2"
        tableRow2.Weight = 11.5R
        ' 
        ' tableCell4
        ' 
        tableCell4.Borders = DevExpress.XtraPrinting.BorderSide.None
        tableCell4.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[CategoryID]")})
        tableCell4.Name = "tableCell4"
        tableCell4.Scripts.OnBeforePrint = "tableCell4_BeforePrint"
        tableCell4.StyleName = "DetailData1"
        tableCell4.StylePriority.UseBorders = False
        tableCell4.StylePriority.UseTextAlignment = False
        tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        tableCell4.Weight = 0.34163161057692309R
        AddHandler tableCell4.BeforePrint, New BeforePrintEventHandler(AddressOf tableCell4_BeforePrint)
        ' 
        ' tableCell5
        ' 
        tableCell5.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
        tableCell5.Name = "tableCell5"
        tableCell5.StyleName = "DetailData1"
        tableCell5.Weight = 0.427702871469351R
        ' 
        ' tableCell6
        ' 
        tableCell6.Controls.AddRange(New XRControl() {pictureBox1})
        tableCell6.Name = "tableCell6"
        tableCell6.StyleName = "DetailData1"
        tableCell6.Weight = 0.23066551795372597R
        ' 
        ' pictureBox1
        ' 
        pictureBox1.AnchorHorizontal = CType(HorizontalAnchorStyles.Left Or HorizontalAnchorStyles.Right, HorizontalAnchorStyles)
        pictureBox1.AnchorVertical = CType(VerticalAnchorStyles.Top Or VerticalAnchorStyles.Bottom, VerticalAnchorStyles)
        pictureBox1.ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "ImageSource", "[Picture]")})
        pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(2.083333F, 0F)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.SizeF = New System.Drawing.SizeF(147.8493F, 25F)
        pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        ' 
        ' BottomMargin
        ' 
        BottomMargin.Controls.AddRange(New XRControl() {pageInfo1, pageInfo2})
        BottomMargin.Name = "BottomMargin"
        ' 
        ' pageInfo1
        ' 
        pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
        pageInfo1.Name = "pageInfo1"
        pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        pageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
        pageInfo1.StyleName = "PageInfo"
        ' 
        ' pageInfo2
        ' 
        pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
        pageInfo2.Name = "pageInfo2"
        pageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
        pageInfo2.StyleName = "PageInfo"
        pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        pageInfo2.TextFormatString = "Page {0} of {1}"
        ' 
        ' Title
        ' 
        Title.BackColor = System.Drawing.Color.Transparent
        Title.BorderColor = System.Drawing.Color.Black
        Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Title.BorderWidth = 1F
        Title.Font = New System.Drawing.Font("Arial", 14.25F)
        Title.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte(75))))), (CInt(((CByte(75))))), (CInt(((CByte(75))))))
        Title.Name = "Title"
        ' 
        ' DetailCaption1
        ' 
        DetailCaption1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte(75))))), (CInt(((CByte(75))))), (CInt(((CByte(75))))))
        DetailCaption1.BorderColor = System.Drawing.Color.White
        DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        DetailCaption1.BorderWidth = 2F
        DetailCaption1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
        DetailCaption1.ForeColor = System.Drawing.Color.White
        DetailCaption1.Name = "DetailCaption1"
        DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
        DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        ' 
        ' DetailData1
        ' 
        DetailData1.BorderColor = System.Drawing.Color.Transparent
        DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        DetailData1.BorderWidth = 2F
        DetailData1.Font = New System.Drawing.Font("Arial", 8.25F)
        DetailData1.ForeColor = System.Drawing.Color.Black
        DetailData1.Name = "DetailData1"
        DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
        DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        ' 
        ' DetailData3_Odd
        ' 
        DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte(231))))), (CInt(((CByte(231))))), (CInt(((CByte(231))))))
        DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
        DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
        DetailData3_Odd.BorderWidth = 1F
        DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25F)
        DetailData3_Odd.ForeColor = System.Drawing.Color.Black
        DetailData3_Odd.Name = "DetailData3_Odd"
        DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
        DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        ' 
        ' PageInfo
        ' 
        PageInfo.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
        PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte(75))))), (CInt(((CByte(75))))), (CInt(((CByte(75))))))
        PageInfo.Name = "PageInfo"
        PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        ' 
        ' sqlDataSource1
        ' 
        sqlDataSource1.ConnectionName = "NWindConnectionString"
        sqlDataSource1.Name = "sqlDataSource1"
        columnExpression1.ColumnName = "CategoryID"
        table3.Name = "Categories"
        columnExpression1.Table = table3
        column1.Expression = columnExpression1
        columnExpression2.ColumnName = "CategoryName"
        columnExpression2.Table = table3
        column2.Expression = columnExpression2
        columnExpression3.ColumnName = "Description"
        columnExpression3.Table = table3
        column3.Expression = columnExpression3
        columnExpression4.ColumnName = "Picture"
        columnExpression4.Table = table3
        column4.Expression = columnExpression4
        selectQuery1.Columns.Add(column1)
        selectQuery1.Columns.Add(column2)
        selectQuery1.Columns.Add(column3)
        selectQuery1.Columns.Add(column4)
        selectQuery1.Name = "Categories"
        selectQuery1.Tables.Add(table3)
        sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
        sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IkNhdGVnb3JpZXMiPjxGaWVsZCBOYW1lPSJDYXRlZ29yeUlEIiBUeXBlPSJJbnQzMiIgLz48RmllbGQgTmFtZT0iQ2F0ZWdvcnlOYW1lIiBUeXBlPSJTdHJpbmciIC8+PEZpZWxkIE5hbWU9IkRlc2NyaXB0aW9uIiBUeXBlPSJTdHJpbmciIC8+PEZpZWxkIE5hbWU9IlBpY3R1cmUiIFR5cGU9IkJ5dGVBcnJheSIgLz48L1ZpZXc+PC9EYXRhU2V0Pg=="
        ' 
        ' TestReport
        ' 
        Bands.AddRange(New Band() {TopMargin, ReportHeader, GroupHeader1, Detail, BottomMargin})
        ComponentStorage.AddRange(New System.ComponentModel.IComponent() {sqlDataSource1})
        DataMember = "Categories"
        DataSource = sqlDataSource1
        Extensions.Add("DataSerializationExtension", "DevExpress.XtraReports.Web.ReportDesigner.DefaultDataSerializer")
        StyleSheet.AddRange(New XRControlStyle() {Title, DetailCaption1, DetailData1, DetailData3_Odd, PageInfo})
        StyleSheetPath = ""
        Version = "19.2"
        CType(table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub

    Private Sub tableCell4_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TryCast(sender, XRTableCell).Text += " Customized"
    End Sub
End Class
