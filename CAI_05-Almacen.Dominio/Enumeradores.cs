using System;
namespace CAI_05Almacen.Dominio
{
    /// <summary>
    /// Unidades y decenas quedan para tipo de Producto
    /// Centenas y unidades de mil para categoría de producto
    /// Unidades de millar y superior para Familias
    /// De este modo quedan 100 tipos de elemento para cada grupo
    /// </summary>
    public enum FamiliaProducto
    {
        Carnes = 10000,
        Lácteos = 20000,
        Almacén = 30000,
        Bebidas = 40000,
        Limpieza = 50000
    }
    /// <summary>
    /// Unidades y decenas quedan para tipo de Producto
    /// Centenas y unidades de mil para categoría de producto
    /// Unidades de millar y superior para Familias
    /// De este modo quedan 100 tipos de elemento para cada grupo
    /// </summary>
    public enum CategoriaProducto
    {
        //Categorías dentro de carnes, que empiezan en 10000
        CarneRoja = 10100,
        CarneBlanca = 10200,
        Pescado = 10300,
        //Categorías dentro de lácteos, que empiezan en 20000
        Leche = 20100,
        Yogurth = 20200,
        Queso = 20300,
        //Categorías dentro de almacén, que empiezan en 30000
        GalletitasDulces = 30100,
        GalletitasSaladas = 30200,
        Embutidos, 
    }
    /// <summary>
    /// Unidades y decenas quedan para tipo de Producto
    /// Centenas y unidades de mil para categoría de producto
    /// Unidades de millar y superior para Familias
    /// De este modo quedan 100 tipos de elemento para cada grupo
    /// </summary>
    public enum TipoProducto
    {
        //Tipos dentro de Carnes Rojas
        CarnePicada = 10100,
        RoasBeef = 10101,
        Asado = 10102,
        //Tipos dentro de Carnes Blancas
        Pollo = 10201,

    }
}
