using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.ComponentModel;

namespace ComplexDialogSample.Module.BusinessObjects {
    [NavigationItem("Process")]
    [DefaultProperty(nameof(Index))]
    public class Office : BaseObject {
        public virtual string Index { get; set; }
        public virtual string OccupiedBy { get; set; }
    }
}
