//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Library;

/// <summary>
/// Programa principal
/// </summary>
public class Program
{
    
    public static void Main(string[] args)
    {
        compuertaAnd AND = new compuertaAnd("AND-1");
        IInput FirstValue  = new LogicInput(1);
        IInput SecondValue  = new LogicInput(1);
        AND.AddInput("A", FirstValue);
        AND.AddInput("B", SecondValue);



        compuertaOr OR = new compuertaOr("OR-2");
        IInput ThirdValue = new LogicInput(0);
        OR.AddInput("C", ThirdValue);
        OR.AddInput(AND.Name, AND);



        compuertaNot NOT = new compuertaNot("NOT-3");
        NOT.AddInput(OR.Name, OR);
        
        Console.WriteLine(NOT.Calculate());
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine("Valor ingresado inválido");
    }

    catch (CantidadDeEntradasExcepcion)
        {
            Console.WriteLine("Cantidad de entradas inválidas");
        }
    
}