using System;
namespace CAI_05Almacen.Dominio
{
    public class ProductoLimpieza : Producto
    {
        #region Variables
        string _materiales;
        
        #endregion

        #region Propiedades
        public string Materiales { get => _materiales; set => _materiales = value; }

        #endregion

        #region Constructores
        public ProductoLimpieza(uint codigoProducto, string marca, string descripcion, double tamaño, int unidadMedida, int tipoEnvase, int familiaProducto, int categoriaProducto, int tipoProducto, uint stockActual, uint puntoReposicion, string materiales)
            : base(codigoProducto, marca, descripcion, tamaño, unidadMedida, tipoEnvase, familiaProducto, categoriaProducto, tipoProducto, stockActual, puntoReposicion)
        {
            _materiales = materiales;
        }
        public ProductoLimpieza(ProductoLimpieza productoLimpieza)
            : base(productoLimpieza.CodigoProducto, productoLimpieza.Marca, productoLimpieza.Descripcion, productoLimpieza.Tamaño, productoLimpieza.UnidadMedida, productoLimpieza.TipoEnvase, productoLimpieza.FamiliaProducto, productoLimpieza.CategoriaProducto, productoLimpieza.TipoProducto, productoLimpieza.StockActual, productoLimpieza.PuntoReposicion)
        {
            _materiales = productoLimpieza.Materiales;
        }

        #endregion

        #region Métodos
        public override string ToString()
        {
            return "Producto Limpieza";
        }
        #endregion
    }
}
