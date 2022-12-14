Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for TestReport
''' </summary>
Public Class TestReport
	Inherits DevExpress.XtraReports.UI.XtraReport

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
	Private WithEvents tableCell4 As XRTableCell
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
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TestReport))
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.table1 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.table2 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.pictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			DirectCast(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label1})
			Me.ReportHeader.HeightF = 60F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' label1
			' 
			Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
			Me.label1.Name = "label1"
			Me.label1.SizeF = New System.Drawing.SizeF(638F, 24.19433F)
			Me.label1.StyleName = "Title"
			Me.label1.Text = "NWind Categories"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table1})
			Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader1.HeightF = 28F
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' table1
			' 
			Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.table1.Name = "table1"
			Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow1})
			Me.table1.SizeF = New System.Drawing.SizeF(650F, 28F)
			' 
			' tableRow1
			' 
			Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell1, Me.tableCell2, Me.tableCell3})
			Me.tableRow1.Name = "tableRow1"
			Me.tableRow1.Weight = 1R
			' 
			' tableCell1
			' 
			Me.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.tableCell1.Name = "tableCell1"
			Me.tableCell1.StyleName = "DetailCaption1"
			Me.tableCell1.StylePriority.UseBorders = False
			Me.tableCell1.StylePriority.UseTextAlignment = False
			Me.tableCell1.Text = "Category ID"
			Me.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tableCell1.Weight = 0.34163161057692309R
			' 
			' tableCell2
			' 
			Me.tableCell2.Name = "tableCell2"
			Me.tableCell2.StyleName = "DetailCaption1"
			Me.tableCell2.Text = "Category Name"
			Me.tableCell2.Weight = 0.427702871469351R
			' 
			' tableCell3
			' 
			Me.tableCell3.Name = "tableCell3"
			Me.tableCell3.StyleName = "DetailCaption1"
			Me.tableCell3.Text = "Picture"
			Me.tableCell3.Weight = 0.23066551795372597R
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table2})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			' 
			' table2
			' 
			Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.table2.Name = "table2"
			Me.table2.OddStyleName = "DetailData3_Odd"
			Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow2})
			Me.table2.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' tableRow2
			' 
			Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell4, Me.tableCell5, Me.tableCell6})
			Me.tableRow2.Name = "tableRow2"
			Me.tableRow2.Weight = 11.5R
			' 
			' tableCell4
			' 
			Me.tableCell4.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryID]")})
			Me.tableCell4.Name = "tableCell4"
			Me.tableCell4.Scripts.OnBeforePrint = "tableCell4_BeforePrint"
			Me.tableCell4.StyleName = "DetailData1"
			Me.tableCell4.StylePriority.UseBorders = False
			Me.tableCell4.StylePriority.UseTextAlignment = False
			Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tableCell4.Weight = 0.34163161057692309R
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.tableCell4.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.tableCell4_BeforePrint);
			' 
			' tableCell5
			' 
			Me.tableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
			Me.tableCell5.Name = "tableCell5"
			Me.tableCell5.StyleName = "DetailData1"
			Me.tableCell5.Weight = 0.427702871469351R
			' 
			' tableCell6
			' 
			Me.tableCell6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.pictureBox1})
			Me.tableCell6.Name = "tableCell6"
			Me.tableCell6.StyleName = "DetailData1"
			Me.tableCell6.Weight = 0.23066551795372597R
			' 
			' pictureBox1
			' 
			Me.pictureBox1.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
			Me.pictureBox1.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
			Me.pictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Picture]")})
			Me.pictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(2.083333F, 0F)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.SizeF = New System.Drawing.SizeF(147.8493F, 25F)
			Me.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.pageInfo1, Me.pageInfo2})
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' pageInfo1
			' 
			Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
			Me.pageInfo1.Name = "pageInfo1"
			Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.pageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
			Me.pageInfo1.StyleName = "PageInfo"
			' 
			' pageInfo2
			' 
			Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
			Me.pageInfo2.Name = "pageInfo2"
			Me.pageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
			Me.pageInfo2.StyleName = "PageInfo"
			Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.pageInfo2.TextFormatString = "Page {0} of {1}"
			' 
			' Title
			' 
			Me.Title.BackColor = System.Drawing.Color.Transparent
			Me.Title.BorderColor = System.Drawing.Color.Black
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.Title.BorderWidth = 1F
			Me.Title.Font = New System.Drawing.Font("Arial", 14.25F)
			Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.Title.Name = "Title"
			' 
			' DetailCaption1
			' 
			Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.DetailCaption1.BorderColor = System.Drawing.Color.White
			Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailCaption1.BorderWidth = 2F
			Me.DetailCaption1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.DetailCaption1.ForeColor = System.Drawing.Color.White
			Me.DetailCaption1.Name = "DetailCaption1"
			Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData1
			' 
			Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailData1.BorderWidth = 2F
			Me.DetailData1.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData1.ForeColor = System.Drawing.Color.Black
			Me.DetailData1.Name = "DetailData1"
			Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData3_Odd
			' 
			Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(231)))), (CInt((CByte(231)))))
			Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DetailData3_Odd.BorderWidth = 1F
			Me.DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
			Me.DetailData3_Odd.Name = "DetailData3_Odd"
			Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' PageInfo
			' 
			Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.PageInfo.Name = "PageInfo"
			Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "NWindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
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
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IkNhdGVnb3JpZXMiPjxGaWVsZCBOYW1lPSJDYXRlZ29yeUlEIiBUeXBlPSJJbnQzMiIgLz48RmllbGQgTmFtZT0iQ2F0ZWdvcnlOYW1lIiBUeXBlPSJTdHJpbmciIC8+PEZpZWxkIE5hbWU9IkRlc2NyaXB0aW9uIiBUeXBlPSJTdHJpbmciIC8+PEZpZWxkIE5hbWU9IlBpY3R1cmUiIFR5cGU9IkJ5dGVBcnJheSIgLz48L1ZpZXc+PC9EYXRhU2V0Pg=="
			' 
			' TestReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.ReportHeader, Me.GroupHeader1, Me.Detail, Me.BottomMargin})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Categories"
			Me.DataSource = Me.sqlDataSource1
			Me.Extensions.Add("DataSerializationExtension", "DevExpress.XtraReports.Web.ReportDesigner.DefaultDataSerializer")
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.DetailCaption1, Me.DetailData1, Me.DetailData3_Odd, Me.PageInfo})
			Me.StyleSheetPath = ""
			Me.Version = "19.2"
			DirectCast(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub tableCell4_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tableCell4.BeforePrint
		TryCast(sender, XRTableCell).Text &= " Customized"
	End Sub

End Class
