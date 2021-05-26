
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Float64Array : Sequence<double>
{
    internal Float64Array(int id) : base(id)
    {

    }

    public Float64Array() : base()
    {

    }

    [DllImport("__Internal")]
    private static extern double WebIDL2UnityGetElementAtNative_Float64Array(int id, int index);

    public override double GetElementAt(int index)
    {
        return WebIDL2UnityGetElementAtNative_Float64Array(ID, index);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Float64Array_3(int id, int start, int deleteCount, double item);

    public override void Splice(int start, int deleteCount, double item)
    {
        WebIDL2UnitySpliceNative_Float64Array_3(ID, start, deleteCount, item);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_Float64Array_2(int id, int start, int deleteCount);

    public override void Splice(int start, int deleteCount)
    {
        WebIDL2UnitySpliceNative_Float64Array_2(ID, start, deleteCount);
    }


    [DllImport("__Internal")]
    private static extern int WebIDL2UnityIndexOfNative_Float64Array(int id, double item);
    public override int IndexOf(double item)
    {
        return WebIDL2UnityIndexOfNative_Float64Array(ID, item);
    }


    public static implicit operator Float64Array(double[] x)
    {
        var array = new Float64Array();
        array.AddRange(x);
        return array;
    }
}
    