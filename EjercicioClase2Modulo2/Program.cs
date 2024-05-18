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
            Console.WriteLine("EJERCICIO 1");
            var lstNumeros = new List<int>() { 25,10,99,105, 1, 84, 22};
            var mayor = lstNumeros.Max();
            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("----------------------------------------------------");
            #endregion

            #region Ejercicio2

            //Ordenar los nombres alfabeticamente
            Console.WriteLine("EJERCICIO 2");
            var lstNombres = new List<string>() { "Ana", "Alejandro", "Alexis", "Pablo", "Carlos", "Anibal", "Carla", "Susana" };
            var nombresOrdenados = lstNombres.OrderBy(nombre => nombre).ToList();
            Console.WriteLine("Nombres ordenados Alfabeticamente: ");
            nombresOrdenados.ForEach(numero => Console.Write(numero +","));
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            #endregion

            #region Ejercicio3
            // Utilizando la variable "lstClientes" filtrar los clientes que tengan vip = true e imprimirlo por consola
            Console.WriteLine("EJERCICIO 3");
            var clientesVip = lstClientes.Where(cliente => cliente.Vip).ToList();
            clientesVip.ForEach(clienteVip => Console.WriteLine("Cliente Vip: " + clienteVip));
            Console.WriteLine("----------------------------------------------------");
            #endregion

            #region Ejercicio4 
            //Utilizando la variable "lstClientes" crear una nueva lista donde solo se encuentren los nombres de los clientes e imprimir los nombres
            Console.WriteLine("EJERCICIO 4");
            List<string> nombreClientes = lstClientes.Select(cliente => cliente.Nombre).ToList();
            Console.WriteLine("Nombres de los clientes: ");
            nombreClientes.ForEach(nombre => Console.Write(nombre +","));
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            #endregion

            #region Ejercicio5
            //Apartir de la variable "lstClientes" crear una lista que contenga todos los datos pero  modificando los siguientes campos:
            // Nombre tiene que guardarse en mayusculas
            // Apellido tiene que guardarse en mayusculas
            // Vip => se debe evaluar el bool y si es true se debe asignar el texto "Premium" y si es false "Normal"
            Console.WriteLine("EJERCICIO 5");
            List<Clientes> clientes = lstClientes.Select(cliente => new Clientes(cliente.Nombre.ToUpper(), cliente.Apellido.ToUpper(), cliente.CodCliente ,cliente.Vip)).ToList();
            clientes.ForEach(cliente => Console.WriteLine(cliente + cliente.verTipoCliente(cliente.Vip)));
            #endregion
        }
    }
}