using System.Collections.Generic;
namespace Library;
public class compuertaOr : compuertas
{
    public compuertaOr(string nombre) : base(nombre)
    { 
    }
    
    public override int Calculate()
    {
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