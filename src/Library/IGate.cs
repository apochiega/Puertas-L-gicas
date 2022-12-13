namespace Library;

public interface IGate
{
    public void AddInput (string name, IInput value);

    public int Calculate ();


}