using System;
using System.Collections.Generic;

namespace P6_Queue
{
    class Cliente
    {
        // Crear una clase Cliente con 2 atributos: nombre (string) y producto a comprar (string)
        public string nombre;
        public string productoAComprar;

        public Cliente(string nombre, string productoAComprar)
        {
            this.nombre = nombre;
            this.productoAComprar = productoAComprar;
        }
    }
}