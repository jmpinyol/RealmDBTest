using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmDBTest.Models
{
    public class Pedido: RealmObject
    {
        public int ID { get; set; }
        public DateTimeOffset Fecha { get; set; }
        public double Total { get; set; }
        public Cliente Cliente { get; set; }
        public RealmList<LineaPedido> Lineas { get; }
    }
}
