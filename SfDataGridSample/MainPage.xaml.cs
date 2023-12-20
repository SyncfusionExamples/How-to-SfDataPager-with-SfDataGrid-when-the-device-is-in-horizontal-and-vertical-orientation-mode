namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            if (width > height)
                dataPager.PageSize = 5;
            else
                dataPager.PageSize = 10;
            base.OnSizeAllocated(width, height);
        }
    }
}
