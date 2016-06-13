using RealmDBTest.Models;
using RealmDBTest.Views;
using System.Collections.ObjectModel;


namespace RealmDBTest.ViewModels
{
    public class ClientesModel: BaseModel
    {
        private readonly ObservableCollection<Cliente> _clientes;
        public ObservableCollection<Cliente> Clientes
        {
            get { return _clientes; }
        }

        public Cliente SelectedClientItem
        {
            get
            {
                return null;
            }
            set
            {
                if (value != null)
                    App.Navigation.PushAsync(new PedidosView(value));

                OnPropertyChanged("SelectedClientItem");
            }
        }


        public ClientesModel()
        {
            _clientes = new ObservableCollection<Cliente>(App.RealmDB.GetClientes());
        }
    }
}
