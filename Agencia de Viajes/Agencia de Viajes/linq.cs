using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Agencia_de_Viajes
{
    public class linq:DataContext
    {
        public linq() :base(@"Data Source=LAPTOP-8CHPRFRC\SQLEXPRESS;Initial Catalog=dbAgencia;Integrated Security=True") { }
        public Table<Pasajero> tblPasajero;
        public Table<Agencia> tblAgecia;
        public Table<Pais> tblPais;
        public Table<Vuelo> tblVuelo;
        // Segundo cambio
    }
}
