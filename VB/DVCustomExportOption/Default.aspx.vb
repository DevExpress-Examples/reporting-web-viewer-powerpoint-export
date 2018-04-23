Imports DevExpress.Office.Utils
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.Services
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace DVCustomExportOption
	Partial Public Class [Default]
		Inherits System.Web.UI.Page

		Private report As XtraReport1
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			report = New XtraReport1()
			webDocumentViewer.OpenReport(report)
		End Sub

		Public Sub ExportToPowerPoint()
			' To the desktop (for demo purposes)
			Dim desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
			' image export options
			Dim exportOptions As ImageExportOptions = New ImageExportOptions With {.ExportMode = ImageExportMode.SingleFilePageByPage, .Format = ImageFormat.Png, .PageBorderColor = Color.White, .Resolution = 600}
			' PowerPoint Presentation
			Dim size As Size = CalculateSize()
			Dim p As New Presentation(size)
			' go through each page
			For i As Integer = 0 To report.Pages.Count - 1
				' export image
				Dim file = String.Format("{0}\{1}.png", desktop, i)
				exportOptions.PageRange = (i + 1).ToString()
				report.ExportToImage(file, exportOptions)
				' add the image to the presentation
				p.AddPage(file)
				' clean up!
				System.IO.File.Delete(file)
			Next i
			' save presentation to desktop
			p.SaveAs(String.Format("{0}\Product.ppt", desktop))
			Dim strRequest As String = String.Format("{0}\Product.ppt", desktop)
			If Not String.IsNullOrEmpty(strRequest) Then
				Dim file As New System.IO.FileInfo(strRequest)
				If file.Exists Then
					Response.Clear()
					Response.AddHeader("Content-Disposition", "attachment; filename=" & file.Name)
					Response.AddHeader("Content-Length", file.Length.ToString())
					Response.ContentType = "application/octet-stream"
					Response.WriteFile(file.FullName)
					Response.End()
				Else
					Response.Write("This file does not exist.")
				End If
			Else
				Response.Write("Please provide a file to download.")
			End If
		End Sub

		Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			ExportToPowerPoint()
		End Sub

		Private Function CalculateSize() As Size
			Dim size As Size
			If report.ReportUnit = ReportUnit.HundredthsOfAnInch Then
				size = New Size(CInt(Math.Truncate(Units.InchesToPointsF(report.PageSize.Width \ 100))), CInt(Math.Truncate(Units.InchesToPointsF(report.PageSize.Height \ 100))))
			ElseIf report.ReportUnit = ReportUnit.TenthsOfAMillimeter Then
				size = New Size(CInt(Units.MillimetersToPoints(report.PageSize.Width \ 10)), CInt(Units.MillimetersToPoints(report.PageSize.Height \ 10)))
			Else
				size = New Size(CInt(Units.PixelsToPoints(report.PageSize.Width, 96)), CInt(Units.PixelsToPoints(report.PageSize.Height, 96)))
			End If
			Return size
		End Function
	End Class
End Namespace