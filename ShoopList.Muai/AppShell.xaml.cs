namespace ShoopList.Muai
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // gragar rutas de navegasion de las paginas de la apliciones
            Routing.RegisterRoute (nameof(EditShopListtemPage), typeof(EditShopListtemPage));
        }
    }
}
