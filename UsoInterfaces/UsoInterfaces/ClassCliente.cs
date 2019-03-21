using System;
using System.Collections.Generic;
using System.Text;

namespace UsoInterfaces
{
    class ClassCliente:Persona
    {
        String _Nombre;
        String _Apellido;
        int _Edad;

        public string Nombre 
        {                    
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }
        public string Apellido
        {
            get { return this._Apellido; }
            set { this._Apellido = value; }
        }
        public int Edad
        {
            get { return this._Edad; }
            set { this._Edad = value; }
        }
                                        //Trato de diferenciar cliente normal de un socio con descuento
        public virtual string Cobros(double Cantidad)//mediante el polimorfismo
        {
            return "su consumo fue de "+ Cantidad;
        }

        //Constructor
        public ClassCliente(string Name, string LastName, int Age)
        {
            _Nombre = Name;
            _Apellido = LastName;
            _Edad = Age;
        }

    }
}
