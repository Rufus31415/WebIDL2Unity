using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Promise<T> : WebIDL2UnityObject where T : Delegate
{
    private Dictionary<int, Promise<T>> _promises;

    private T _callback;

    private object[] _args;

    internal Promise(int id, Dictionary<int, Promise<T>> promises) : base(id) {

        promises[id] = this;
        _promises = promises;
    }


    internal void AfterCallback(object[] args)
    {
        Debug.Log("callback!!");
        _promises.Remove(ID);
        _promises = null;

        _args = args;

        _callback?.DynamicInvoke(args);
    }

    public void Then(T callback)
    {
        _callback = callback;

        // If callback has already been called
        if(_args != null) _callback?.DynamicInvoke(_args);
    }

}