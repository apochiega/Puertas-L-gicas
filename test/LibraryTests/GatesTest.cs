using System;
using NUnit.Framework;
using Library;

namespace LibraryTests;


public class Tests
{
    LogicInput on = new LogicInput(1);
    LogicInput off = new LogicInput(0);

    
    [Test]
    public void TestCompuertaAnd()
    {        
        compuertaAnd AND = new compuertaAnd("AND-1");
        AND.AddInput("A", off);
        AND.AddInput("B", off);
        Assert.AreEqual(0, AND.Calculate());
        
    }
    
    [Test]
    public void TestCompuertaOr()
    {
        compuertaOr OR = new compuertaOr("OR-1");
        OR.AddInput("A", on);
        OR.AddInput("B", on);
        Assert.AreEqual(1, OR.Calculate());
              
    }
    
    [Test]
    public void TestCompuertaNot()
    {
        compuertaNot NOT = new compuertaNot("NOT-1");
        NOT.AddInput("A", off);
        Assert.AreEqual(1, NOT.Calculate());
        
    }
 
    [Test]
    public void CircuitTest()
    {
        compuertaAnd AND = new compuertaAnd("AND-1");
        AND.AddInput("A", off);
        AND.AddInput("B", off);
        Assert.AreEqual(0, AND.Calculate());

        compuertaOr OR = new compuertaOr("OR-2");
        OR.AddInput("C", on);
        OR.AddInput(AND.Name, AND);
        Assert.AreEqual(1, OR.Calculate());

        compuertaNot NOT = new compuertaNot("NOT-3");
        NOT.AddInput(OR.Name, OR);
        Assert.AreEqual(1, NOT.Calculate());
    }    
}