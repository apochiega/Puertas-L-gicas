using System.Collections.Generic;
namespace Library;
/// <summary>
/// clase de la compuerta and
/// </summary>
public class compuertaAnd : compuertas
{
    public compuertaAnd (string name) : base(name)
    {
    }
    /// <summary>
    /// método para devolver el valor de la compuerta
    /// </summary>
    /// <returns></returns>
    public override int Calculate()
    {
        if (Inputs.Count != 2)
        {
            throw new ExceptionsQuantity("La compuerta debe tener 2 entradas");
        }

        int value = 1;
        foreach (IInput input in Inputs.Values)
        {
            value = value * input.Calculate();
        }
        return value;
    }
}