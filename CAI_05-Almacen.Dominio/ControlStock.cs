using System;
using System.Collections.Generic;

namespace CAI_05Almacen.Dominio
{
    public class ControlStock
    {
        List<Producto> _stockCompleto = new List<Producto>();

        /// <summary>
        /// Se devuelve una lista con los productos que están por debajo del punto de reposición
        /// </summary>
        public List<Producto> ProductosParaReponer()
        {
            //Codigo
            List<Producto> _productosParaReponer = new List<Producto>();
            return _productosParaReponer;
        }

        /// <summary>
        /// Con este método se aumentará la cantidad de stock del producto indicado
        /// </summary>
        /// <param name="codigoProducto">Producto que se trabajará</param>
        /// <param name="cantidad">Cantidad de unidades a agregar</param>
        public void AumentarStockProducto(int codigoProducto, uint cantidad)
        {
            //Codigo
        }
        /// <summary>
        /// Con este método se disminuirá la cantidad de stock del producto indicado
        /// </summary>
        /// <param name="codigoProducto">Producto que se trabajará</param>
        /// <param name="cantidad">Cantidad de unidades a quitar</param>
        public void DisminuirStockProducto(int codigoProducto, uint cantidad)
        {
            //Codigo
        }
    }
}
