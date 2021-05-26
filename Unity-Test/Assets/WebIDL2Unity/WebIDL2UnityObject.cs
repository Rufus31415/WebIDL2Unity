

using System;
using System.Runtime.InteropServices;

public interface IWebIDL2UnityObject
{
    int ID { get; }
}

public abstract partial class WebIDL2UnityObject : IWebIDL2UnityObject
{
    internal readonly int ID;

    int IWebIDL2UnityObject.ID => ID;

    internal WebIDL2UnityObject(int id)
    {
        this.ID = id;
    }

    [DllImport("__Internal")]
    protected static extern void WebIDL2UnityDeleteReference(int id);


    [DllImport("__Internal")]
    protected static extern int WebIDL2UnityGetNewDictionnary();

    [DllImport("__Internal")]
    protected static extern int WebIDL2UnityGetNewArray();


    [DllImport("__Internal")]
    protected static extern int WebIDL2UnityGetElementAtEnum(int id, string name, int index);

    [DllImport("__Internal")]
    protected static extern void WebIDL2UnitySpliceEnum_3(int id, string name, int start, int deleteCount, int item);

    [DllImport("__Internal")]
    protected static extern void WebIDL2UnitySpliceEnum_2(int id, int start, int deleteCount);

    [DllImport("__Internal")]
    protected static extern int WebIDL2UnityIndexOfEnum(int id, string name, int item);

    [DllImport("__Internal")]
    protected static extern int WebIDL2UnityGetElementAtReference(int id,  int index);

    [DllImport("__Internal")]
    protected static extern void WebIDL2UnitySpliceReference_3(int id, int start, int deleteCount, int item);
    [DllImport("__Internal")]
    protected static extern void WebIDL2UnitySpliceReference_2(int id, int start, int deleteCount);

    [DllImport("__Internal")]
    protected static extern int WebIDL2UnityIndexOfReference(int id,  int item);

    [DllImport("__Internal")]
    protected extern static int WebIDL2Unity_reference_get(int parentID, string fieldName);

    [DllImport("__Internal")]
    protected extern static void WebIDL2Unity_reference_set(int parentID, string fieldName, int value);




    ~WebIDL2UnityObject()
    {
        WebIDL2UnityDeleteReference(ID);
    }
}

