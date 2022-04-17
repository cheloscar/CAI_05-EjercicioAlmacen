using System;
namespace CAI_05Almacen.Dominio
{
    public abstract class Producto
    {
        #region Variables
        uint _codigoProducto;
        string _marca;
        string _descripcion;
        double _tamaño;
        int _unidadMedida;
        int _tipoEnvase;
        int _familiaProducto;
        int _categoriaProducto;
        int _tipoProducto;
        uint _stockActual;
        uint _puntoReposicion;
        #endregion

        #region Propiedades
        public uint CodigoProducto { get => _codigoProducto; set => _codigoProducto = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Tamaño { get => _tamaño; set => _tamaño = value; }
        public int UnidadMedida { get => _unidadMedida; set => _unidadMedida = value; }
        public int TipoEnvase { get => _tipoEnvase; set => _tipoEnvase = value; }
        public int FamiliaProducto { get => _familiaProducto; set => _familiaProducto = value; }
        public int CategoriaProducto { get => _categoriaProducto; set => _categoriaProducto = value; }
        public int TipoProducto { get => _tipoProducto; set => _tipoProducto = value; }
        public uint StockActual { get => _stockActual; set => _stockActual = value; }
        public uint PuntoReposicion { get => _puntoReposicion; set => _puntoReposicion = value; }
        #endregion

        #region Constructores
        public Producto(uint codigoProducto, string marca, string descripcion, double tamaño, int unidadMedida, int tipoEnvase, int familiaProducto, int categoriaProducto, int tipoProducto, uint stockActual, uint puntoReposicion)
        {
            _codigoProducto = codigoProducto;
            _marca = marca;
            _descripcion = descripcion;
            _tamaño = tamaño;
            _unidadMedida = unidadMedida;
            _tipoEnvase = tipoEnvase;
            _familiaProducto = familiaProducto;
            _categoriaProducto = categoriaProducto;
            _tipoProducto = tipoProducto;
            _stockActual = stockActual;
            _puntoReposicion = puntoReposicion;
        }
        public Producto(Producto producto)
        {
            _codigoProducto = producto.CodigoProducto;
            _marca = producto.Marca;
            _descripcion = producto.Descripcion;
            _tamaño = producto.Tamaño;
            _unidadMedida = producto.UnidadMedida;
            _tipoEnvase = producto.TipoEnvase;
            _familiaProducto = producto.FamiliaProducto;
            _categoriaProducto = producto.CategoriaProducto;
            _tipoProducto = producto.TipoProducto;
            _stockActual = producto.StockActual;
            _puntoReposicion = producto.PuntoReposicion;
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return "Producto";
        }
        public bool Comprar()
        {
            if (_stockActual <= _puntoReposicion) { return true; }
            else { return false; }
        }
        public void AgregarStock(uint cantidad)
        {
            _stockActual += cantidad;
        }
        public void QuitarStock(uint cantidad)
        {
            _stockActual -= cantidad;
                throw new ImposibleQuitarEstaCantidadException();
        }
        #endregion
    }
}
