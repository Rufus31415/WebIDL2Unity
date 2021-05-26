using System;
using System.Collections.Generic;


public abstract class Sequence<T> : FrozenArray<T>, IList<T>
{
    internal Sequence(int id) : base(id)
    {

    }

    public Sequence() : base(WebIDL2UnityGetNewArray())
    {

    }



    public void AddRange(IEnumerable<T> array)
    {
        foreach (var value in array) Add(value);
    }

    public new T this[int index]
    {
        get
        {
            return GetElementAt(index);
        }
        set
        {
            Splice(index, 0, value);
        }
    }

    public abstract void Splice(int start, int deleteCount, T item);
    public abstract void Splice(int start, int deleteCount);


    public bool IsReadOnly => false;

    public void Add(T item)
    {
        Splice(Count, 0, item);
    }

    public void Clear()
    {
        Splice(0, Count);
    }

    public bool Contains(T item)
    {
        return IndexOf(item) >= 0;
    }


    public void CopyTo(T[] array, int arrayIndex)
    {
        var length = Count;

        if (array == null)
            throw new ArgumentNullException("array");
        if (arrayIndex < 0)
            throw new ArgumentOutOfRangeException("arrayIndex");
        if (array.Length - arrayIndex < length)
            throw new ArgumentException("Not enough elements after index in the destination array.");

        for (int i = 0; i < length; ++i) array[i + arrayIndex] = GetElementAt(i);
    }

    public abstract int IndexOf(T item);


    public void Insert(int index, T item)
    {
        Splice(index, 0, item);
    }

    public bool Remove(T item)
    {
        int index = IndexOf(item);
        if (index < 0) return false;
        RemoveAt(index);
        return true;
    }

    public void RemoveAt(int index)
    {
        Splice(index, 1);
    }

}