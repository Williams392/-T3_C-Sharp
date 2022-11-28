using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_T3
{
    internal class Mascota_Dueño
    {
        // Definir algunas Propiedades;
        public string nombre;
        public string direccion;
        public string telefono;
        public string DNI;
        public string Nombre_M;
        public string Raza { get; set; }
        public string edad;

        public Mascota_Dueño() { } // DEFINIENDO una funcion que no reciba ni un PARAMETRO

        public Mascota_Dueño(string nombre, string direccion, string DNI, string telefono, string Nombre_M, string Raza, string edad) //  ,string Raza, string edad
        {
            // Asignando los valores;
            this.nombre = nombre;
            this.direccion = direccion;
            this.DNI = DNI;
            this.telefono = telefono;
            this.Nombre_M = Nombre_M;
            this.Raza = Raza;
            this.edad = edad;
            // De esta manera tenemos nuestra CLASS -> Dueños construida;
        }

        // Una funcion Para mostrar los DATOS;
        public string[] getData()
        {
            string[] data = new string[7]; // Definiendo el vector de tipo STRINGque estamos declarando de 3 valores;
            data[0] = nombre;
            data[1] = direccion;
            data[2] = DNI;
            data[3] = telefono;
            data[4] = Nombre_M;
            data[5] = Raza;
            data[6] = edad;
            return data;
        }
    }
}
