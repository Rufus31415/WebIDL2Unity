
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Uint32Array : Sequence<ulong>
{
    internal Uint32Array(int id) : base(id)
    {

    }

    public Uint32Array() : base()
    {

    }

    [DllImport("__Internal")]
    private static extern ulong WebIDL2UnityGetElementAtNative_Uint32Array(int id, int index);

    public override ulong GetElementAt(int index)
    {
        return WebIDL2UnityGetElementAtNative_Uint32Array(ID, index);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Uint32Array_3(int id, int start, int deleteCount, ulong item);

    public override void Splice(int start, int deleteCount, ulong item)
    {
        WebIDL2UnitySpliceNative_Uint32Array_3(ID, start, deleteCount, item);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Uint32Array_2(int id, int start, int deleteCount);

    public override void Splice(int start, int deleteCount)
    {
        WebIDL2UnitySpliceNative_Uint32Array_2(ID, start, deleteCount);
    }


    [DllImport("__Internal")]
    private static extern int WebIDL2UnityIndexOfNative_Uint32Array(int id, ulong item);
    public override int IndexOf(ulong item)
    {
        return WebIDL2UnityIndexOfNative_Uint32Array(ID, item);
    }


    public static implicit operator Uint32Array(ulong[] x)
    {
        var array = new Uint32Array();
        array.AddRange(x);
        return array;
    }
}
    