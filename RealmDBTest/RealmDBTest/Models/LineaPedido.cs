using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmDBTest.Models
{
    public class LineaPedido: RealmObject
    {
        public string Descripcion { get; set; }
        public double Unidades { get; set; }
        public double Importe { get; set; }
        public Pedido Pedido { get; set; }
    }
}
