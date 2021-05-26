
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Int16Array : Sequence<int>
{
    internal Int16Array(int id) : base(id)
    {

    }

    public Int16Array() : base()
    {

    }

    [DllImport("__Internal")]
    private static extern int WebIDL2UnityGetElementAtNative_Int16Array(int id, int index);

    public override int GetElementAt(int index)
    {
        return WebIDL2UnityGetElementAtNative_Int16Array(ID, index);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Int16Array_3(int id, int start, int deleteCount, int item);

    public override void Splice(int start, int deleteCount, int item)
    {
        WebIDL2UnitySpliceNative_Int16Array_3(ID, start, deleteCount, item);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Int16Array_2(int id, int start, int deleteCount);

    public override void Splice(int start, int deleteCount)
    {
        WebIDL2UnitySpliceNative_Int16Array_2(ID, start, deleteCount);
    }


    [DllImport("__Internal")]
    private static extern int WebIDL2UnityIndexOfNative_Int16Array(int id, int item);
    public override int IndexOf(int item)
    {
        return WebIDL2UnityIndexOfNative_Int16Array(ID, item);
    }


    public static implicit operator Int16Array(int[] x)
    {
        var array = new Int16Array();
        array.AddRange(x);
        return array;
    }
}
    