using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoopList.Muai.Models;
using ShoopList.Muai.Viwes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


namespace ShoopList.Muai.ViwesModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ShopListeItem> _items;

        public MainViewModel()
        {
            Items = new ObservableCollection<ShopLisItem>();
            LOadItems();
        }
        private void LOadItems()
        {
            Items.add(new ShopListItem
            {
                Nombre = "Leche",
                Cantidad = 2,
                Comprado = false
            });
            Items.add(new ShopListItem
            {
                Nombre = "Pan",
                Cantidad = 1,
                Comprado = false

            }
            Items.add(new ShopListItem
            {
                Nombre = "Hariana",
                Cantidad = 3,
                Comprado = false
            }
            }
        [RelayCommand]
        private async Task showNewItemFormAsync()
        {
            await Shell.Current.GoToAsync(nameof(EditShopListtemPage));
        }


}
    }
