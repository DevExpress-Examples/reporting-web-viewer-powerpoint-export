Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Collections.Generic
Imports DevExpress.XtraPrinting
Imports System.Drawing.Imaging
Imports System.IO

Namespace DVCustomExportOption
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
			InitializeComponent()
			Dim persons As New List(Of Person)()
			persons.Add(New Person() With {.PersonFirstName = "Max", .PersonLastName = "Fowler", .PersonAge = 30})
			persons.Add(New Person() With {.PersonFirstName = "Nancy", .PersonLastName = "Drewmore", .PersonAge = 29})
			persons.Add(New Person() With {.PersonFirstName = "Pak", .PersonLastName = "Jang", .PersonAge = 31})

			Me.DataSource = persons
			Me.CreateDocument()
		End Sub
	End Class

	Public Class Person
		Public Property PersonFirstName() As String
		Public Property PersonLastName() As String
		Public Property PersonAge() As Integer
	End Class
End Namespace
