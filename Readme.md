<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128593301/22.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5067)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to show persistent objects in a non-persistent object's view

This example demonstrates how to declare a collection property of a persistent type in a non-persistent class and display it in the UI.

![image](https://user-images.githubusercontent.com/14300209/229573300-ecc21bd7-51e2-4cd9-bf34-cc6c73622efb.png)

## Implementation Details
1. Create a non-persistent class that implements entry fields and use [**PopupWindowShowAction**](https://docs.devexpress.com/eXpressAppFramework/402158/getting-started/in-depth-tutorial-blazor/add-actions-menu-commands/add-an-action-that-displays-a-pop-up-window) to display a [Detail View](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.DetailView) of the class instance in a pop-up window.
2. Extend the class with a collection property that allows user to select items from a list. To read the selection in the Action's `Execute` event, access the `ListPropertyEditor` that is the nested List View.
3. Handle the `ObjectSpaceCreated` event to create an `ObjectSpace` that can handle persistent objects (the collection property you added). Review the following documentation article for additional information: [How to: Show Persistent Objects in a Non-Persistent Object's View](https://docs.devexpress.com/eXpressAppFramework/116106/business-model-design-orm/non-persistent-objects/how-to-show-persistent-objects-in-a-non-persistent-objects-view)
4. The pop-up window invoked by the **PopupWindowShowAction** contains the **OK** and **Cancel** buttons implemented in the [DialogController](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.SystemModule.DialogController). To add other Actions, create a controller for the dialog class and set the `Category` to `PopupActions`.</p>

## Files to Review

* [BusinessObjects](./CS/EFCore/ComplexDialogEF/ComplexDialogEF.Module/BusinessObjects)
* [MyController.cs](./CS/EFCore/ComplexDialogEF/ComplexDialogEF.Module/Controllers/MyController.cs)
* [Module.cs (XPO](./CS/EFCore/ComplexDialogEF/ComplexDialogEF.Module/Module.cs)
 

## Documentation

* [Non-Persistent Objects](https://docs.devexpress.com/eXpressAppFramework/116516/business-model-design-orm/non-persistent-objects)
* [How to: Show Persistent Objects in a Non-Persistent Object's View](https://docs.devexpress.com/eXpressAppFramework/116106/business-model-design-orm/non-persistent-objects/how-to-show-persistent-objects-in-a-non-persistent-objects-view)
