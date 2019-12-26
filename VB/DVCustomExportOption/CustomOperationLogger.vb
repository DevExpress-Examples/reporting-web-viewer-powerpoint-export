Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.Web.ClientControls
Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Namespace DVCustomExportOption
	Public Class CustomOperationLogger
		Inherits WebDocumentViewerOperationLogger

		Public Overrides Function ExportDocumentStarting(ByVal documentId As String, ByVal asyncExportOperationId As String, ByVal format As String, ByVal options As ExportOptions, ByVal printingSystem As PrintingSystemBase, ByVal doExportSynchronously As Func(Of ExportedDocument)) As ExportedDocument
			If format = "powerPoint" Then
				Return New ExportedDocument(ExportToPowerPoint(printingSystem, documentId), "application/vnd.ms-powerpoint", printingSystem.Document.Name & ".ppt")
			End If
			Return MyBase.ExportDocumentStarting(documentId, asyncExportOperationId, format, options, printingSystem, doExportSynchronously)
		End Function
		Private Function ExportToPowerPoint(ByVal printingSystem As PrintingSystemBase, ByVal documentId As String) As Byte()
			' To the temp folder (for demo purposes)  
			Dim tempFolder = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/PowerPoint/")
			If Not Directory.Exists(tempFolder) Then
				Directory.CreateDirectory(tempFolder)
			End If
			' image export options  
			Dim exportOptions As ImageExportOptions = New ImageExportOptions With {
				.ExportMode = ImageExportMode.SingleFilePageByPage,
				.Format = ImageFormat.Png,
				.PageBorderColor = Color.White,
				.Resolution = 600
			}
			' PowerPoint Presentation  
			Dim size As Size = CalculateSize(printingSystem)
			Dim p As New Presentation(size)
			' go through each page  
			For i As Integer = 0 To printingSystem.Pages.Count - 1
				' export image  
				Dim file = String.Format("{0}\{1}_{2}.png", tempFolder, documentId, i)
				exportOptions.PageRange = (i + 1).ToString()
				printingSystem.ExportToImage(file, exportOptions)
				' add the image to the presentation  
				p.AddPage(file)
				' clean up!  
				System.IO.File.Delete(file)
			Next i
			' save presentation  
			Dim resultFile As String = String.Format("{0}\{1}.ppt", tempFolder, documentId)
			p.SaveAs(resultFile)
			Dim document() As Byte = File.ReadAllBytes(resultFile)
			File.Delete(resultFile)
			Return document
		End Function
		Private Function CalculateSize(ByVal printingSystem As PrintingSystemBase) As Size
			Dim size As SizeF = printingSystem.Pages(0).PageSize.ToSize()
			Return GraphicsUnitConverter.Convert(size, GraphicsUnit.Document.ToDpi(), GraphicsUnit.Point.ToDpi()).ToSize()
		End Function
	End Class
End Namespace