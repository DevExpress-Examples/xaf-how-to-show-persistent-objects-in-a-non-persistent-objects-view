using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace ComplexDialogSample.Module.BusinessObjects {
    [NavigationItem("Process")]
    public class Order : BaseObject {
        public virtual Team Team { get; set; }
        public virtual Office Office { get; set; }
        public virtual Service Service { get; set; }
        public virtual DateTime DueDate { get; set; }
    }
}
