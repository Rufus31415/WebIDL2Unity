
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class StringArray : Sequence<string>
{
    internal StringArray(int id) : base(id)
    {

    }

    public StringArray() : base()
    {

    }

    [DllImport("__Internal")]
    private static extern string WebIDL2UnityGetElementAtNative_StringArray(int id, int index);

    public override string GetElementAt(int index)
    {
        return WebIDL2UnityGetElementAtNative_StringArray(ID, index);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_StringArray_3(int id, int start, int deleteCount, string item);

    public override void Splice(int start, int deleteCount, string item)
    {
        WebIDL2UnitySpliceNative_StringArray_3(ID, start, deleteCount, item);
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnitySpliceNative_StringArray_2(int id, int start, int deleteCount);

    public override void Splice(int start, int deleteCount)
    {
        WebIDL2UnitySpliceNative_StringArray_2(ID, start, deleteCount);
    }


    [DllImport("__Internal")]
    private static extern int WebIDL2UnityIndexOfNative_StringArray(int id, string item);
    public override int IndexOf(string item)
    {
        return WebIDL2UnityIndexOfNative_StringArray(ID, item);
    }


    public static implicit operator StringArray(string[] x)
    {
        var array = new StringArray();
        array.AddRange(x);
        return array;
    }
}
    