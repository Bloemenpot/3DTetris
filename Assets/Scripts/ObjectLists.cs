using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLists  : MonoBehaviour
{

    public List<GameObject> blockTypes;
    private static List<GameObject> st_blockTypes;

    // Start is called before the first frame update


    void Awake()
    {
        st_blockTypes = blockTypes;
        Debug.Log("test");

    }

    public static List<GameObject> getBlockTypes
    {
        get { return st_blockTypes; }
    }

}
