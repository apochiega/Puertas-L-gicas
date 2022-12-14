namespace Library;
/// <summary>
/// clase para el input de la compuerta
/// </summary>
public class LogicInput : IInput
{
    /// <summary>
    /// aca nos da el valor de la compuerta
    /// </summary>
    /// <param name="Value"></param>
    public LogicInput(int Value)
    {
        this.Value=Value;

    }
    /// <summary>
    /// valor de la compuerta
    /// </summary>
    /// <value></value>
    public int Value {get ; set;}

/// <summary>
/// método para calcular el valor de la compuerta
/// </summary>
/// <returns></returns>
    public int Calculate ()
    {

        return this.Value;
    }

    


}