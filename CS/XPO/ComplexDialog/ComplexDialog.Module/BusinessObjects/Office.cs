using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System.ComponentModel;

namespace ComplexDialogSample.Module.BusinessObjects {
    [NavigationItem("Process")]
    [DefaultProperty(nameof(Index))]
    public class Office : BaseObject {
        public Office(Session session) : base(session) { }
        public string Index {
            get { return GetPropertyValue<string>(nameof(Index)); }
            set { SetPropertyValue<string>(nameof(Index), value); }
        }
        public string OccupiedBy {
            get { return GetPropertyValue<string>(nameof(OccupiedBy)); }
            set { SetPropertyValue<string>(nameof(OccupiedBy), value); }
        }
    }
}
