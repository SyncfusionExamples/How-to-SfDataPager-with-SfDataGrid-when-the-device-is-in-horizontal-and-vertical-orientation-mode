using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.DataPager;

namespace SfDataGridSample.Behaviors
{
    public class DataGridBehavior : Behavior<ContentPage>
    {
        private SfDataGrid? dataGrid;
        private SfDataPager? dataPager;
        private EmployeeViewModel? employeeViewModel;

        protected override void OnAttachedTo(ContentPage page)
        {
            base.OnAttachedTo(page);
            employeeViewModel = new EmployeeViewModel();
            dataGrid = page.FindByName<SfDataGrid>("dataGrid");
            dataPager = page.FindByName<SfDataPager>("dataPager");
            dataPager.Source = employeeViewModel.Employees;
            dataGrid.ItemsSource = dataPager.PagedSource;         
        }

        protected override void OnDetachingFrom(ContentPage page)
        {
            base.OnDetachingFrom(page);
        }
    }
}
