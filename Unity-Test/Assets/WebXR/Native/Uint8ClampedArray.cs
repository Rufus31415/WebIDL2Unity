
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Uint8ClampedArray : Sequence<byte>
{
    internal Uint8ClampedArray(int id) : base(id)
    {

    }

    public Uint8ClampedArray() : base()
    {

    }

    [DllImport("__Internal")]
    private static extern byte WebIDL2UnityGetElementAtNative_Uint8ClampedArray(int id, int index);

    public override byte GetElementAt(int index)
    {
        return WebIDL2UnityGetElementAtNative_Uint8ClampedArray(ID, index);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Uint8ClampedArray_3(int id, int start, int deleteCount, byte item);

    public override void Splice(int start, int deleteCount, byte item)
    {
        WebIDL2UnitySpliceNative_Uint8ClampedArray_3(ID, start, deleteCount, item);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Uint8ClampedArray_2(int id, int start, int deleteCount);

    public override void Splice(int start, int deleteCount)
    {
        WebIDL2UnitySpliceNative_Uint8ClampedArray_2(ID, start, deleteCount);
    }


    [DllImport("__Internal")]
    private static extern int WebIDL2UnityIndexOfNative_Uint8ClampedArray(int id, byte item);
    public override int IndexOf(byte item)
    {
        return WebIDL2UnityIndexOfNative_Uint8ClampedArray(ID, item);
    }


    public static implicit operator Uint8ClampedArray(byte[] x)
    {
        var array = new Uint8ClampedArray();
        array.AddRange(x);
        return array;
    }
}
    