using System;
namespace CAI_05Almacen.Dominio
{
    public class ImposibleQuitarEstaCantidadException : Exception
    {
        public ImposibleQuitarEstaCantidadException() : base("No se puede quitar más del stock disponible.")
        {
        }
    }
    public class NoSeAceptanValoresNegativosException : Exception
    {
        public NoSeAceptanValoresNegativosException() : base("No se puede ingresar un valor negativo en esta propiedad.")
        {
        }
    }
}
