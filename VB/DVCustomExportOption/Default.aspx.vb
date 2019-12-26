Imports System
Imports System.Collections.Generic

Namespace DVCustomExportOption
	Partial Public Class [Default]
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim report As New XtraReport1()
			Dim persons As New List(Of Person)()
			persons.Add(New Person() With {
				.PersonFirstName = "Max",
				.PersonLastName = "Fowler",
				.PersonAge = 30
			})
			persons.Add(New Person() With {
				.PersonFirstName = "Nancy",
				.PersonLastName = "Drewmore",
				.PersonAge = 29
			})
			persons.Add(New Person() With {
				.PersonFirstName = "Pak",
				.PersonLastName = "Jang",
				.PersonAge = 31
			})
			report.DataSource = persons
            webDocumentViewer.OpenReport(report)
        End Sub
	End Class
End Namespace