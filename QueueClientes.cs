using System;
using System.Collections.Generic;

namespace P6_Queue
{
    class QueueClientes
    {
        Queue<Cliente> filaTienda = new Queue<Cliente>();
        public int conteoClientesAtendidos = 0;

        // Formarse: Agregar un nuevo cliente a la fila
        public void Enqueue(string nombre, string productoAComprar)
        {
            this.filaTienda.Enqueue(new Cliente(nombre, productoAComprar));
        }


        // Atender: Mostrar en consola la información del cliente que sigue (ej. "John compra Coca-Cola") y quitarlo de la fila.
        public Cliente Dequeue()
        {
            if (this.filaTienda.Count == 0)
            {
                return null;
            }

            Cliente value = this.filaTienda.Dequeue();
            conteoClientesAtendidos = (conteoClientesAtendidos + 1);
            return value;
        }


        // ¿Cuántos clientes en total se han atendido?: Mostrar en consola cuántos clientes se han atendido hasta ahora. Los clientes que están "formados" no se consideran "atendidos".
        public void clientesAtendidos()
        {
            Console.WriteLine("");
            Console.WriteLine("Se han atendido a un total de: " + conteoClientesAtendidos + "clientes.");
            Console.WriteLine("");
        }


        // ¿Quién sigue?: Mostrar en consola el nombre del cliente que sigue (el siguiente que será atendido). Si no hay clientes en la fila, no mostrar nada o mostrar un mensaje indicando que la fila está vacía
        public void QuienSigue()
        {
            if (this.filaTienda.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("No hay personas en la fila.");
                Console.WriteLine("");
            }
            else
            {
                Cliente siguienteCliente = this.filaTienda.Peek();
                string nombreCliente = siguienteCliente.nombre;
                string productoDelCliente = siguienteCliente.productoAComprar;
                Console.WriteLine("");
                Console.WriteLine("La siguiente persona en la fila es: " + nombreCliente + ", y va a comprar: " + productoDelCliente + ".");
                Console.WriteLine("");
            }
        }


        // ¿Cuántos clientes están formados?: Mostrar en consola la cantidad de clientes que actualmente están "formados" en la fila
        public int CountClientesFormados()
        {
            int count = this.filaTienda.Count;
            return count;
        }


        // ¿Qué va a comprar cada cliente formado?: Mostrar en consola la información de todos los clientes "formados" y qué producto van a comprar
        public void MostrarInfo()
        {
            foreach (Cliente cliente in filaTienda)
            {
                Console.WriteLine("");
                Console.WriteLine("El cliente: " + cliente.nombre + ", va a comprar: " + cliente.productoAComprar + ".");
            }
            Console.WriteLine("");
        }


        // ¿Cuántos clientes en total se han atendido?: Mostrar en consola cuántos clientes se han atendido hasta ahora. Los clientes que están "formados" no se consideran "atendidos".
        public void CountClientesAtendidos()
        {
            if (conteoClientesAtendidos == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Ningún cliente ha sido atendido.");
                Console.WriteLine("");
            }
            else if (conteoClientesAtendidos == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Se ha atendido a un total de: " + conteoClientesAtendidos + " persona.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Se han atendido a un total de: " + conteoClientesAtendidos + " personas.");
                Console.WriteLine("");
            }
        }
    }
}