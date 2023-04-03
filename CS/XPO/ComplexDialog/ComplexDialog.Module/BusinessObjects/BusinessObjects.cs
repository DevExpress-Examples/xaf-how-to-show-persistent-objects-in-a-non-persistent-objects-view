using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;

namespace ComplexDialogSample.Module.BusinessObjects {
    [DomainComponent]
    public class OrderTemplate :IObjectSpaceLink{
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
        public Team(Session session) : base(session) { }
        public string Name {
            get { return GetPropertyValue<string>("Name"); }
            set { SetPropertyValue<string>("Name", value); }
        }
    }

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
