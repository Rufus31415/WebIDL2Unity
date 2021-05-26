
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class BoolArray : Sequence<bool>
{
    internal BoolArray(int id) : base(id)
    {

    }

    public BoolArray() : base()
    {

    }

    [DllImport("__Internal")]
    private static extern bool WebIDL2UnityGetElementAtNative_BoolArray(int id, int index);

    public override bool GetElementAt(int index)
    {
        return WebIDL2UnityGetElementAtNative_BoolArray(ID, index);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_BoolArray_3(int id, int start, int deleteCount, bool item);

    public override void Splice(int start, int deleteCount, bool item)
    {
        WebIDL2UnitySpliceNative_BoolArray_3(ID, start, deleteCount, item);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_BoolArray_2(int id, int start, int deleteCount);

    public override void Splice(int start, int deleteCount)
    {
        WebIDL2UnitySpliceNative_BoolArray_2(ID, start, deleteCount);
    }


    [DllImport("__Internal")]
    private static extern int WebIDL2UnityIndexOfNative_BoolArray(int id, bool item);
    public override int IndexOf(bool item)
    {
        return WebIDL2UnityIndexOfNative_BoolArray(ID, item);
    }


    public static implicit operator BoolArray(bool[] x)
    {
        var array = new BoolArray();
        array.AddRange(x);
        return array;
    }
}
    