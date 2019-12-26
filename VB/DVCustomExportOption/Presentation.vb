Imports System
Imports System.IO
Imports System.Drawing

Namespace DVCustomExportOption
	' https://community.devexpress.com/blogs/seth/archive/2011/02/14/exporting-reports-to-powerpoint.aspx
	Public Class Presentation
		Private _powerPoint As Microsoft.Office.Interop.PowerPoint.Application
		Private _presentation As Microsoft.Office.Interop.PowerPoint.Presentation

		Protected Overrides Sub Finalize()
			_powerPoint = Nothing
			_presentation = Nothing
			 GC.Collect()
			 GC.WaitForPendingFinalizers()
		End Sub

		Public Sub New(ByVal paperSize As Size)
			_powerPoint = New Microsoft.Office.Interop.PowerPoint.Application()
			_presentation = _powerPoint.Presentations.Add(Microsoft.Office.Core.MsoTriState.msoFalse)
			_presentation.PageSetup.SlideHeight = paperSize.Height
			_presentation.PageSetup.SlideWidth = paperSize.Width
		End Sub

		Private _slideNo As Integer = 0
		Public Sub AddPage(ByVal fileName As String)
			_slideNo += 1
			Dim slide = _presentation.Slides.Add(_slideNo, Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutBlank)
			slide.Shapes.AddPicture(fileName, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, 0, 0)
		End Sub

		Public Sub SaveAs(ByVal filename As String)
			If File.Exists(filename) Then
			File.Delete(filename)
			End If
			_presentation.SaveAs(filename)
			_presentation.Close()
			_powerPoint.Quit()
		End Sub
	End Class
End Namespace