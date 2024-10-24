using System;

public struct Producto
{
    public string Nombre;
    public decimal Precio;
    public int Stock;

    public Producto(string nombre, decimal precio, int stock)
    {
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }
}

public class Nodo
{
    public Producto Producto;
    public Nodo Siguiente;

    public Nodo(Producto producto)
    {
        Producto = producto;
        Siguiente = null;
    }
}

public class ListaProductos
{
    private Nodo cabeza;

    public void AgregarProducto(Producto producto)
    {
        Nodo nuevoNodo = new Nodo(producto);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
        Console.WriteLine($"Producto '{producto.Nombre}' agregado al inventario.");
    }


    public void VerProductos()
    {
        Nodo actual = cabeza;
        if (actual == null)
        {
            Console.WriteLine("No hay productos en el inventario.");
            return;
        }

        int index = 1;
        while (actual != null)
        {
            Console.WriteLine($"{index++}. {actual.Producto.Nombre} - ${actual.Producto.Precio:F2} (Stock: {actual.Producto.Stock})");
            actual = actual.Siguiente;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaProductos listaProductos = new ListaProductos();
        string opcion;
        
        do
        {
            MostrarMenu();
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    listaProductos.VerProductos();
                    break;
                case "2":
                    Console.Write("Ingrese el nombre del producto: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese el precio del producto: ");
                    decimal precio = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Ingrese la cantidad del producto: ");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    listaProductos.AgregarProducto(new Producto(nombre, precio, stock));
                    break;
                case "3":
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (opcion != "3");
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\nMenú:");
        Console.WriteLine("1. Ver inventario");
        Console.WriteLine("2. comprar producto");
        Console.WriteLine("3. Salir");
        Console.Write("Seleccione una opción: ");
    }
}

