using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using DevExpress.XtraPrinting;
using System.Drawing.Imaging;
using System.IO;

namespace DVCustomExportOption {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
            InitializeComponent();
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { PersonFirstName = "Max", PersonLastName = "Fowler", PersonAge = 30 });
            persons.Add(new Person() { PersonFirstName = "Nancy", PersonLastName = "Drewmore", PersonAge = 29 });
            persons.Add(new Person() { PersonFirstName = "Pak", PersonLastName = "Jang", PersonAge = 31 });

            this.DataSource = persons;
            this.CreateDocument();
        }
    }

    public class Person {
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public int PersonAge { get; set; }
    }
}
