using System.Collections.Generic;
namespace Library;
/// <summary>
/// clase abstracta de las compuertas
/// </summary>
public abstract class compuertas : IInput, IGate

{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    public compuertas(string name)
    

    {   

        /// <summary>
        /// Excepcion en caso de que el nombre esté vacío
        /// </summary>
        /// <returns></returns>
        if (string.IsNullOrEmpty(name))
        {
            throw new System.ArgumentNullException();
        }
        else
        {
        this.Name = name;
        
        }
    }

/// <summary>
/// 
/// </summary>
/// <value></value>
    public string Name { get; set; }

    /// <summary>
    /// se agrega un diccionario para las inputs
    /// </summary>
    /// <value></value>
    public Dictionary<string, IInput> Inputs { get; set; }
   /// <summary>
   /// método para agregar entradas 
   /// </summary>
   /// <param name="name"></param>
   /// <param name="value"></param>
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
    
/// <summary>
/// método para devolver el valor
/// </summary>
/// <returns></returns>
    public abstract int Calculate ();
}