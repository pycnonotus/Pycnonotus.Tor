namespace Pycnontus;

public class Tor<T, Other>
{
    public T First { get; }
    public Other Second { get; }

    public  bool IsFirst => First is not null;
    public bool IsSecond => Second is not null;
    
    public Tor(T first, Other second)
    {
        First = first;
        Second = Second;
    }
    
    public static implicit operator Tor<T, Other>(T first) => new Tor<T, Other>(first, default);
    public static implicit operator Tor<T, Other>(Other second) => new Tor<T, Other>(default, second);
    
    
}
