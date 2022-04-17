using System;
namespace CAI_05Almacen.Dominio
{
    public class ProductoComestible : Producto
    {
        #region Variables
        string _ingredientes;
        double _valorEnergetico;
        double _sodio;
        double _grasasSaturadas;

        #endregion

        #region Propiedades
        public string Ingredientes { get => _ingredientes; set => _ingredientes = value; }

        #endregion

        #region Constructores
        public ProductoComestible(uint codigoProducto, string marca, string descripcion, double tamaño, int unidadMedida, int tipoEnvase, int familiaProducto, int categoriaProducto, int tipoProducto, uint stockActual, uint puntoReposicion, string ingredientes,double valorEnergetico, double sodio, double grasasSaturadas)
            : base(codigoProducto, marca, descripcion, tamaño, unidadMedida, tipoEnvase, familiaProducto, categoriaProducto, tipoProducto, stockActual, puntoReposicion)
        {
            _ingredientes = ingredientes;
            _valorEnergetico = valorEnergetico;
            _sodio = sodio;
            _grasasSaturadas = grasasSaturadas;
        }
        public ProductoComestible(ProductoComestible productoComestible)
            : base(productoComestible.CodigoProducto, productoComestible.Marca, productoComestible.Descripcion, productoComestible.Tamaño, productoComestible.UnidadMedida, productoComestible.TipoEnvase, productoComestible.FamiliaProducto, productoComestible.CategoriaProducto, productoComestible.TipoProducto, productoComestible.StockActual, productoComestible.PuntoReposicion)
        {
            _ingredientes = productoComestible.Ingredientes;
            _valorEnergetico = productoComestible.ValorEnergetico();
            _sodio = productoComestible.Sodio();
            _grasasSaturadas = productoComestible.GrasasSaturadas();
        }

        #endregion

        #region Métodos
        public override string ToString()
        {
            return "Producto Comestible";
        }
        public void ValorEnergetico(double valor)
        {
            if (valor >= 0) { _valorEnergetico = valor; }
            else { throw new NoSeAceptanValoresNegativosException(); }
        }
        public double ValorEnergetico()
        {
            return _valorEnergetico;
        }
        public void Sodio(double valor)
        {
            if (valor >= 0) { _sodio = valor; }
            else { throw new NoSeAceptanValoresNegativosException(); }
        }
        public double Sodio()
        {
            return _sodio;
        }
        public void GrasasSaturadas(double valor)
        {
            if (valor >= 0) { _grasasSaturadas = valor; }
            else { throw new NoSeAceptanValoresNegativosException(); }
        }
        public double GrasasSaturadas()
        {
            return _grasasSaturadas;
        }
        public bool AltoEnCalorias()
        {
            if (_valorEnergetico > 100) { return true; }
            else { return false; }
        }
        public bool AltoEnSodio()
        {
            if (_sodio > 100) { return true; }
            else { return false; }
        }
        public bool AltoEnGrasas()
        {
            if (_grasasSaturadas > 100) { return true; }
            else { return false; }
        }
        #endregion
    }
}
