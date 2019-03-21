using System;
using System.Collections.Generic;
using System.Text;

namespace UsoInterfaces
{
    //Clase con Herencia de la interface persona
    public class Empleado : Persona
    {   //Cree variables nuevas para poder usar los metodos heredados de la interface
        string _Nombre; //de no usarlos se crea un overflow
        string _Apellido;
        int _Edad;
        string _Puesto;

        //Propiedades heredadas implementadas con codigo set y get
        public string Nombre //Implementacion de la interface para Nombre debe ser "public" por ser 
        {                    // heredado de una interface
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

        //Valor unico de estab clase para empleados 
        public string Puesto
        {
            get { return this._Puesto; }
            set { this._Puesto = value; }
        }

        //Constructores
        public Empleado (string Name, string LastName, int Age, string Position)
        {
            _Nombre = Name;
            _Apellido = LastName;
            _Edad = Age;
            _Puesto = Position;
        }

        //Metodos
        //Muestra los datos del Empleado
        public void  Datos()
        {
            Console.WriteLine("El nombre del Empleado es: " + Nombre + 
                " Y su apellido es: "+ Apellido +" Edad: " + Edad +
                "Se desempeña como: " + Puesto);
            Console.ReadLine();
        }

        //Ingresa la fecha en que inicio a laborar y regresa un mensaje *Sobrecarga de metodo*
        public void Datos(DateTime FechaIngreso) 
        {                                        
            Console.WriteLine("El empleado "+Nombre+" ah trabajado como "+ Puesto+
                                " Desde "+FechaIngreso);
            Console.ReadLine();
        }


    }
}
