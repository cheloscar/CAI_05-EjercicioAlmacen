using System;
namespace CAI_05Almacen.Dominio
{
    public class ImposibleQuitarEstaCantidadException : Exception
    {
        public ImposibleQuitarEstaCantidadException() : base ("No se puede quitar más del stock disponible.") 
        {
        }
    }
}
