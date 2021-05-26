
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Int8Array : Sequence<sbyte>
{
    internal Int8Array(int id) : base(id)
    {

    }

    public Int8Array() : base()
    {

    }

    [DllImport("__Internal")]
    private static extern sbyte WebIDL2UnityGetElementAtNative_Int8Array(int id, int index);

    public override sbyte GetElementAt(int index)
    {
        return WebIDL2UnityGetElementAtNative_Int8Array(ID, index);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Int8Array_3(int id, int start, int deleteCount, sbyte item);

    public override void Splice(int start, int deleteCount, sbyte item)
    {
        WebIDL2UnitySpliceNative_Int8Array_3(ID, start, deleteCount, item);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Int8Array_2(int id, int start, int deleteCount);

    public override void Splice(int start, int deleteCount)
    {
        WebIDL2UnitySpliceNative_Int8Array_2(ID, start, deleteCount);
    }


    [DllImport("__Internal")]
    private static extern int WebIDL2UnityIndexOfNative_Int8Array(int id, sbyte item);
    public override int IndexOf(sbyte item)
    {
        return WebIDL2UnityIndexOfNative_Int8Array(ID, item);
    }


    public static implicit operator Int8Array(sbyte[] x)
    {
        var array = new Int8Array();
        array.AddRange(x);
        return array;
    }
}
    