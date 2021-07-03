using System;



namespace UD9E1
{
    class Alumno
    {
        int edad;

        string nombre;
        public Alumno()
        {
            Console.WriteLine("Introduzca el nombre del alumno");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca la edad del alumno");
            string linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Edad:" + edad);
        }

        public void MayorEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine(nombre + " es mayor de edad.");
            }
            else
            {
                Console.WriteLine(nombre + " no es mayor de edad.");
            }
        }

        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.Mostrar();
            alumno1.MayorEdad();
            Console.ReadKey();
        }
    }
}
