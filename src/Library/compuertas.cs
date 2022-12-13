using System.Collections.Generic;
namespace Library;

public abstract class compuertas : IInput, IGate

{
    public compuertas(string name)
    {
        this.Name = name;
        this.Inputs = new Dictionary<string, IInput>();
    }
    public string Name { get; set; }
    public Dictionary<string, IInput> Inputs { get; set; }
   
    public void AddInput(string name, IInput value)
    {
        
        if (!Inputs.ContainsKey(name))
        {
            Inputs.Add(name, value);
        }
        else 
        {
            Inputs[name] = value;             
        }        
    }
    

    public abstract int Calculate ();
}