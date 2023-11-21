using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ComplexDialogSample.Module.BusinessObjects {
    [NavigationItem("Process")]
    public class Order : BaseObject {
        public Order(Session session) : base(session) { }
        public Team Team {
            get { return GetPropertyValue<Team>(nameof(Team)); }
            set { SetPropertyValue<Team>(nameof(Team), value); }
        }
        public Office Office {
            get { return GetPropertyValue<Office>(nameof(Office)); }
            set { SetPropertyValue<Office>(nameof(Office), value); }
        }
        public Service Service {
            get { return GetPropertyValue<Service>(nameof(Service)); }
            set { SetPropertyValue<Service>(nameof(Service), value); }
        }
        public DateTime DueDate {
            get { return GetPropertyValue<DateTime>(nameof(DueDate)); }
            set { SetPropertyValue<DateTime>(nameof(DueDate), value); }
        }
    }
}
