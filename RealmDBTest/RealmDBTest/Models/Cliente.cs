using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmDBTest.Models
{
    public class Cliente: RealmObject
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public RealmList<Pedido> Pedidos{ get; }
    }
}
