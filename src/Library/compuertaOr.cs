using System.Collections.Generic;
namespace Library;
/// <summary>
/// clase de la compuerta or
/// </summary>
public class compuertaOr : compuertas
{
    public compuertaOr(string nombre) : base(nombre)
    { 
    }
    /// <summary>
    /// método para devolver el valor de la compuerta or
    /// </summary>
    /// <returns></returns>
    public override int Calculate()
    {
        if (Inputs.Count != 2)
        {
            throw new ExceptionsQuantity("La compuerta no tiene 2 entradas");
        }
        int valor = 0;
        foreach (var element in Inputs)
        {   
            if (element.Value.Calculate() == 1)
            {
                valor = 1;
            }
            
        }
        return 0;
    }
}