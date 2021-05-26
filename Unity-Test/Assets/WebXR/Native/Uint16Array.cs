
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Uint16Array : Sequence<uint>
{
    internal Uint16Array(int id) : base(id)
    {

    }

    public Uint16Array() : base()
    {

    }

    [DllImport("__Internal")]
    private static extern uint WebIDL2UnityGetElementAtNative_Uint16Array(int id, int index);

    public override uint GetElementAt(int index)
    {
        return WebIDL2UnityGetElementAtNative_Uint16Array(ID, index);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Uint16Array_3(int id, int start, int deleteCount, uint item);

    public override void Splice(int start, int deleteCount, uint item)
    {
        WebIDL2UnitySpliceNative_Uint16Array_3(ID, start, deleteCount, item);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Uint16Array_2(int id, int start, int deleteCount);

    public override void Splice(int start, int deleteCount)
    {
        WebIDL2UnitySpliceNative_Uint16Array_2(ID, start, deleteCount);
    }


    [DllImport("__Internal")]
    private static extern int WebIDL2UnityIndexOfNative_Uint16Array(int id, uint item);
    public override int IndexOf(uint item)
    {
        return WebIDL2UnityIndexOfNative_Uint16Array(ID, item);
    }


    public static implicit operator Uint16Array(uint[] x)
    {
        var array = new Uint16Array();
        array.AddRange(x);
        return array;
    }
}
    