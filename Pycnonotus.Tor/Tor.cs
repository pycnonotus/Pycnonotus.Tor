#nullable enable
using System;

namespace Pycnontus;

public class Tor<T, Other>
{
    public T? First { get; }
    public Other? Second { get; }

    public  bool IsFirst => First is not null;
    public bool IsSecond => Second is not null;
    
    public Tor(T? first, Other? second)
    {
        if (first == null && second == null)
            throw new ArgumentException("Tor cannot be null");
        
        First = first;
        Second = second;
    }
    
    public static implicit operator Tor<T, Other>(T first) => new Tor<T, Other>(first, default);
    public static implicit operator Tor<T, Other>(Other second) => new Tor<T, Other>(default, second);
    
    
    public static implicit operator T?(Tor<T, Other> tor) => tor.First;
    public  static implicit operator Other?(Tor<T, Other> tor) => tor.Second;
    
}
