using System.Collections.Generic;

namespace Modelo
{
    public class Titular
    {
        public int IdTitular { get; set; }
        public string Nombre { get; set; }

        public ICollection<Cuenta> Cuentas { get; set; }
    }
}