using System;
using System.Collections.Generic;
using System.Text;

namespace UsoInterfaces
{
    class ClassNormal:ClassCliente
    {
        string _Nombre;
        string _Apellido;
        int _Edad;

        public override string Cobros(double Cantidad)//intento el polimorfismo
        {
            return "Usted Gasto: " + Cantidad;
        }

        //Constructor
        public ClassNormal (string Name, string LastName, int Age) : base (Name, LastName, Age)
        {
            _Nombre = Name;
            _Apellido = LastName;
            _Edad = Age;
        }
    }
}
