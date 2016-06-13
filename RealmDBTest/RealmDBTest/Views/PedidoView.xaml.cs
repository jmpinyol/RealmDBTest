using RealmDBTest.Models;
using RealmDBTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RealmDBTest.Views
{
    public partial class PedidoView : ContentPage
    {
        private PedidoModel _pedidoModel = null;

        public PedidoView(Pedido pedido)
        {
            InitializeComponent();

            _pedidoModel = new PedidoModel(pedido);
            BindingContext = _pedidoModel;
        }
    }
}
