using System;
using System.Collections.Generic;
using System.Text;

namespace UsoInterfaces
{
    class ClassSocio:ClassCliente
    {
        string _Nombre;
        string _Apellido;
        int _Edad;



        //Constructor
        public ClassSocio(string Name, string LastName, int Age) : base(Name,LastName, Age) 
        {
            _Nombre = Name;
            _Apellido = LastName;
            _Edad = Age;
        }

        public override string Cobros(double Cantidad)//intento el polimorfismo
        {
            Cantidad = Cantidad - (Cantidad * .20);
            return "Total de su compra: \n" + (Cantidad) + "\n Con un Descuento de 20%";
        }

    }
}
