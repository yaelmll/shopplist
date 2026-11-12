using System;
using System.Collections.Generic;
using System.Text;

namespace ShoopList.Muai.Models
{
    public class ShopListitem
    {
        public string Nombre { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public bool Comprado { get; set; }

    }
}
