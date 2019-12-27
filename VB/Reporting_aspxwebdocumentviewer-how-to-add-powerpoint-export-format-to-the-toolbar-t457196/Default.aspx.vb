Imports System
Imports System.Collections.Generic

Namespace DVCustomExportOption
    Partial Public Class [Default]
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As New XtraReport1()
            Dim persons As New List(Of Person)()
            persons.Add(New Person() With { _
                .PersonFirstName = "Max", _
                .PersonLastName = "Fowler", _
                .PersonAge = 30 _
            })
            persons.Add(New Person() With { _
                .PersonFirstName = "Nancy", _
                .PersonLastName = "Drewmore", _
                .PersonAge = 29 _
            })
            persons.Add(New Person() With { _
                .PersonFirstName = "Pak", _
                .PersonLastName = "Jang", _
                .PersonAge = 31 _
            })
            report.DataSource = persons
            report.CreateDocument()
            webDocumentViewer.OpenReport(report)
        End Sub
    End Class
End Namespace
