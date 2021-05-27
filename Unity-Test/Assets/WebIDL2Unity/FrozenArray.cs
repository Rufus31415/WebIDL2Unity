using System.Collections;
using System.Collections.Generic;


public abstract class FrozenArray<T> : WebIDL2UnityObject, IReadOnlyList<T>
{

    internal FrozenArray(int id) : base(id)
    {
    }

    public abstract T GetElementAt(int index);


    public T this[int index]
    {
        get
        {
            return GetElementAt(index);
        }
    }

    public int Count
    {
        get
        {
            return WebIDL2Unity_short_get(ID, "length");
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new ArrayEnumerator<T>(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public static implicit operator T[](FrozenArray<T> x)
    {
        var length = x.Count;
        var array = new T[length];
        for (int i = 0; i < length; i++) array[i] = x[i];
        return array;
    }
}

// TODO : implement native js iterator
public class ArrayEnumerator<T> :  IEnumerator<T>
{
    private FrozenArray<T> _array;

   private int _position;

    internal ArrayEnumerator(FrozenArray<T> array)
    {
        _array = array;
        Reset();
    }

    public T Current => _array[_position];

    object IEnumerator.Current => _array[_position];

    public void Dispose()
    {
        
    }

    public bool MoveNext()
    {
        _position++;
        return (_position < _array.Count);
    }

    public void Reset()
    {
        _position = -1;
    }
}

