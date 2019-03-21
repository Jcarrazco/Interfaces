using System;
/*
 * -------------------------------JORGE ANTONIO CARRAZCO ALVAREZ----------------------------------------
 * --------------------------------07 Marzo 2019--------------------------------------------------------
 * -------------------------------Uso de Sobrecarga de Metodos------------------------------------------
 * -------------------------------Interfaces-----Polimorfismo------------------------------------------
 * 
 * 
 * */

namespace UsoInterfaces
{
    class Program
    {


        static void Main(string[] args)
        {
            string Nombre = "";//Declaracion de datos a usar en el proceso
            string Puesto = "";
            string Apellido = "";
            int Edad=0;
            DateTime FechaIng;
            int Sel = 0;
            char Estado;
            double Total;
            

            Console.WriteLine("----------Bienvenido a Consulta de Empleado--------\n");//Menu de ingreso de Datos
            Console.WriteLine("Ingrese Un Empleado \n");
            Console.WriteLine("Ingrese El Nombre \n");
            Nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese El Apellido \n");
            Apellido = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese La Edad \n");
            Edad = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Ingrese El Puesto \n");
            Puesto = Convert.ToString(Console.ReadLine());

            Empleado Employee = new Empleado(Nombre,Apellido,Edad,Puesto);//creacion del empleado a monitorear
            
            Console.WriteLine("----------Bienvenido a Ingreso de Cliente/Socio--------\n");//Menu de ingreso de Datos cliente
            Console.WriteLine("Ingrese Un Cliente \n");
            Console.WriteLine("Ingrese El Nombre \n");
            Nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese El Apellido \n");
            Apellido = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese La Edad \n");
            Edad = Convert.ToInt32(Console.ReadLine());

            ClassSocio NewSoc = new ClassSocio(Nombre, Apellido, Edad);// crea un nuevo socio
            ClassCliente NewCli = new ClassCliente(Nombre, Apellido, Edad);// crea un nuevo cliente

            Console.Clear();
            Console.WriteLine("Es Socio? (Y o N) \n");//Pregunta si es socio o no para regresar el descuento
            Estado = Convert.ToChar(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese El total de la compra \n");
            Total = Convert.ToDouble(Console.ReadLine());

            if (Estado=='y'  | Estado == 'Y'){
                Console.WriteLine(NewSoc.Cobros(Total));//si es socio llama la funcion cobros para arrojar el descuento
                Console.WriteLine(NewSoc.Cobros(Total));
            }
            else
            {
                Console.WriteLine(NewCli.Cobros(Total));// si no es socio llama la funcion 
            }

            

            while (true) {//Ciclo para consultas
                Console.WriteLine("----------Accion---------- ");

                Console.WriteLine("Tecle 1 si desea ver la fecha de ingreso del empleado");
                Console.WriteLine("Tecle 2 para ver los datos del empleado");
                Sel = Convert.ToInt32(Console.ReadLine());

                switch (Sel)
                {

                    case 1:
                        Console.WriteLine("Ingrese Fecha Ingreso en formato DD/MM/YYYY \n"); 
                        FechaIng = Convert.ToDateTime(Console.ReadLine());
                        Employee.Datos(FechaIng);//Sobrecarga de metodos
                        break;
                    case 2:
                        Employee.Datos();//Sobrecarga de metodos
                        break;
                }
            }
            
            

        }
    }
}
