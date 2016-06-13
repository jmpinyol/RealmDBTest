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
    public partial class PedidosView : ContentPage
    {
        private PedidosModel _pedidosModel = null;

        public PedidosView(Cliente cliente)
        {
            InitializeComponent();

            _pedidosModel = new PedidosModel(cliente);
            BindingContext = _pedidosModel;
        }
    }
}
