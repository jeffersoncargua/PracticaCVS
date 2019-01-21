using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Agencia_de_Viajes
{
    [Table(Name ="tblAgencia")]
    public class Agencia
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        private int idAgencia;
        [Column]
        private string nombreAgencia;

        public Agencia() { }

        public override string ToString()
        {
            return nombreAgencia;
        }

        public int IdAgencia { get => idAgencia; set => idAgencia = value; }
        public string NombreAgencia { get => nombreAgencia; set => nombreAgencia = value; }
    }
}
