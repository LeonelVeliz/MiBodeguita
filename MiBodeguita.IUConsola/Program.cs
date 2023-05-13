using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiBodeguita.Model;
using MiBodeguita.BL;

namespace MiBodeguita.IUConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Guardar();
                Mostrar();
                Console.WriteLine("\nPresione una tecla para salir...");
                Console.ReadKey();

                Console.Clear();
            }

            
            
        }

        static void Guardar() {
            ProductoModel objModel = new ProductoModel();
            Console.WriteLine("Nuevo Producto");
            Console.WriteLine("Ingrese ID");
            objModel.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Nombre");
            objModel.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese PVenta");
            objModel.PVenta = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese PCompra");
            objModel.PCompra = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese Stock");
            objModel.Stock = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese ID Unidad");
            objModel.ID_Unidad = Convert.ToInt32(Console.ReadLine());

            ProductoBL bl = new ProductoBL();
            RespuestaModel Rsta = bl.Guardar(objModel);
            Console.WriteLine(Rsta.Mensaje + " -> " + Rsta.ID);
        }

        static List<ProductoModel> GeneraProductos(int Cantidad) {
            List<ProductoModel> mLista = new List<ProductoModel>();

            for (int Index = 1; Index <= Cantidad; Index++) {
                ProductoModel objModel = new ProductoModel();
                objModel.ID = Index;
                objModel.Nombre = "Producto " + Index;
                objModel.PCompra = Index * 2;
                objModel.PVenta = Index * 3;
                objModel.Stock = Index * 5;
                objModel.ID_Unidad = (Index % 3) + 1;

                mLista.Add(objModel);
            }

            return mLista;
        }

        static void Mostrar() {
            ProductoBL bl = new ProductoBL();
            Console.WriteLine("\nLista de Productos");
            foreach (var item in bl.Mostrar()) {
                Console.WriteLine("ID : " + item.ID);
                Console.WriteLine("Nombre : " + item.Nombre);
                Console.WriteLine("PVenta : " + item.PVenta);
                Console.WriteLine("PCompra : " + item.PCompra);
                Console.WriteLine("Stock : " + item.Stock);
                Console.WriteLine("Unidad : " + Help.Variables.getUnidad(item.ID_Unidad));
                Console.WriteLine("------------------\n");
            }
        }
    }
}
