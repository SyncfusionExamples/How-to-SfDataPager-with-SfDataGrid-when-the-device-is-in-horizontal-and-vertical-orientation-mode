# How to have different page size in SfDataPager with SfDataGrid when the device is in horizontal and vertical orientation mode?

The [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) allows you to have different page size when device is in horizontal and vertical orientation mode by overriding the OnSizeAllocated method where we can specify the size of the data pager.

The below code example illustrates how to have different page size, when the device is in horizontal and vertical orientation.
```C#
protected override void OnSizeAllocated(double width, double height)  
{  
    if (width > height)  
        dataPager.PageSize = 5;  
    else  
        dataPager.PageSize = 10;  
    base.OnSizeAllocated(width, height);  
}  
```
Please find the sample from the below link.
 
[View sample in Github](https://github.com/SyncfusionExamples/How-to-SfDataPager-with-SfDataGrid-when-the-device-is-in-horizontal-and-vertical-orientation-mode/tree/master)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).

##### Conclusion

I hope you enjoyed learning about How to have different page size in SfDataPager with SfDataGrid when the device is in horizontal and vertical orientation mode? in .NET MAUI DataGrid (SfDataGrid).

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.

If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!