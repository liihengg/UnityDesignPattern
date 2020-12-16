using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Li_Factory
{
    public static Api CreateApi(int condition)
    {
        Api api = null;
        if(condition == 1)
        {
            api = new ImplA();
        }
        else
        {
            api = new ImplB();
        }
        return api;
    }

}


public class ImplA : Api
{
    public void Operation(string s)
    {
        Debug.Log("ImplA" + s);
    }
}

public class ImplB : Api
{
    public void Operation(string s)
    {
        Debug.Log("ImplB" + s);
    }
}

public interface Api
{
    void Operation(string s);
}

