using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;

namespace ComplexDialogSample.Module.BusinessObjects {

    [NavigationItem("Resources")]
    [DefaultProperty(nameof(Description))]
    public class Service : BaseObject {
        public Service(Session session) : base(session) { }
        public string Description {
            get { return GetPropertyValue<string>(nameof(Description)); }
            set { SetPropertyValue<string>(nameof(Description), value); }
        }
    }
}
