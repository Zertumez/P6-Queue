using System;

namespace P6_Queue
{
    class MenuInteractivo
    {
        static void Main(string[] args)
        {
            QueueClientes filaTienda = new QueueClientes();

            // Se crearon clientes de muestra, pero se pueden remover y no afecta en la funcionalidad del programa.
            filaTienda.Enqueue("Miguel", "Jugo");
            filaTienda.Enqueue("Carlos", "Soda");
            filaTienda.Enqueue("Alejandra", "Gelatina");

            string opcion = "";
            while (opcion != "9")
            {
                opcion = "";
                while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "9")
                {
                    Console.WriteLine("1) Formarse (Agregar nuevo cliente en la fila)");
                    Console.WriteLine("2) Atender (Mostrar en consola la información del cliente que sigue)");
                    Console.WriteLine("3) ¿Quién sigue?");
                    Console.WriteLine("4) ¿Cuántos clientes están formados?");
                    Console.WriteLine("5) ¿Qué va a comprar cada cliente formado?");
                    Console.WriteLine("6) ¿Cuántos clientes en total se han atendido?");
                    Console.WriteLine("9) Salir");

                    Console.WriteLine("Por favor selecciona una opción:");
                    opcion = Console.ReadLine();

                    if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "9")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("La opción seleccionada no es correcta.");
                        Console.WriteLine("");
                    }

                }
                if (opcion == "1")
                {
                    Console.WriteLine("Escribe el nombre del cliente:");
                    string nombreCliente = Console.ReadLine();
                    Console.WriteLine("Escribe el producto que el cliente va a comprar:");
                    string productoDelCliente = Console.ReadLine();
                    filaTienda.Enqueue(nombreCliente, productoDelCliente);

                }
                else if (opcion == "2")
                {
                    if (filaTienda.CountClientesFormados() == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No se pueden eliminar personas de la fila ya que no hay alguna.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Cliente siguienteCliente = filaTienda.Dequeue();
                        string nombreCliente = siguienteCliente.nombre;
                        string productoDelCliente = siguienteCliente.productoAComprar;
                        Console.WriteLine("");
                        Console.WriteLine("El siguiente cliente que se va a atender es: " + nombreCliente + ", y va a comprar: " + productoDelCliente + ".");
                        Console.WriteLine("");
                    }
                }
                else if (opcion == "3")
                {
                    filaTienda.QuienSigue();
                }
                else if (opcion == "4")
                {
                    int clientesFormados = filaTienda.CountClientesFormados();
                    if (clientesFormados == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No hay personas formadas en la fila.");
                        Console.WriteLine("");
                    }
                    else if (clientesFormados == 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Actualmente hay: " + clientesFormados + " persona en la fila.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Actualmente hay: " + clientesFormados + " personas en la fila.");
                        Console.WriteLine("");
                    }
                }
                else if (opcion == "5")
                {
                    filaTienda.MostrarInfo();
                }
                else if (opcion == "6")
                {
                    filaTienda.CountClientesAtendidos();
                }
                else if (opcion == "9")
                {
                    Console.WriteLine("");
                    Console.Write("¡Hasta luego!");
                    Console.WriteLine("");
                }
                else
                {

                }
            }

        }
    }
}
