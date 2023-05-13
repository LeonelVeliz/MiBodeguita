using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiBodeguita.Model;
namespace MiBodeguita.BL
{
    /*
     CRUD
     */
    public interface IProductoBL
    {
        RespuestaModel Guardar(ProductoModel objModel);
        List<ProductoModel> Mostrar();
        RespuestaModel Editar(ProductoModel objModel);
        RespuestaModel Eliminar(int ID);
        ProductoModel getProducto(int ID);
        ProductoModel getProducto(string Nombre); // opcional
    }
}
