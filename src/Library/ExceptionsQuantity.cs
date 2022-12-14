using System;
using System.Collections.Generic;

namespace Library;

/// <summary>
/// Clase para la cantidad de excepciones
/// </summary>
public class ExceptionsQuantity : Exception
{
    /// <summary>
    /// constructor de la clase
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public ExceptionsQuantity(string message) : base(message)
    {
        
    }
}
