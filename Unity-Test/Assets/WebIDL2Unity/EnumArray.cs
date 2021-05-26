using System;


public class EnumArray<T> : Sequence<T> where T : Enum
{
    internal EnumArray(int id) : base(id)
    {

    }

    public EnumArray() : base()
    {

    }

    public override T GetElementAt(int index)
    {
      return (T)(object)WebIDL2UnityGetElementAtEnum(ID, typeof(T).Name, index);
    }

    public override int IndexOf(T item)
    {
        return WebIDL2UnityIndexOfEnum(ID, typeof(T).Name, (int)(object)item);
    }

    public override void Splice(int start, int deleteCount, T item)
    {
        WebIDL2UnitySpliceEnum_3(ID, typeof(T).Name, start, deleteCount, (int)(object)item);
    }

    public override void Splice(int start, int deleteCount)
    {
        WebIDL2UnitySpliceEnum_2(ID, start, deleteCount);
    }
}
