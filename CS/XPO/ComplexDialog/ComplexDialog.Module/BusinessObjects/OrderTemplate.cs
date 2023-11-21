using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;

namespace ComplexDialogSample.Module.BusinessObjects {
    [DomainComponent]
    public class OrderTemplate : NonPersistentBaseObject {
       public DateTime DueDate { get; set; }
        public Team Team { get; set; }
        private IList<Service> _services;
        public IList<Service> Services {
            get {
                if (_services == null) {
                    _services = ObjectSpace.GetObjects<Service>();
                }
                return _services;
            }
        }
    }
}
