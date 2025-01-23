// Ejecutor de dotnet.Net  =   dotnet run --project MiProyectoCSharp/MiProyectoCSharp.csproj
// See https://aka.ms/new-console-template for more information
using System;

// dotnet run --project MyProyectCinema
namespace MyProyectCinema
{
    //public class Program
    //{
    //    static void Main()
    //    {
    //        // Crear una instancia de la clase Person usando el constructor
    //        Users_Normal u_n = new Users_Normal("Doe", "John", 30, new DateTime(1993, 1, 1), 12345678);
//
    //        // Imprimir los atributos
    //        Console.WriteLine($"Surname: {p.Surname()}");
    //        Console.WriteLine($"Name: {p.Name()}");
    //        Console.WriteLine($"Age: {p.Age()}");
    //        Console.WriteLine($"Birthdate: {p.Birthdate()}");
    //        Console.WriteLine($"DNI: {p.Dni()}");
//
//
    //    }
    //}


    public class Login_in
    {
        public class Register
        {
            if()
            {
            }
        }
        public class LoginIn
        {
        }
}











public class Users_Normal
{
    private string surname { set; get; }
    private string name { set; get; }
    private int age { set; get; }
    private DateTime birthdate { set; get; }
    private int dni { set; get; }

    // Constructor vacío para permitir instancias sin parámetros
    // Por que el constructor vacio si no estoy instanciando abajo ya?
    public Users_Normal() { }

    // Constructor con parámetros

    // Métodos para acceder a los atributos
    public string Surname() => surname;
    public string Name() => name;
    public int Age() => age;
    public DateTime Birthdate() => birthdate;
    public int Dni() => dni;
}
}









