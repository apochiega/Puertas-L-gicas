namespace Library;
/// <summary>
/// interfaz para las compuertas
/// </summary>
public interface IGate
{
    /// <summary>
    /// método para agregar inputs
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    public void AddInput (string name, IInput value);

/// <summary>
/// método para devovler el valor de la compuerta
/// </summary>
/// <returns></returns>
    public int Calculate ();


}