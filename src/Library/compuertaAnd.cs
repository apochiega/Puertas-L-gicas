using System.Collections.Generic;
namespace Library;
public class compuertaAnd : compuertas
{
    public compuertaAnd (string name) : base(name)
    {
    }
    public override int Calculate()
    {

        int value = 1;
        foreach (IInput input in Inputs.Values)
        {
            value = value * input.Calculate();
        }
        return value;
    }
}