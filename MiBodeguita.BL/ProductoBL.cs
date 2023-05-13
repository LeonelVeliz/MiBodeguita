using System;
using System.Collections.Generic;
using System.IO; // leer o escribir un archivo
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiBodeguita.Model;

namespace MiBodeguita.BL
{
    // MiBodeguita.IUConsola -> bin -> Debug -> Producto.txt
    public class ProductoBL : IProductoBL
    {
        List<ProductoModel> mLista = new List<ProductoModel>();

        public RespuestaModel Guardar(ProductoModel objModel)
        {
            try
            {
                if (!ValidaProducto(objModel.ID)) {
                    return new RespuestaModel(objModel.ID, "ID Duplicado", true);
                }

                string Datos = objModel.ID + "," + objModel.Nombre + "," +
                    objModel.PVenta + "," + objModel.PCompra + "," + objModel.Stock +
                    "," + objModel.ID_Unidad;

                string RutaCompleta = "Producto.txt";
                StreamWriter Arch = new StreamWriter(RutaCompleta,true); //referencia Objeto tipo archivo
                Arch.WriteLine(Datos); //escribe los datos al archivo
                Arch.Close(); //cierra archivo

                return new RespuestaModel(objModel.ID, "Producto Archivado", false);
            }
            catch
            {
                return new RespuestaModel();
            }
        }

        private bool ValidaProducto(int ID) {
            StreamReader Arch = new StreamReader("Producto.txt"); //leer archivo
            string Linea = Arch.ReadLine(); //carga una Linea del archivo
            while (Linea != null)
            {
                string[] Arreglo;
                Arreglo = Linea.Split(',');  //almaceno la linea en arreglo pero lo separo x sus comas
                int IdLocal = Convert.ToInt32(Arreglo[0]);
                if (ID == IdLocal) {
                    Arch.Close();
                    return false;
                }

                Linea = Arch.ReadLine();
            }

            Arch.Close();

            return true;
        }
        
        public List<ProductoModel> Mostrar()
        {
            List<ProductoModel> mListaLocal = new List<ProductoModel>();

            string RutaCompleta = "Producto.txt";
            string Linea = "";

            StreamReader Arch = new StreamReader(RutaCompleta);
            Linea = Arch.ReadLine();
            while (Linea !=null) {
                //string Letra = Linea;
                ProductoModel objModel = new ProductoModel();
                string[] Arreglo;
                Arreglo = Linea.Split(',');
                objModel.ID = Convert.ToInt32(Arreglo[0]);
                objModel.Nombre = Arreglo[1];
                objModel.PVenta = Convert.ToDecimal(Arreglo[2]);
                objModel.PCompra = Convert.ToDecimal(Arreglo[3]);
                objModel.Stock = Convert.ToDecimal(Arreglo[4]);
                objModel.ID_Unidad = Convert.ToInt32(Arreglo[5]);

                mListaLocal.Add(objModel);

                Linea = Arch.ReadLine();
            }

            Arch.Close();
            return mListaLocal;
        }

        public RespuestaModel Editar(ProductoModel objModel)
        {
            throw new NotImplementedException();
        }

        public RespuestaModel Eliminar(int ID)
        {
            throw new NotImplementedException();
        }

        public ProductoModel getProducto(int ID)
        {
            throw new NotImplementedException();
        }

        public ProductoModel getProducto(string Nombre)
        {
            throw new NotImplementedException();
        }

        public RespuestaModel Guardar2(ProductoModel objModel)
        {
            try
            {
                if (mLista != null)
                {
                    objModel.ID = mLista.Count + 1;
                    mLista.Add(objModel);
                    return new RespuestaModel(objModel.ID, "Exito!!!", false);
                }
                return new RespuestaModel(0, "Producto No Guardado", true);
            }
            catch
            {
                return new RespuestaModel();
            }
        }


    }
}
