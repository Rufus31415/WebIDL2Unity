
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Float32Array : Sequence<float>
{
    internal Float32Array(int id) : base(id)
    {

    }

    public Float32Array() : base()
    {

    }

    [DllImport("__Internal")]
    private static extern float WebIDL2UnityGetElementAtNative_Float32Array(int id, int index);

    public override float GetElementAt(int index)
    {
        return WebIDL2UnityGetElementAtNative_Float32Array(ID, index);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Float32Array_3(int id, int start, int deleteCount, float item);

    public override void Splice(int start, int deleteCount, float item)
    {
        WebIDL2UnitySpliceNative_Float32Array_3(ID, start, deleteCount, item);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Float32Array_2(int id, int start, int deleteCount);

    public override void Splice(int start, int deleteCount)
    {
        WebIDL2UnitySpliceNative_Float32Array_2(ID, start, deleteCount);
    }


    [DllImport("__Internal")]
    private static extern int WebIDL2UnityIndexOfNative_Float32Array(int id, float item);
    public override int IndexOf(float item)
    {
        return WebIDL2UnityIndexOfNative_Float32Array(ID, item);
    }


    public static implicit operator Float32Array(float[] x)
    {
        var array = new Float32Array();
        array.AddRange(x);
        return array;
    }
}
    