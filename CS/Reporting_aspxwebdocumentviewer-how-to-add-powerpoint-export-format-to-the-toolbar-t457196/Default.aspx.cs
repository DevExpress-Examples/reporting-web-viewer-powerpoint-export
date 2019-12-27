using System;
using System.Collections.Generic;

namespace DVCustomExportOption {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { PersonFirstName = "Max", PersonLastName = "Fowler", PersonAge = 30 });
            persons.Add(new Person() { PersonFirstName = "Nancy", PersonLastName = "Drewmore", PersonAge = 29 });
            persons.Add(new Person() { PersonFirstName = "Pak", PersonLastName = "Jang", PersonAge = 31 });
            report.DataSource = persons;
            report.CreateDocument();
            webDocumentViewer.OpenReport(report);
        }
    }
}
