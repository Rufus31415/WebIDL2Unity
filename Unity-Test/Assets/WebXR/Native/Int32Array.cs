
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Int32Array : Sequence<long>
{
    internal Int32Array(int id) : base(id)
    {

    }

    public Int32Array() : base()
    {

    }

    [DllImport("__Internal")]
    private static extern long WebIDL2UnityGetElementAtNative_Int32Array(int id, int index);

    public override long GetElementAt(int index)
    {
        return WebIDL2UnityGetElementAtNative_Int32Array(ID, index);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Int32Array_3(int id, int start, int deleteCount, long item);

    public override void Splice(int start, int deleteCount, long item)
    {
        WebIDL2UnitySpliceNative_Int32Array_3(ID, start, deleteCount, item);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Int32Array_2(int id, int start, int deleteCount);

    public override void Splice(int start, int deleteCount)
    {
        WebIDL2UnitySpliceNative_Int32Array_2(ID, start, deleteCount);
    }


    [DllImport("__Internal")]
    private static extern int WebIDL2UnityIndexOfNative_Int32Array(int id, long item);
    public override int IndexOf(long item)
    {
        return WebIDL2UnityIndexOfNative_Int32Array(ID, item);
    }


    public static implicit operator Int32Array(long[] x)
    {
        var array = new Int32Array();
        array.AddRange(x);
        return array;
    }
}
    