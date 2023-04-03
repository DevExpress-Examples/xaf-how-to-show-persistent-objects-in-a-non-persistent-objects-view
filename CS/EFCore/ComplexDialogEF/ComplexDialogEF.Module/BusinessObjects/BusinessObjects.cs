using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Xpo;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;

namespace ComplexDialogSample.Module.BusinessObjects {
    [DomainComponent]
    public class OrderTemplate : IObjectSpaceLink {
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
        private IObjectSpace objectSpace;
        [Browsable(false)]
        public IObjectSpace ObjectSpace {
            get { return objectSpace; }
            set { objectSpace = value; }
        }
    }


    [NavigationItem("Resources")]
    public class Team : BaseObject {
        public virtual string Name { get; set; }
    }

    [NavigationItem("Process")]
    [DefaultProperty(nameof(Index))]
    public class Office : BaseObject {
        public virtual string Index { get; set; }
        public virtual string OccupiedBy { get; set; }
    }

    [NavigationItem("Process")]
    public class Order : BaseObject {
        public virtual Team Team { get; set; }
        public virtual Office Office { get; set; }
        public virtual Service Service { get; set; }
        public virtual DateTime DueDate { get; set; }
    }

    [NavigationItem("Resources")]
    [DefaultProperty(nameof(Description))]
    public class Service : BaseObject {
        public virtual string Description { get; set; }
    }
}
