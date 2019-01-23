using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Agencia_de_Viajes
{
    [Table(Name = "tblPais")]
    public class Pais
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        private int idPais;
        [Column]
        private string nombrePais;
        int numero;

        public Pais() { }

        public override string ToString()
        {
            return nombrePais;
        }
        public int IdPais { get => idPais; set => idPais = value; }
        public string NombrePais { get => nombrePais; set => nombrePais = value; }
    }
}
