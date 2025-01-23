///using System;
///
///// dotnet run --project MyProyectCinema
///namespace MyProyectCinema
///{
///    class Program
///    {
///        static void Main()
///        {
///            // Crear una clase Person con los siguientes atributos:
///            Person p = new Person(surname: "Garcia", name: "Juan", age: 25, birthdate: new DateTime(1998, 1, 1), dni: 12345678 );
///            
///            
///            
///            
///            
///            
///            //Apellido
///            //Nombre
///            //Edad
///            //Fecha de nacimiento
///            //DNI
///            // Imprimir los atributos
///            Console.WriteLine();
///        }
///    }
///    
///
///
///    public class Person
///    {
///        private string surname { set; get; }
///        private string name { set; get; }
///        private int age { set; get; }
///        private DateTime birthdate { set; get; }
///        private int dni { set; get; }
///
///        public Person(string surname, string name, int age, DateTime birthdate, int dni)
///        {
///            this.surname = surname;
///            this.name = name;
///            this.age = age;
///            this.birthdate = birthdate;
///            this.dni = dni;
///        }
///        public string Surname()
///        {
///            return surname;
///        }
///    }
///}