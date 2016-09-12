using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Modelo;

namespace Controladora
{
    public static class TestEntity
    {

        public static void Initial()
        {
            using (var context = new Context())
            {

                //var titulares = new List<Titular>
                //{
                //    new Titular {Nombre = "Titular 1"},
                //    new Titular {Nombre = "Titular 1"}
                //};

                //context.Titulares.AddRange(titulares);
                //context.SaveChanges();

                var titulares = context.Titulares.ToList();

                var cuenta = new CajaAhorro
                {
                    Saldo = 1000,
                    Titular = titulares
                };

                context.Cuentas.Add(cuenta);
                context.SaveChanges();



            }
        }
    }
}
