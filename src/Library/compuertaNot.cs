using System.Collections.Generic;
namespace Library;
/// <summary>
/// clase de la compuerta not
/// </summary>
public class compuertaNot : compuertas
{
    public compuertaNot(string nombre) : base(nombre)
    {  
    }
    /// <summary>
    /// método para devolver el valor de la compuerta not
    /// </summary>
    /// <returns></returns>
    public override int Calculate()
    {
        if (Inputs.Count != 2)
        {
            throw new ExceptionsQuantity("La compuerta no tiene 2 entradas");
        }
        int valor = 0;
        foreach (var i in Inputs)
        {   
            if (i.Value.Calculate() == 1)
            {
                valor = 0;
            }
            else if (i.Value.Calculate() == 0)
            {
                valor = 1;
            }
        }
        return valor;
    }
}