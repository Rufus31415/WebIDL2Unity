using System;

public class JSArray<T> : Sequence<T> where T : WebIDL2UnityObject
{
    internal JSArray(int id) : base(id) { }

    public JSArray() : base() { }

    public override T GetElementAt(int index)
    {
        var id = WebIDL2UnityGetElementAtReference(ID, index);
        if (id == 0) return null;

        return (T)Activator.CreateInstance(typeof(T), id);
    }

    public override int IndexOf(T item)
    {
        return WebIDL2UnityIndexOfReference(ID, item.ID);
    }

    public override void Splice(int start, int deleteCount, T item)
    {
        WebIDL2UnitySpliceReference_3(ID, start, deleteCount, item.ID);
    }

    public override void Splice(int start, int deleteCount)
    {
        WebIDL2UnitySpliceReference_2(ID, start, deleteCount);
    }
}
