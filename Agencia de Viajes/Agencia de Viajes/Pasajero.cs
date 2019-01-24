using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Agencia_de_Viajes
{
    [Table(Name ="tblPasajero")]
    public class Pasajero
    {
        //Comentario Hola Mundo
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        private int idPasajero;
        [Column]
        private string nombrePasajero;
        [Column]
        private string apellidoPasajero;

        public borrar(){

        }


        public Pasajero() { }

        public override string ToString()
        {
            return idPasajero+" "+nombrePasajero+" "+apellidoPasajero;
        }

        public int IdPasajero { get => idPasajero; set => idPasajero = value; }
        public string NombrePasajero { get => nombrePasajero; set => nombrePasajero = value; }
        public string ApellidoPasajero { get => apellidoPasajero; set => apellidoPasajero = value; }
    }
}
