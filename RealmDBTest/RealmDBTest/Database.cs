using RealmDBTest.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmDBTest
{
    public class Database
    {
        Realm realm;
             
        public Database()
        {
            realm = Realm.GetInstance();
        }

        public void PopulateData()
        {
            using (var transaction = realm.BeginWrite())
            {
                realm.RemoveAll();

                //Cliente
                Cliente cliente = realm.CreateObject<Cliente>();
                cliente.ID = 1;
                cliente.Nombre = "Jose Perez";
                cliente.Telefono = "885456114";

                //Pedido
                Pedido pedido = realm.CreateObject<Pedido>();
                pedido.ID = 1;
                pedido.Cliente = cliente;
                pedido.Fecha = DateTime.Now;
                pedido.Total = 100;
                
                //Lineas de pedido
                for(int i=0; i<10; i++)
                {
                    LineaPedido linea = realm.CreateObject<LineaPedido>();

                    linea.Descripcion = "Linea pedido " + i;
                    linea.Unidades = 1;
                    linea.Importe = 10 * i;

                    pedido.Lineas.Add(linea);
                }

                transaction.Commit();
            }
        }

        public List<Pedido> GetPedidosCliente(Cliente cliente)
        {
            int idCliente = cliente.ID;

            return realm.All<Pedido>().Where(d => d.Cliente.ID == idCliente).ToList();
        }

        public List<Cliente> GetClientes()
        {
            return realm.All<Cliente>().ToList();
        }
    }
}
