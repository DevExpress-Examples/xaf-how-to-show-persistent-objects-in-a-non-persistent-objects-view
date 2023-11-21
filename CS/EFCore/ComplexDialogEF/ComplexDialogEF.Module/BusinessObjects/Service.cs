using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Xpo;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;

namespace ComplexDialogSample.Module.BusinessObjects {

    [NavigationItem("Resources")]
    [DefaultProperty(nameof(Description))]
    public class Service : BaseObject {
        public virtual string Description { get; set; }
    }
}
