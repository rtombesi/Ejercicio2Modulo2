using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static EjercicioClase2Modulo2.Program;

namespace EjercicioClase2Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando LINQ resolver las siguientes consignas:

            //Carga de datos
            
            var lstClientes = new List<Clientes>()
            {
                new Clientes() { Apellido = "Jara", Nombre = "Alejandro" ,CodCliente = 123 , Vip = true},
                new Clientes() { Apellido = "Mossier", Nombre = "Fernando" ,CodCliente = 345 , Vip = false},
                new Clientes() { Apellido = "Bustos", Nombre = "Andres" ,CodCliente = 567 , Vip = true},
                new Clientes() { Apellido = "Dalpiaz", Nombre = "Carla" ,CodCliente = 789 , Vip = true},
                new Clientes() { Apellido = "Miranda", Nombre = "Micaela" ,CodCliente = 112 , Vip = false},
                new Clientes() { Apellido = "De Castillo", Nombre = "Andrea" ,CodCliente = 223 , Vip = false},
            };


            #region Ejercicio1

            // Detectar cual es el numero mas grande e imprimirlo por consola

            //var lstNumeros = new List<int>() { 25,10,99,105, 1, 84, 22};
            //var numeroMayor = lstNumeros.Max(x => x);
            //Console.WriteLine($"El Número Mayor es:{numeroMayor}");

            #endregion

            #region Ejercicio2

            //Ordenar los nombres alfabeticamente
            //var lstNombres = new List<string>() { "Ana", "Alejandro", "Alexis", "Pablo", "Carlos", "Anibal", "Carla", "Susana" };
            //var ordAlfabetica = lstNombres.OrderBy(x => x);
            //Console.WriteLine("La lista de nombres ordenada alfabéticamente es:");
            //foreach ( var nomb in ordAlfabetica )
            //{
            //    Console.WriteLine(nomb);
            //}
            #endregion

            #region Ejercicio3
            // Utilizando la variable "lstClientes" filtrar los clientes que tengan vip = true e imprimirlo por consola
            //lstClientes.All(persona => persona.Vip=true);
            //foreach( var nomb in lstClientes )
            //{
            //   Console.WriteLine($"Apellido:{nomb.Apellido} Nombre:{nomb.Nombre} Codigo:{nomb.CodCliente} Vip:{nomb.Vip}");
            //}
            #endregion
            #region Ejercicio4 

            //Utilizando la variable "lstClientes" crear una nueva lista donde solo se encuentren los nombres de los clientes e imprimir los nombres
            //var nomClientes = lstClientes.Select(persona => persona.Nombre).ToList();
            //Console.WriteLine("Nombre de las Personas:");
            //foreach (var persona in nomClientes)
            //{
            //    Console.WriteLine($"{persona}");
            //}
            #endregion
            #region Ejercicio5
            //Apartir de la variable "lstClientes" crear una lista que contenga todos los datos pero  modificando los siguientes campos:
            // Nombre tiene que guardarse en mayusculas
            // Apellido tiene que guardarse en mayusculas
            // Vip => se debe evaluar el bool y si es true se debe asignar el texto "Premium" y si es false "Normal"

            var actualizarClientes = new List<ClienteAct>() { };
         
            lstClientes.ForEach(cli =>
            {
                string vip;
                    var nombre = cli.Nombre.ToUpper();
                    var apellido =cli.Apellido.ToUpper();
                    var codigo = cli.CodCliente;
                if (cli.Vip)
                {
                    vip = "Premium";
                }
                else
                {
                    vip = "Normal";
                }
                    actualizarClientes.Add( new ClienteAct() { NombreAct = nombre, ApellidoAct = apellido, CodClienteAct = codigo,VipAct=vip});
             
            }
            );

            actualizarClientes.ForEach(cliAct => Console.WriteLine($"Nombre: {cliAct.NombreAct} Apellido: {cliAct.ApellidoAct} Código: {cliAct.CodClienteAct} Nivel: {cliAct.VipAct}"));
            #endregion
        }
        public class ClienteAct 
        {
            public string NombreAct { get; set; }
            public string ApellidoAct {  get; set; }
            public int CodClienteAct {  get; set; }
            public string VipAct { get; set; }
        
        }
    }
}