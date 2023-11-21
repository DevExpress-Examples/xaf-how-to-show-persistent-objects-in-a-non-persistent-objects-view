using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace ComplexDialogSample.Module.BusinessObjects {
    [NavigationItem("Resources")]
    public class Team : BaseObject {
        public virtual string Name { get; set; }
    }
}
