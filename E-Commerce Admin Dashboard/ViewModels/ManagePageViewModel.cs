namespace E_Commerce_Admin_Dashboard.ViewModels
{
    public class ManagePageViewModel
    {
        public List<ProductViewModel> Products { get; set; } = new();
        public ProductViewModel NewProduct { get; set; } = new();
    }
}
