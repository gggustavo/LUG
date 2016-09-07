using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Cuenta
    {
        public int IdCuenta { get; set; }

        public double Saldo { get; set; }

       // public int IdTitular { get; set; }

        public ICollection<Titular> Titular { get; set; }
    }
}
