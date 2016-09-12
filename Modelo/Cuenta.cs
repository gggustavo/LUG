using System.Collections.Generic;

namespace Modelo
{
    public abstract class Cuenta
    {
        public int IdCuenta { get; set; }

        public double Saldo { get; set; }

        public ICollection<Titular> Titular { get; set; }
    }
}
