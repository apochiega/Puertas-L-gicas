using System.Collections.Generic;
namespace Library;
public class compuertaNot : compuertas
{
    public compuertaNot(string nombre) : base(nombre)
    {  
    }
    public override int Calculate()
    {
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