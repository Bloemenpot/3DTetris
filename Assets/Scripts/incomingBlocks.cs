using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class incomingBlocks : MonoBehaviour
{
    private List<GameObject> blocks;

    private List<GameObject> currentNextBlocks;
    // Start is called before the first frame update
    void Start()
    {
        blocks = ObjectLists.getBlockTypes;

        try
        {
            currentNextBlocks.Add(blocks[Random.Range(0,6)]);
            // currentNextBlocks.Add(blocks[Random.Range(0,6)]);
            // currentNextBlocks.Add(blocks[Random.Range(0,6)]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Tab))
        // {
        //     currentNextBlocks.Add(blocks[Random.Range(0,6)]);
        //     currentNextBlocks.RemoveAt(0);
        //     Debug.Log(currentNextBlocks);
        // }
    }
    
    
}
