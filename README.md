# Binding Expando and Dynamic Objects to the ASP.NET Core DataGrid Control

A quick start ASP.NET Core web application that shows how to bind the Expando and Dynamic Objects to a Data Grid.

The expando-Object is a class that allows you to add and delete a member of its instance at runtime and to set and get their values. Usually, the ASP.NET Core DataGrid is strongly bound to a data source model type. To define the model type at runtime, you can use this expando object class.

The dynamic object class enables you to define the structure of an object at runtime, specifying the operations to be performed and how to perform those. You cannot directly create an instance of the dynamic object class. To implement the dynamic behavior, inherit a dynamic dictionary from the dynamic object class and override the TryGetMember, ‘TrySetMember’ and ‘GetDynamicMemberNames’ methods.

Refer to the expando object binding documentation for the Syncfusion ASP.NET Core DataGrid control: 
https://ej2.syncfusion.com/aspnetcore/documentation/grid/data-binding/local-data#expandoobject-binding 

Refer to the dynamic object binding documentation for the Syncfusion ASP.NET Core DataGrid control: 
https://ej2.syncfusion.com/aspnetcore/documentation/grid/data-binding/local-data#dynamicobject-binding 

Check out this online example of exporting in the Syncfusion ASP.NET Core DataGrid control:
https://ej2.syncfusion.com/aspnetcore/Grid/ExpandoObjectBinding#/fluent 

Check out this online example of exporting in the Syncfusion ASP.NET Core DataGrid control:
https://ej2.syncfusion.com/aspnetcore/Grid/DynamicObjectBinding#/fluent 

Refer to the list binding documentation for the Syncfusion ASP.NET Core DataGrid control: 
https://ej2.syncfusion.com/aspnetcore/documentation/grid/data-binding/local-data#list-binding

Refer to the remote data binding documentation for the Syncfusion ASP.NET Core DataGrid control: 
https://ej2.syncfusion.com/aspnetcore/documentation/grid/data-binding/remote-data 

Refer to the data table binding documentation for the Syncfusion ASP.NET Core DataGrid control:
https://ej2.syncfusion.com/aspnetcore/documentation/grid/data-binding/data-table 

Watch the video to get started with the ASP.NET Core DataGrid control:
https://www.youtube.com/watch?v=E5w2fO-N9gE  


## Project pre-requisites

Make sure that you have the compatible versions of Visual Studio 2022 and .NET 7.0 SDK framework in your machine before starting to work on this project.

### How to run this application?

To run this application, you need to clone the `binding-expando-and-dynamic-objects-to-the-aspdotnet-core-datagrid` repository and then open it in Visual Studio Code. Now, simply install all the necessary react packages into your current project by pressing the `F5` command.