<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128593301/22.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5067)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:


* [MyController.cs](./CS/EFCore/ComplexDialogEF/ComplexDialogEF.Module/Controllers/MyController.cs ) 
<!-- default file list end -->
# How to show a complex dialog

![image](https://user-images.githubusercontent.com/14300209/229573300-ecc21bd7-51e2-4cd9-bf34-cc6c73622efb.png)


<p><strong>Task:</strong> We need to ask the user for a number of values by presenting a complex dialog with a number of entry fields nicely arranged.</p>
<p><strong>Solution:</strong> To show a dialog, we create a non-persistent class with properties representing entry fields and show a <a href="https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppDetailViewtopic.aspx">DetailView</a> of its instance via the <a href="https://docs.devexpress.com/eXpressAppFramework/402158/getting-started/in-depth-tutorial-blazor/add-actions-menu-commands/add-an-action-that-displays-a-pop-up-window?p=netstandard">PopupWindowShowAction</a>. Besides querying simple values, we can add a collection-type property to the dialog class to allow selecting items from the list. This selection can be read in the action's Execute event by accessing <strong>ListPropertyEditor</strong> representing the nested list view. The popup window displayed via the action contains the usual OK and Cancel action buttons provided by the <a href="https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppSystemModuleDialogControllertopic.aspx">DialogController</a>. If necessary, you can provide additional action buttons by creating a controller for the dialog class with the Category set to <strong>PopupActions</strong>.</p>

<p><u>See also:<br><a href="https://documentation.devexpress.com/eXpressAppFramework/CustomDocument116516.aspx">Non-Persistent Objects</a><br></u></p>

<br/>


