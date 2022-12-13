namespace Library;

public class LogicInput : IInput
{
    public LogicInput(int Value)
    {
        this.Value=Value;

    }
    public int Value {get ; set;}

    public int Calculate ()
    {

        return this.Value;
    }

    


}