using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Editors;
using ComplexDialogSample.Module.BusinessObjects;

namespace ComplexDialogSample.Module.Controllers {
    public class MyController : ObjectViewController<ListView,Office> {
        public MyController() {
            PopupWindowShowAction action = new PopupWindowShowAction(this, "AssignJobs", PredefinedCategory.RecordEdit);
            action.SelectionDependencyType = SelectionDependencyType.RequireMultipleObjects;
            action.CustomizePopupWindowParams += new CustomizePopupWindowParamsEventHandler(action_CustomizePopupWindowParams);
            action.Execute += new PopupWindowShowActionExecuteEventHandler(action_Execute);
        }
        void action_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
            IObjectSpace os = Application.CreateObjectSpace(typeof(OrderTemplate));
            e.Context = TemplateContext.PopupWindow;
            var template = os.CreateObject<OrderTemplate>();
            e.View = Application.CreateDetailView(os, template);
        }
        void action_Execute(object sender, PopupWindowShowActionExecuteEventArgs e) {
            OrderTemplate parameters =(OrderTemplate) e.PopupWindow.View.CurrentObject;
            ListPropertyEditor listPropertyEditor = ((DetailView)e.PopupWindow.View).FindItem("Services") as ListPropertyEditor;
            IObjectSpace os = Application.CreateObjectSpace(typeof(Team));
            foreach (Office b in e.SelectedObjects) {
                Team team = os.GetObject<Team>(parameters.Team);
                foreach (Service service in listPropertyEditor.ListView.SelectedObjects) {
                    Order order = os.CreateObject<Order>();
                    order.DueDate = parameters.DueDate;
                    order.Team = team;
                    order.Office = os.GetObject<Office>(b);
                    order.Service = os.GetObject<Service>(service);
                }
            }
            os.CommitChanges();
        }
    }
}
