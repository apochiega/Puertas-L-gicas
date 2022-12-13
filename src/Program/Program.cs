//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Library;


public class Program
{
    
    public static void Main(string[] args)
    {
        compuertaAnd and1 = new compuertaAnd("AND-1");
        IInput primer_valor  = new LogicInput(1);
        IInput segundo_valor  = new LogicInput(1);
        and1.AddInput("A", primer_valor);
        and1.AddInput("B", segundo_valor);

        compuertaOr or2 = new compuertaOr("OR-2");
        IInput tercer_valor = new LogicInput(0);
        or2.AddInput("C", tercer_valor);
        or2.AddInput(and1.Name, and1);

        compuertaNot not3 = new compuertaNot("NOT-3");
        not3.AddInput(or2.Name, or2);
        
        Console.WriteLine(not3.Calculate());
    }
}