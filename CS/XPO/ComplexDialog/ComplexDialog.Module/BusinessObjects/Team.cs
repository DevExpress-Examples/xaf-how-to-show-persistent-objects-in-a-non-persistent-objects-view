using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ComplexDialogSample.Module.BusinessObjects {
    [NavigationItem("Resources")]
    public class Team : BaseObject {
        public Team(Session session) : base(session) { }
        public string Name {
            get { return GetPropertyValue<string>("Name"); }
            set { SetPropertyValue<string>("Name", value); }
        }
    }
}
