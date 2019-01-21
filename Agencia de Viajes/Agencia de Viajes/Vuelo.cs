using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Agencia_de_Viajes
{
    [Table(Name = "tblVuelo")]
    public class Vuelo
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        private int idVuelo;
        [Column]
        private int idPasajero;
        [Column]
        private int idAgencia;
        [Column]
        private int idPais;
        [Column]
        private int numMaletas;
        [Column]
        private double total;

        public Vuelo() { }

        public override string ToString()
        {
            return "IdVuelo: "+idVuelo+" idPasajero: "+idPasajero+" idAgencia: "+IdAgencia+" idPais: "+idPais+" #Maletas: "+numMaletas+" total $"+total;
        }

        public int IdVuelo { get => idVuelo; set => idVuelo = value; }
        public int IdPasajero { get => idPasajero; set => idPasajero = value; }
        public int IdAgencia { get => idAgencia; set => idAgencia = value; }
        public int IdPais { get => idPais; set => idPais = value; }
        public int NumMaletas { get => numMaletas; set => numMaletas = value; }
        public double Total { get => total; set => total = value; }
    }
}
