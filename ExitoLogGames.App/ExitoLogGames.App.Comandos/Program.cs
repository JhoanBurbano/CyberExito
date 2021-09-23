using System;
using ExitoLogGames.App.Dominio;
using ExitoLogGames.App.Persistencia;

namespace ExitoLogGames.App.Comandos
{
    class Program
    {
        private static CRUDEmploy crud = new CRUDempleado(new Connection());
        static void Main(string[] args)
        {
            Connection conexion = new Connection();
            InicioCRUD();

        }

        private static void InicioCRUD()
        {
            bool res = true;
            while (res == true)
            {
                Console.WriteLine("BIENVENIDO AL REGISTRO DE USUARIOS\nMENÚ... \n1.\tAgregar Empleado\n2.\tBuscar Empleado\n3.\tActualizar Empleado\n4.\tEliminar Empleado\n0.\tLista de Empleados\n#. \tSalir del programa \nDigite el numero de la accion que quiere realizar");
                string opcion = Console.ReadLine();
                bool r = true;
                string x = "";
                switch (opcion)
                {
                    case "1":
                        r = true;
                        while (r == true)
                        {
                            Employ empleado = new Employ();
                            Console.WriteLine("Digite el Nombre del Empleado");
                            empleado.Nombre = Console.ReadLine();
                            Console.WriteLine("Digite el Apellido del Empleado");
                            empleado.Apellido = Console.ReadLine();
                            Console.WriteLine("Digite la Cedula del Empleado");
                            empleado.Cedula = Console.ReadLine();
                            Console.WriteLine("Digite el Sucursal del Empleado");
                            empleado.Sucursal = Console.ReadLine();
                            Console.WriteLine("Digite el Usuario del Empleado");
                            empleado.Usuario = Console.ReadLine();
                            Console.WriteLine("Digite el Password del Empleado");
                            empleado.Password = Console.ReadLine();
                            crud.AddEmploy(empleado);
                            Console.WriteLine("Se creó el empleado");
                            Console.WriteLine("¿Quiere añadir otro empleado?(Digite su opcion) \n1-Si 2-No");
                            x = Console.ReadLine();
                            if (x == "1")
                            {
                                r = true;
                            }
                            else if (x == "2")
                            {
                                r = false;
                            }
                            else
                            {
                                Console.WriteLine(x + "\tNo es una opcion valida");
                                r = false;
                            }
                        }
                        break;
                    case "2":
                        r = true;
                        while (r == true)
                        {
                            Console.WriteLine("Digite el id de su empleado");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = crud.GetEmploy(idEmpleado);
                            if(empleado!=null)
                            {
                            Console.WriteLine($"Su empleado es:\n{empleado.Nombre} {empleado.Apellido} \nCC: {empleado.Cedula} \nSucursal: {empleado.Sucursal} \nUsuario:{empleado.Usuario} \nPassword:{empleado.Password}");
                            Console.WriteLine("\n¿Quiere buscar otro empleado? (digite su opcion) 1-Si 2-No");
                            x = Console.ReadLine();
                            if (x == "1")
                            {
                                r = true;
                            }
                            else if (x == "2")
                            {
                                r = false;
                            }
                            else
                            {
                                Console.WriteLine(x + "\tNo es una opcion valida");
                                r = false;
                            }}else{
                                Console.WriteLine("\nNo es un ID valido");

                            }
                        }
                        break;
                    case "3":
                        r = true;
                        while (r == true)
                        {
                            Console.WriteLine("Digite el id de su empleado");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = crud.GetEmploy(idEmpleado);
                            if (empleado != null)
                            {
                                Console.WriteLine($"El empleado a modificar es:\n{empleado.Nombre} {empleado.Apellido} \nCC: {empleado.Cedula} \nSucursal: {empleado.Sucursal} \nUsuario:{empleado.Usuario} \nPassword:{empleado.Password}");
                                Console.WriteLine("Ahora digite los datos que va a cambiar, si no va a cambiar alguno puede dejarlo vacío");
                                Employ employ = new Employ();
                                var atr = "";
                                Console.WriteLine("Digite el Nombre del Empleado");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Nombre = atr;
                                    Console.WriteLine(atr.GetType());
                                }
                                else { employ.Nombre = empleado.Nombre; }
                                Console.WriteLine("Digite el Apellido del Empleado");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Apellido = atr;
                                }
                                else { employ.Apellido = empleado.Apellido; }
                                Console.WriteLine("Digite la Cedula del Empleado");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Cedula = atr;
                                }
                                else { employ.Cedula = empleado.Cedula; }
                                Console.WriteLine("Digite la Sucursal del Empleado");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Sucursal = atr;
                                }
                                else { employ.Sucursal = empleado.Sucursal; }
                                Console.WriteLine("Digite el Usuario del Empleado");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Usuario = atr;
                                }
                                else { employ.Usuario = empleado.Usuario; }
                                Console.WriteLine("Digite el Password del Empleado");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Password = atr;
                                }
                                else { employ.Password = empleado.Password; }
                                var change = crud.UpdateEmploy(employ);
                                Console.WriteLine(change);
                                Console.WriteLine($"El empleado actualizado es:\n{change.Nombre} {change.Apellido} \nCC: {change.Cedula} \nSucursal: {change.Sucursal} \nUsuario:{change.Usuario} \nPassword:{change.Password}");
                                Console.WriteLine("\n¿Quiere actualizar otro empleado? (digite su opcion) 1-Si 2-No");
                                x = Console.ReadLine();
                                if (x == "1")
                                {
                                    r = true;
                                }
                                else if (x == "2")
                                {
                                    r = false;
                                }
                                else
                                {
                                    Console.WriteLine(x + "\tNo es una opcion valida");
                                    r = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNo es un ID valido");

                            }

                        }
                        break;
                    case "4":
                        r = true;
                        while (r == true)
                        {
                            Console.WriteLine("Digite el id de su empleado");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = crud.GetEmploy(idEmpleado);
                            if (empleado != null)
                            {
                                Console.WriteLine($"El empleado a eliminar es:\n{empleado.Nombre} {empleado.Apellido} \nCC: {empleado.Cedula} \nSucursal: {empleado.Sucursal} \nUsuario:{empleado.Usuario} \nPassword:{empleado.Password}");
                                crud.DeleteEmploy(idEmpleado);
                                Console.WriteLine("Se eliminó el empleado");
                                Console.WriteLine("\n¿Quiere eliminar otro empleado? (digite su opcion) 1-Si 2-No");
                                x = Console.ReadLine();
                                if (x == "1")
                                {
                                    r = true;
                                }
                                else if (x == "2")
                                {
                                    r = false;
                                }
                                else
                                {
                                    Console.WriteLine(x + "\tNo es una opcion valida");
                                    r = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNo es un ID valido");

                            }
                        }
                        break;
                    case "0":
                        Console.WriteLine("La lista de empleados es");
                        var lista = crud.GetAllEmploys();
                        foreach(Employ e in lista){
                            Console.WriteLine($"{e.EmployId} \t {e.Nombre} {e.Apellido}");
                        }
                        // Console.WriteLine(lista.GetEnumerator());
                        // Console.WriteLine($"{lista} empleados.");
                        // for(int i = 0; i < lista.Count; i++){
                        //     Console.WriteLine($"{lista[i].EmployId} \t{lista[i].Nombre} {lista[i].Apellido}");
                        // }
                        break;
                    case "#":
                        Console.WriteLine("Esta saliendo...");
                        res = false;
                        break;
                    default:
                        Console.WriteLine(opcion + " No es una opcion valida.");
                        break;
                }


            }
        }
    }
}
