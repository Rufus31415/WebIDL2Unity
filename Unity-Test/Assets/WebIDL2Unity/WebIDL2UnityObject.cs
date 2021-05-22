

using System;
using System.Runtime.InteropServices;

public abstract partial class WebIDL2UnityObject
{
    internal readonly int ID;

    internal WebIDL2UnityObject(int id)
    {
        this.ID = id;
    }

    [DllImport("__Internal")]
    private static extern void WebIDL2UnityDeleteReference(int id);


    [DllImport("__Internal")]
    protected static extern int WebIDL2UnityGetNewDictionnary();

    [DllImport("__Internal")]
    protected static extern int WebIDL2UnityGetNewArray();

    ~WebIDL2UnityObject()
    {
        WebIDL2UnityDeleteReference(ID);
    }
}

