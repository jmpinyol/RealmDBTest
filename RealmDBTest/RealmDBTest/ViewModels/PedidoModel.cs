using RealmDBTest.Models;
using System.Collections.ObjectModel;
using System.Linq;


namespace RealmDBTest.ViewModels
{
    public class PedidoModel: BaseModel
    {
        public Pedido Pedido { get; set; }

        private readonly ObservableCollection<LineaPedido> _lineasPedido = null;
        public ObservableCollection<LineaPedido> LineasPedido
        {
            get { return _lineasPedido; }
        }

        public PedidoModel(Pedido pedido)
        {
            Pedido = pedido;
            
            _lineasPedido = new ObservableCollection<LineaPedido>(pedido.Lineas.ToList());
        }
    }
}
