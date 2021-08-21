using System;

namespace practicando1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------BIENVENIDO SEÑOR----------");

            Digitar digitar = new Digitar();

            digitar.setInformacion("williams", 22, "teodoro martinez");
            Console.WriteLine($"Mi nombre es {digitar.getNombre()} y tengo {digitar.getEdad()} años y vivo en el barrio {digitar.getDireccion()}\n");
        }
    }

    class Digitar
    {
        private string nombre;
        byte edad;
        string direccion;

        public Digitar()
        {
            nombre = "eduardo";
            edad = 22;
        }

        public void setInformacion(string nombre, byte edad, string direccion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
        }

        public string getNombre() => nombre;
        public byte getEdad() => edad;
        public string getDireccion() => direccion;
    }
}
