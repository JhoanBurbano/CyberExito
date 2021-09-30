using System;
using System.IO;
using ExitoLogGames.App.Dominio;
using ExitoLogGames.App.Persistencia;

namespace ExitoLogGames.App.Comandos
{
    class Program
    {


        private static IRepositorioCompradores aco = new RepositorioCompradores(new Connection());
        private static IRepositorioVendedores ven = new RepositorioVendedores(new Connection());
        private static IRepositorioAdministradores ave = new RepositorioAdministradores(new Connection());
        private static IRepositorioConsolas con = new RepositorioConsolas(new Connection());
        private static IRepositorioControles ctr = new RepositorioControles(new Connection());
        private static IRepositorioVideojuegos vdj = new RepositorioVideojuegos(new Connection());
        private static IRepositorioOrders ped = new RepositorioOrders(new Connection());
        private static IRepositorioFactura fac = new RepositorioFactura(new Connection());
        private static IRepositorioVentas vent = new RepositorioVentas(new Connection());
        private static IRepositorioCompras comp = new RepositorioCompras(new Connection());


        static void Main(string[] args)
        {


            Control cotr = new Control{
                Nombre="C-WII-1",
                Fabricante="Nintendo",
                Version="2022",
                Costo=5.1,
                Precio=12.0,
                Compatibilidad="Nintendo"
            };

            Control contr= ctr.GetControl(1);


            bool menu = true;

            Orders orden = new Orders();
            
                orden.Consola = null;
                orden.Control = contr;
                orden.Videojuego = null;
                orden.Cantidad = 4;
                orden.SubTotal = ((contr.Precio)*orden.Cantidad);
                orden.Operacion = "venta";
        

            ped.UpdateOrder(1, orden);
            Factura factu = new Factura{
                PedidoControles =  null,
                PedidoConsolas = null,
                PedidoVideojuegos = null,
                Fecha = System.DateTime.Now,
                Total = orden.SubTotal
            };
            Factura mifactu = fac.UpdateFactura(1, factu);

            Vendedor vender = new Vendedor{
                Nombre = "Willignton",
                Apellido = "Londoño",
                Cedula = "12332432",
                Sucursal = "Manizales",
                Usuario = "willy@email.com",
                Password = "12332432",
                Cargo = "Vendedor"
            };


            Vendedor vend = ven.UpdateVendedor(vender);

            Console.WriteLine($"Se creó el vendedor {vend.Nombre} {vend.Apellido}");

            Sales salad = vent.AddVenta(new Sales());

            Sales sal = new Sales();
                sal.Fecha = DateTime.Now;
                sal.Factura = mifactu;
                sal.Vendedor = vend;
            vent.UpdateVenta(salad.Id, sal);


            while (menu == true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("############### MENU PRINCIPAL ############### \n1. \tCRUD ADMIN DE COMPRAS \n2. \tCRUD VENDEDORES \n3. \tCRUD ADMINVENTAS \n4. \tCRUD PRODUCTOS  \n#. \t SALIR ");
                Console.ResetColor();
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        CRUDCompradores();
                        break;
                    case "2":
                        CRUDVendedores();
                        break;
                    case "3":
                        CRUDAdministradores();
                        break;
                    case "4":
                        CRUDControles();
                        break;
                    case "#":
                        Console.WriteLine("Está saliendo del PROGRAMA.....");
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("No es una opcion válida");
                        break;
                }

            }
        }

        private static void CRUDCompradores()
        {
            bool main = true;
            while (main == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------ CRUD ADMINISTRADORES DE COMPRAS ------ \nMENÚ.................... \n1.\tAgregar Administrador de Compras\n2.\tBuscar Administrador de Compras\n3.\tActualizar Administrador de Compras\n4.\tEliminar Administrador de Compras\n0.\tLista de Administradores de Compras\n#. \tSalir del programa \nDigite el numero de la accion que quiere realizar");
                Console.ResetColor();
                string opcion = Console.ReadLine();
                bool opt = true;
                string agn = "";
                int cont;
                switch (opcion)
                {
                    case "1":
                        opt = true;
                        while (opt == true)
                        {
                            AdminCompras empleado = new AdminCompras();
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Nombre del Administrador de Compras");
                                empleado.Nombre = Console.ReadLine();
                                if (empleado.Nombre != "" && empleado.Nombre != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Nombre");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Apellido del Administrador de Compras");
                                empleado.Apellido = Console.ReadLine();
                                if (empleado.Apellido != "" && empleado.Apellido != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Apellido");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite la Cedula del Administrador de Compras");
                                empleado.Cedula = Console.ReadLine();
                                if (empleado.Cedula != "" && empleado.Cedula != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener una Cedula");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite la Sucursal del Administrador de Compras");
                                empleado.Sucursal = Console.ReadLine();
                                if (empleado.Sucursal != "" && empleado.Sucursal != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe pertenecer a una Sucursal");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Usuario del Administrador de Compras que es su e-mail");
                                empleado.Usuario = Console.ReadLine();
                                if (empleado.Usuario != "" && empleado.Usuario != " " && empleado.Usuario.Contains("@") && (empleado.Usuario.Contains(".co") || empleado.Usuario.Contains(".com") || empleado.Usuario.Contains(".es")))
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Usuario y debe ser un e-mail de la forma 'alguien@example.com'");
                                    Console.ResetColor();
                                }
                            }
                            Console.WriteLine("Su Password será su cedula, deberá cambierla en su Primer Ingreso");
                            empleado.Password = empleado.Cedula;
                            empleado.Cargo = "AdminCompras";

                            var info = aco.AddComprador(empleado);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Se Creó el empleado {info.Nombre} {info.Apellido}");
                            Console.ResetColor();

                            Console.WriteLine("¿Quiere añadir otro Administrador de Compras?(Digite su opcion) \n1-Si 2-No");
                            agn = Console.ReadLine();
                            if (agn == "1")
                            {
                                opt = true;
                            }
                            else if (agn == "2")
                            {
                                opt = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                Console.ResetColor();
                                opt = false;
                            }
                        }
                        Console.Clear();
                        break;
                    case "2":
                        opt = true;
                        while (opt == true)
                        {
                            Console.WriteLine("Digite el id de su Administrador de Compras");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = aco.GetComprador(idEmpleado);
                            if (empleado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Su empleado es:\n{empleado.Nombre} {empleado.Apellido} \nCC: {empleado.Cedula} \nCargo: {empleado.Cargo} \nSucursal: {empleado.Sucursal} \nUsuario:{empleado.Usuario} \nPassword:{empleado.Password}");
                                Console.ResetColor();
                                Console.WriteLine("¿Quiere buscar otro Administrador de Compras?(Digite su opcion) \n1-Si 2-No");
                                agn = Console.ReadLine();
                                if (agn == "1")
                                {
                                    opt = true;
                                }
                                else if (agn == "2")
                                {
                                    opt = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                    Console.ResetColor();
                                    opt = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nNo es un ID valido");
                                Console.ResetColor();
                            }

                        }
                        Console.Clear();
                        break;
                    case "3":
                        opt = true;
                        while (opt == true)
                        {
                            Console.WriteLine("Digite el id de su Administrador de Compras");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = aco.GetComprador(idEmpleado);
                            if (empleado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"El empleado a modificar es:\n{empleado.Nombre} {empleado.Apellido} \nCC: {empleado.Cedula} \nCargo: {empleado.Cargo} \nSucursal: {empleado.Sucursal} \nUsuario:{empleado.Usuario} \nPassword:{empleado.Password}");
                                Console.ResetColor();
                                Console.WriteLine("Ahora digite los datos que va a cambiar, si no va a cambiar alguno puede dejarlo vacío");
                                AdminCompras employ = new AdminCompras();
                                var atr = "";
                                Console.WriteLine("Digite el Nombre del Administrador de Compras");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Nombre = atr;
                                    Console.WriteLine(atr.GetType());
                                }
                                else { employ.Nombre = empleado.Nombre; }
                                Console.WriteLine("Digite el Apellido del Administrador de Compras");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Apellido = atr;
                                }
                                else { employ.Apellido = empleado.Apellido; }
                                Console.WriteLine("Digite la Cedula del Administrador de Compras");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Cedula = atr;
                                }
                                else { employ.Cedula = empleado.Cedula; }
                                Console.WriteLine("Digite la Sucursal del Administrador de Compras");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Sucursal = atr;
                                }
                                else { employ.Sucursal = empleado.Sucursal; }
                                Console.WriteLine("Digite el Usuario del Administrador de Compras");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Usuario = atr;
                                }
                                else { employ.Usuario = empleado.Usuario; }
                                Console.WriteLine("Digite el Password del Administrador de Compras");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Password = atr;
                                }
                                else { employ.Password = empleado.Password; }
                                employ.Cargo = empleado.Cargo;
                                var change = aco.UpdateComprador(employ);
                                Console.WriteLine(change);
                                Console.WriteLine($"El empleado actualizado es:\n{change.Nombre} {change.Apellido} \nCC: {change.Cedula} \nSucursal: {change.Sucursal} \nUsuario:{change.Usuario} \nPassword:{change.Password}");
                                Console.WriteLine("¿Quiere Actualizar otro Administrador de Compras?(Digite su opcion) \n1-Si 2-No");
                                agn = Console.ReadLine();
                                if (agn == "1")
                                {
                                    opt = true;
                                }
                                else if (agn == "2")
                                {
                                    opt = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                    Console.ResetColor();
                                    opt = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nNo es un ID valido");
                                Console.ResetColor();

                            }

                        }
                        Console.Clear();
                        break;
                    case "4":
                        opt = true;
                        while (opt == true)
                        {
                            Console.WriteLine("Digite el id de su Administrador de Compras");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = aco.GetComprador(idEmpleado);
                            if (empleado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"El empleado a eliminar es:\n{empleado.Nombre} {empleado.Apellido} \nCC: {empleado.Cedula} \nCargo: {empleado.Cargo} \nSucursal: {empleado.Sucursal} \nUsuario:{empleado.Usuario} \nPassword:{empleado.Password}");
                                aco.DeleteComprador(idEmpleado);
                                Console.WriteLine("Se eliminó el Administrador de Compras");
                                Console.ResetColor();
                                Console.WriteLine("\n¿Quiere eliminar otro Administrador de Compras? (digite su opcion) 1-Si 2-No");
                                agn = Console.ReadLine();
                                if (agn == "1")
                                {
                                    opt = true;
                                }
                                else if (agn == "2")
                                {
                                    opt = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                    Console.ResetColor();
                                    opt = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nNo es un ID valido");
                                Console.ResetColor();

                            }
                        }
                        Console.Clear();
                        break;
                    case "0":
                        Console.WriteLine("La lista de empleados es:");
                        var lista = aco.GetAllCompradores();
                        foreach (AdminCompras e in lista)
                        {
                            Console.WriteLine($"-> {e.Id} \t {e.Nombre} {e.Apellido}");
                        }

                        break;
                    case "#":
                        Console.WriteLine("Está Saliendo ..........\n\n\n");
                        main = false;
                        break;
                    default:
                        Console.WriteLine(opcion + " No es una opcion valida.\n\n\n");
                        Console.Clear();
                        break;
                }
            }
        }

        private static void CRUDVendedores()
        {
            bool main = true;
            while (main == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------ CRUD VENDEDORES ------ \nMENÚ.................... \n1.\tAgregar Vendedor\n2.\tBuscar Vendedor\n3.\tActualizar Vendedor\n4.\tEliminar Vendedor\n0.\tLista de Vendedores\n#. \tSalir del programa \nDigite el numero de la accion que quiere realizar");
                Console.ResetColor();
                string opcion = Console.ReadLine();
                bool opt = true;
                string agn = "";
                int cont;
                switch (opcion)
                {
                    case "1":
                        opt = true;
                        while (opt == true)
                        {
                            Vendedor empleado = new Vendedor();
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Nombre del Vendedor");
                                empleado.Nombre = Console.ReadLine();
                                if (empleado.Nombre != "" && empleado.Nombre != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Nombre");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Apellido del Vendedor");
                                empleado.Apellido = Console.ReadLine();
                                if (empleado.Apellido != "" && empleado.Apellido != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Apellido");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite la Cedula del Vendedor");
                                empleado.Cedula = Console.ReadLine();
                                if (empleado.Cedula != "" && empleado.Cedula != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener una Cedula");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite la Sucursal del Vendedor");
                                empleado.Sucursal = Console.ReadLine();
                                if (empleado.Sucursal != "" && empleado.Sucursal != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe pertenecer a una Sucursal");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Usuario del Vendedor que es su e-mail");
                                empleado.Usuario = Console.ReadLine();
                                if (empleado.Usuario != "" && empleado.Usuario != " " && empleado.Usuario.Contains("@") && (empleado.Usuario.Contains(".co") || empleado.Usuario.Contains(".com") || empleado.Usuario.Contains(".es")))
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Usuario y debe ser un e-mail de la forma 'alguien@example.com'");
                                    Console.ResetColor();
                                }
                            }
                            Console.WriteLine("Su Password será su cedula, deberá cambierla en su Primer Ingreso");
                            empleado.Password = empleado.Cedula;
                            empleado.Cargo = "Vendedor";

                            var info = ven.AddVendedor(empleado);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Se Creó el empleado {info.Nombre} {info.Apellido}");
                            Console.ResetColor();

                            Console.WriteLine("¿Quiere añadir otro Vendedor?(Digite su opcion) \n1-Si 2-No");
                            agn = Console.ReadLine();
                            if (agn == "1")
                            {
                                opt = true;
                            }
                            else if (agn == "2")
                            {
                                opt = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                Console.ResetColor();
                                opt = false;
                            }
                        }
                        Console.Clear();
                        break;
                    case "2":
                        opt = true;
                        while (opt == true)
                        {
                            Console.WriteLine("Digite el id de su Vendedor");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = ven.GetVendedor(idEmpleado);
                            if (empleado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Su empleado es:\n{empleado.Nombre} {empleado.Apellido} \nCC: {empleado.Cedula} \nCargo: {empleado.Cargo} \nSucursal: {empleado.Sucursal} \nUsuario:{empleado.Usuario} \nPassword:{empleado.Password}");
                                Console.ResetColor();
                                Console.WriteLine("¿Quiere buscar otro Vendedor?(Digite su opcion) \n1-Si 2-No");
                                agn = Console.ReadLine();
                                if (agn == "1")
                                {
                                    opt = true;
                                }
                                else if (agn == "2")
                                {
                                    opt = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                    Console.ResetColor();
                                    opt = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nNo es un ID valido");
                                Console.ResetColor();
                            }

                        }
                        Console.Clear();
                        break;
                    case "3":
                        opt = true;
                        while (opt == true)
                        {
                            Console.WriteLine("Digite el id de su Vendedor");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = ven.GetVendedor(idEmpleado);
                            if (empleado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"El empleado a modificar es:\n{empleado.Nombre} {empleado.Apellido} \nCC: {empleado.Cedula} \nCargo: {empleado.Cargo} \nSucursal: {empleado.Sucursal} \nUsuario:{empleado.Usuario} \nPassword:{empleado.Password}");
                                Console.ResetColor();
                                Console.WriteLine("Ahora digite los datos que va a cambiar, si no va a cambiar alguno puede dejarlo vacío");
                                Vendedor employ = new Vendedor();
                                var atr = "";
                                Console.WriteLine("Digite el Nombre del Vendedor");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Nombre = atr;
                                    Console.WriteLine(atr.GetType());
                                }
                                else { employ.Nombre = empleado.Nombre; }
                                Console.WriteLine("Digite el Apellido del Vendedor");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Apellido = atr;
                                }
                                else { employ.Apellido = empleado.Apellido; }
                                Console.WriteLine("Digite la Cedula del Vendedor");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Cedula = atr;
                                }
                                else { employ.Cedula = empleado.Cedula; }
                                Console.WriteLine("Digite la Sucursal del Vendedor");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Sucursal = atr;
                                }
                                else { employ.Sucursal = empleado.Sucursal; }
                                Console.WriteLine("Digite el Usuario del Vendedor");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Usuario = atr;
                                }
                                else { employ.Usuario = empleado.Usuario; }
                                Console.WriteLine("Digite el Password del Vendedor");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Password = atr;
                                }
                                else { employ.Password = empleado.Password; }
                                employ.Cargo = empleado.Cargo;
                                var change = ven.UpdateVendedor(employ);
                                Console.WriteLine(change);
                                Console.WriteLine($"El empleado actualizado es:\n{change.Nombre} {change.Apellido} \nCC: {change.Cedula} \nSucursal: {change.Sucursal} \nUsuario:{change.Usuario} \nPassword:{change.Password}");
                                Console.WriteLine("¿Quiere Actualizar otro Vendedor?(Digite su opcion) \n1-Si 2-No");
                                agn = Console.ReadLine();
                                if (agn == "1")
                                {
                                    opt = true;
                                }
                                else if (agn == "2")
                                {
                                    opt = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                    Console.ResetColor();
                                    opt = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nNo es un ID valido");
                                Console.ResetColor();

                            }

                        }
                        Console.Clear();
                        break;
                    case "4":
                        opt = true;
                        while (opt == true)
                        {
                            Console.WriteLine("Digite el id de su Vendedor");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = ven.GetVendedor(idEmpleado);
                            if (empleado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"El empleado a eliminar es:\n{empleado.Nombre} {empleado.Apellido} \nCC: {empleado.Cedula} \nCargo: {empleado.Cargo} \nSucursal: {empleado.Sucursal} \nUsuario:{empleado.Usuario} \nPassword:{empleado.Password}");
                                ven.DeleteVendedor(idEmpleado);
                                Console.WriteLine("Se eliminó el Vendedor");
                                Console.ResetColor();
                                Console.WriteLine("\n¿Quiere eliminar otro Vendedor? (digite su opcion) 1-Si 2-No");
                                agn = Console.ReadLine();
                                if (agn == "1")
                                {
                                    opt = true;
                                }
                                else if (agn == "2")
                                {
                                    opt = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                    Console.ResetColor();
                                    opt = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nNo es un ID valido");
                                Console.ResetColor();

                            }
                        }
                        Console.Clear();
                        break;
                    case "0":
                        Console.WriteLine("La lista de empleados es:");
                        var lista = ven.GetAllVendedores();
                        foreach (Vendedor e in lista)
                        {
                            Console.WriteLine($"-> {e.Id} \t {e.Nombre} {e.Apellido}");
                        }

                        break;
                    case "#":
                        Console.WriteLine("Está Saliendo ..........\n\n\n");
                        main = false;
                        break;
                    default:
                        Console.WriteLine(opcion + " No es una opcion valida.\n\n\n");
                        Console.Clear();
                        break;
                }
            }
        }


        private static void CRUDAdministradores()
        {
            bool main = true;
            while (main == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------ CRUD ADMINISTRADORES DE VENTAS ------ \nMENÚ.................... \n1.\tAgregar Administrador de Ventas\n2.\tBuscar Administrador de Ventas\n3.\tActualizar Administrador de Ventas\n4.\tEliminar Administrador de Ventas\n0.\tLista de Administradores de Ventas\n#. \tSalir del programa \nDigite el numero de la accion que quiere realizar");
                Console.ResetColor();
                string opcion = Console.ReadLine();
                bool opt = true;
                string agn = "";
                int cont;
                switch (opcion)
                {
                    case "1":
                        opt = true;
                        while (opt == true)
                        {
                            AdminVentas empleado = new AdminVentas();
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Nombre del Administrador de Ventas");
                                empleado.Nombre = Console.ReadLine();
                                if (empleado.Nombre != "" && empleado.Nombre != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Nombre");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Apellido del Administrador de Ventas");
                                empleado.Apellido = Console.ReadLine();
                                if (empleado.Apellido != "" && empleado.Apellido != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Apellido");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite la Cedula del Administrador de Ventas");
                                empleado.Cedula = Console.ReadLine();
                                if (empleado.Cedula != "" && empleado.Cedula != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener una Cedula");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite la Sucursal del Administrador de Ventas");
                                empleado.Sucursal = Console.ReadLine();
                                if (empleado.Sucursal != "" && empleado.Sucursal != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe pertenecer a una Sucursal");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Entregue la id de la Venta al Administrador de Ventas, si se la pasará despues o le pasara una compra ingrese * ");
                                var idV = Console.ReadLine();
                                if (idV == "*")
                                {
                                    empleado.Ventas = null;
                                    cont = 1;
                                }
                                else if (idV != "" && idV != " " && (vent.GetVenta(Int32.Parse(idV)) != null))
                                {
                                    empleado.Ventas = vent.GetVenta(Int32.Parse(idV));
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe pertenecer existir la venta");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Entregue la id de la Compra al Administrador de Ventas, si se la pasará despues o le pasara una compra ingrese * ");
                                var idC = Console.ReadLine();
                                if (idC == "*")
                                {
                                    empleado.Compras = null;
                                    cont = 1;
                                }
                                else if (idC != "" && idC != " " && (comp.GetCompra(Int32.Parse(idC)) != null))
                                {
                                    empleado.Compras = comp.GetCompra(Int32.Parse(idC));
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe existir la Compra");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Usuario del Administrador de Ventas que es su e-mail");
                                empleado.Usuario = Console.ReadLine();
                                if (empleado.Usuario != "" && empleado.Usuario != " " && empleado.Usuario.Contains("@") && (empleado.Usuario.Contains(".co") || empleado.Usuario.Contains(".com") || empleado.Usuario.Contains(".es")))
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Usuario y debe ser un e-mail de la forma 'alguien@example.com'");
                                    Console.ResetColor();
                                }
                            }
                            Console.WriteLine("Su Password será su cedula, deberá cambierla en su Primer Ingreso");
                            empleado.Password = empleado.Cedula;
                            empleado.Cargo = "AdminVentas";

                            var info = ave.AddAdministrador(empleado);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Se Creó el empleado {info.Nombre} {info.Apellido}");
                            Console.ResetColor();

                            Console.WriteLine("¿Quiere añadir otro Administrador de Ventas?(Digite su opcion) \n1-Si 2-No");
                            agn = Console.ReadLine();
                            if (agn == "1")
                            {
                                opt = true;
                            }
                            else if (agn == "2")
                            {
                                opt = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                Console.ResetColor();
                                opt = false;
                            }
                        }
                        Console.Clear();
                        break;
                    case "2":
                        opt = true;
                        while (opt == true)
                        {
                            Console.WriteLine("Digite el id de su Administrador de Ventas");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = ave.GetAdministrador(idEmpleado);
                            if (empleado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Su empleado es:\n{empleado.Nombre} {empleado.Apellido} \nCC: {empleado.Cedula} \nCargo: {empleado.Cargo} \nSucursal: {empleado.Sucursal} \nUsuario:{empleado.Usuario} \nPassword:{empleado.Password}");
                                Console.ResetColor();
                                Console.WriteLine("¿Quiere buscar otro Administrador de Ventas?(Digite su opcion) \n1-Si 2-No");
                                agn = Console.ReadLine();
                                if (agn == "1")
                                {
                                    opt = true;
                                }
                                else if (agn == "2")
                                {
                                    opt = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                    Console.ResetColor();
                                    opt = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nNo es un ID valido");
                                Console.ResetColor();
                            }

                        }
                        Console.Clear();
                        break;
                    case "3":
                        opt = true;
                        while (opt == true)
                        {
                            Console.WriteLine("Digite el id de su Administrador de Ventas");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = ave.GetAdministrador(idEmpleado);
                            if (empleado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"El empleado a modificar es:\n{empleado.Nombre} {empleado.Apellido} \nCC: {empleado.Cedula} \nCargo: {empleado.Cargo} \nSucursal: {empleado.Sucursal} \nUsuario:{empleado.Usuario} \nPassword:{empleado.Password}");
                                Console.ResetColor();
                                Console.WriteLine("Ahora digite los datos que va a cambiar, si no va a cambiar alguno puede dejarlo vacío");
                                AdminVentas employ = new AdminVentas();
                                var atr = "";
                                Console.WriteLine("Digite el Nombre del Administrador de Ventas");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Nombre = atr;
                                    Console.WriteLine(atr.GetType());
                                }
                                else { employ.Nombre = empleado.Nombre; }
                                Console.WriteLine("Digite el Apellido del Administrador de Ventas");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Apellido = atr;
                                }
                                else { employ.Apellido = empleado.Apellido; }
                                Console.WriteLine("Digite la Cedula del Administrador de Ventas");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Cedula = atr;
                                }
                                else { employ.Cedula = empleado.Cedula; }
                                Console.WriteLine("Digite la Sucursal del Administrador de Ventas");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Sucursal = atr;
                                }
                                else { employ.Sucursal = empleado.Sucursal; }
                                Console.WriteLine("Digite el id de la Venta del Administrador de Ventas");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " ") && (vent.GetVenta(Int32.Parse(atr)) != null))
                                {
                                    employ.Ventas = vent.GetVenta(Int32.Parse(atr));
                                }
                                else { employ.Ventas = empleado.Ventas; }
                                Console.WriteLine("Digite el id de la Compra del Administrador de Ventas");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " ") && (comp.GetCompra(Int32.Parse(atr)) != null))
                                {
                                    employ.Compras = comp.GetCompra(Int32.Parse(atr));
                                }
                                else { employ.Compras = empleado.Compras; }
                                Console.WriteLine("Digite el Usuario del Administrador de Ventas");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Usuario = atr;
                                }
                                else { employ.Usuario = empleado.Usuario; }
                                Console.WriteLine("Digite el Password del Administrador de Ventas");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Password = atr;
                                }
                                else { employ.Password = empleado.Password; }
                                employ.Cargo = empleado.Cargo;
                                var change = ave.UpdateAdministrador(employ);
                                Console.WriteLine(change);
                                Console.WriteLine($"El empleado actualizado es:\n{change.Nombre} {change.Apellido} \nCC: {change.Cedula} \nSucursal: {change.Sucursal} \nUsuario:{change.Usuario} \nPassword:{change.Password}");
                                Console.WriteLine("¿Quiere Actualizar otro Administrador de Ventas?(Digite su opcion) \n1-Si 2-No");
                                agn = Console.ReadLine();
                                if (agn == "1")
                                {
                                    opt = true;
                                }
                                else if (agn == "2")
                                {
                                    opt = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                    Console.ResetColor();
                                    opt = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nNo es un ID valido");
                                Console.ResetColor();

                            }

                        }
                        Console.Clear();
                        break;
                    case "4":
                        opt = true;
                        while (opt == true)
                        {
                            Console.WriteLine("Digite el id de su Administrador de Ventas");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = ave.GetAdministrador(idEmpleado);
                            if (empleado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"El empleado a eliminar es:\n{empleado.Nombre} {empleado.Apellido} \nCC: {empleado.Cedula} \nCargo: {empleado.Cargo} \nSucursal: {empleado.Sucursal} \nUsuario:{empleado.Usuario} \nPassword:{empleado.Password}");
                                aco.DeleteComprador(idEmpleado);
                                Console.WriteLine("Se eliminó el Administrador de Ventas");
                                Console.ResetColor();
                                Console.WriteLine("\n¿Quiere eliminar otro Administrador de Ventas? (digite su opcion) 1-Si 2-No");
                                agn = Console.ReadLine();
                                if (agn == "1")
                                {
                                    opt = true;
                                }
                                else if (agn == "2")
                                {
                                    opt = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                    Console.ResetColor();
                                    opt = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nNo es un ID valido");
                                Console.ResetColor();

                            }
                        }
                        Console.Clear();
                        break;
                    case "0":
                        Console.WriteLine("La lista de empleados es:");
                        var lista = ave.GetAllAdministradores();
                        foreach (AdminVentas e in lista)
                        {
                            Console.WriteLine($"-> {e.Id} \t {e.Nombre} {e.Apellido}");
                        }

                        break;
                    case "#":
                        Console.WriteLine("Está Saliendo ..........\n\n\n");
                        main = false;
                        break;
                    default:
                        Console.WriteLine(opcion + " No es una opcion valida.\n\n\n");
                        Console.Clear();
                        break;
                }
            }
        }



        private static void CRUDControles()
        {
            bool main = true;
            while (main == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------ CRUD CONTROLES ------ \nMENÚ.................... \n1.\tAgregar Control\n2.\tBuscar Control\n3.\tActualizar Control\n4.\tEliminar Control\n0.\tLista de Administradores de Ventas\n#. \tSalir del programa \nDigite el numero de la accion que quiere realizar");
                Console.ResetColor();
                string opcion = Console.ReadLine();
                bool opt = true;
                string agn = "";
                int cont;
                switch (opcion)
                {
                    case "1":
                        opt = true;
                        while (opt == true)
                        {
                            Control empleado = new Control();
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Nombre del Control");
                                empleado.Nombre = Console.ReadLine();
                                if (empleado.Nombre != "" && empleado.Nombre != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Nombre");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Fabricante del Control");
                                empleado.Fabricante = Console.ReadLine();
                                if (empleado.Fabricante != "" && empleado.Fabricante != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Fabricante");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Version del Control");
                                empleado.Version = Console.ReadLine();
                                if (empleado.Version != "" && empleado.Version != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Version");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite la Costo del Control");
                                var costo = Console.ReadLine();
                                if (costo != "" && costo != " ")
                                {
                                    empleado.Costo = Convert.ToDouble(costo);
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Costo");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite el Precio del Control");
                                var precio = Console.ReadLine();
                                if (precio != "" && precio != " ")
                                {
                                    empleado.Precio = Convert.ToDouble(precio);
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener una Precio");
                                    Console.ResetColor();
                                }
                            }
                            cont = 0;
                            while (cont < 1)
                            {

                                Console.WriteLine("Digite la Compatibilidad");
                                empleado.Compatibilidad = Console.ReadLine();
                                if (empleado.Compatibilidad != "" && empleado.Compatibilidad != " ")
                                {
                                    cont = 1;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Error.WriteLine("Ojó debe tener un Compatibilidad");
                                    Console.ResetColor();
                                }
                            }

                            var info = ctr.AddControl(empleado);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Se Creó el empleado {info.Nombre} {info.Version}");
                            Console.ResetColor();

                            Console.WriteLine("¿Quiere añadir otro Control?(Digite su opcion) \n1-Si 2-No");
                            agn = Console.ReadLine();
                            if (agn == "1")
                            {
                                opt = true;
                            }
                            else if (agn == "2")
                            {
                                opt = false;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                Console.ResetColor();
                                opt = false;
                            }
                        }
                        Console.Clear();
                        break;
                    case "2":
                        opt = true;
                        while (opt == true)
                        {
                            Console.WriteLine("Digite el id de su Control");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = ctr.GetControl(idEmpleado);
                            if (empleado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Su control es:\n{empleado.Nombre} \nVersion: {empleado.Version} \nFabricante: {empleado.Fabricante} \nCosto: {empleado.Costo} \nPrecio: {empleado.Precio} \nCompatibilidad:{empleado.Compatibilidad}");
                                Console.ResetColor();
                                Console.WriteLine("¿Quiere buscar otro Control?(Digite su opcion) \n1-Si 2-No");
                                agn = Console.ReadLine();
                                if (agn == "1")
                                {
                                    opt = true;
                                }
                                else if (agn == "2")
                                {
                                    opt = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                    Console.ResetColor();
                                    opt = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nNo es un ID valido");
                                Console.ResetColor();
                            }

                        }
                        Console.Clear();
                        break;
                    case "3":
                        opt = true;
                        while (opt == true)
                        {
                            Console.WriteLine("Digite el id de su Control");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = ctr.GetControl(idEmpleado);
                            if (empleado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"El Control a modificar es:\n{empleado.Nombre} \nVersion: {empleado.Version} \nFabricante: {empleado.Fabricante} \nCosto: {empleado.Costo} \nPrecio: {empleado.Precio} \nCompatibilidad:{empleado.Compatibilidad}");
                                Console.ResetColor();
                                Console.WriteLine("Ahora digite los datos que va a cambiar, si no va a cambiar alguno puede dejarlo vacío");
                                Control employ = new Control();
                                var atr = "";
                                Console.WriteLine("Digite el Nombre del Control");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Nombre = atr;
                                    Console.WriteLine(atr.GetType());
                                }
                                else { employ.Nombre = empleado.Nombre; }
                                Console.WriteLine("Digite el Version del Control");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Version = atr;
                                }
                                else { employ.Version = empleado.Version; }
                                Console.WriteLine("Digite la Fabricante del Control");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Fabricante = atr;
                                }
                                else { employ.Fabricante = empleado.Fabricante; }
                                Console.WriteLine("Digite la Costo del Control");
                                
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Costo = Convert.ToDouble(atr);
                                }
                                else { employ.Costo = empleado.Costo; }
                                Console.WriteLine("Digite el Precio del Control");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Precio = Convert.ToDouble(atr);
                                }
                                else { employ.Precio = empleado.Precio; }
                                Console.WriteLine("Digite la Compatibilidad del Control");
                                atr = Console.ReadLine();
                                if ((atr != "") && (atr != " "))
                                {
                                    employ.Compatibilidad = atr;
                                }
                                else { employ.Compatibilidad = empleado.Compatibilidad; }
                                var change = ctr.UpdateControl(idEmpleado, employ);
                                Console.WriteLine($"El empleado actualizado es:\n{empleado.Nombre} \nVersion: {empleado.Version} \nFabricante: {empleado.Fabricante} \nCosto: {empleado.Costo} \nPrecio: {empleado.Precio} \nCompatibilidad:{empleado.Compatibilidad}");
                                Console.WriteLine("¿Quiere Actualizar otro Control?(Digite su opcion) \n1-Si 2-No");
                                agn = Console.ReadLine();
                                if (agn == "1")
                                {
                                    opt = true;
                                }
                                else if (agn == "2")
                                {
                                    opt = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                    Console.ResetColor();
                                    opt = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nNo es un ID valido");
                                Console.ResetColor();

                            }

                        }
                        Console.Clear();
                        break;
                    case "4":
                        opt = true;
                        while (opt == true)
                        {
                            Console.WriteLine("Digite el id de su Control");
                            var idEmpleado = Int32.Parse(Console.ReadLine());
                            var empleado = ctr.GetControl(idEmpleado);
                            if (empleado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"El empleado a eliminar es:\n{empleado.Nombre} \nVersion: {empleado.Version} \nFabricante: {empleado.Fabricante} \nCosto: {empleado.Costo} \nPrecio: {empleado.Precio} \nCompatibilidad:{empleado.Compatibilidad}");
                                ctr.DeleteControl(idEmpleado);
                                Console.WriteLine("Se eliminó el Control");
                                Console.ResetColor();
                                Console.WriteLine("\n¿Quiere eliminar otro Control? (digite su opcion) 1-Si 2-No");
                                agn = Console.ReadLine();
                                if (agn == "1")
                                {
                                    opt = true;
                                }
                                else if (agn == "2")
                                {
                                    opt = false;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(agn + "\tNo es una opcion valida \nRegresando al menu principal...\n\n\n");
                                    Console.ResetColor();
                                    opt = false;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nNo es un ID valido");
                                Console.ResetColor();

                            }
                        }
                        Console.Clear();
                        break;
                    case "0":
                        Console.WriteLine("La lista de empleados es:");
                        var lista = ctr.GetAllControles();
                        foreach (Control e in lista)
                        {
                            Console.WriteLine($"-> {e.Id} \t {e.Nombre} {e.Version}");
                        }

                        break;
                    case "#":
                        Console.WriteLine("Está Saliendo ..........\n\n\n");
                        main = false;
                        break;
                    default:
                        Console.WriteLine(opcion + " No es una opcion valida.\n\n\n");
                        Console.Clear();
                        break;
                }
            }
        }

    }
}
