using RealmDBTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RealmDBTest.Views
{
    public partial class ClientesView : ContentPage
    {
        private ClientesModel _clientesModel = null;

        public ClientesView()
        {
            InitializeComponent();

            _clientesModel = new ClientesModel();
            BindingContext = _clientesModel;
        }
    }
}
