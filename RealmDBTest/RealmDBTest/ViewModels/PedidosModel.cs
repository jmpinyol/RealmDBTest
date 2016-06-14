using RealmDBTest.Models;
using RealmDBTest.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmDBTest.ViewModels
{
    public class PedidosModel: BaseModel
    {
        private readonly ObservableCollection<Pedido> _pedidos;
        public ObservableCollection<Pedido> Pedidos
        {
            get { return _pedidos; }
        }

        public Pedido SelectedPedidoItem
        {
            get
            {
                return null;
            }
            set
            {
                if (value!=null)
                    App.Navigation.PushAsync(new PedidoView(value));
                OnPropertyChanged("SelectedPedidoItem");
            }
        }

        public Cliente Cliente { get; set; }

        public PedidosModel(Cliente cliente)
        {
            Cliente = cliente;
            _pedidos = new ObservableCollection<Pedido>(App.RealmDB.GetPedidosCliente(cliente));
        }
    }
}
