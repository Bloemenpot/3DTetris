using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class incomingBlocks : MonoBehaviour
{
    public List<GameObject> imagePlaces = new List<GameObject>();
    public List<Sprite> sprites = new List<Sprite>();

    private List<GameObject> blocks;

    private List<GameObject> currentNextBlocks = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        blocks = ObjectLists.getBlockTypes;

        try
        {
            currentNextBlocks.Add(blocks[Random.Range(0,6)]);
            currentNextBlocks.Add(blocks[Random.Range(0,6)]);
            currentNextBlocks.Add(blocks[Random.Range(0,6)]);
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
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            getNextBlocks();
        }
    }

    private void getNextBlocks()
    {
        currentNextBlocks.Add(blocks[Random.Range(0,7)]);
        currentNextBlocks.RemoveAt(0);
        for (int i = 0; i < currentNextBlocks.Count; i++)
        {
            Debug.Log(i + ": " + currentNextBlocks[i].name);
        }
        Debug.Log(currentNextBlocks);

        for (int i = 0; i < imagePlaces.Count; i++)
        {
            switch (currentNextBlocks[i].name)
            {
                case "IBlock":
                    imagePlaces[i].GetComponent<Image>().sprite = sprites[0];
                    break;
                case "JBlock":
                    imagePlaces[i].GetComponent<Image>().sprite = sprites[1];
                    break;
                case "LBlock":
                    imagePlaces[i].GetComponent<Image>().sprite = sprites[2];
                    break;
                case "OBlock":
                    imagePlaces[i].GetComponent<Image>().sprite = sprites[3];
                    break;
                case "SBlock":
                    imagePlaces[i].GetComponent<Image>().sprite = sprites[4];
                    break;
                case "TBlock":
                    imagePlaces[i].GetComponent<Image>().sprite = sprites[5];
                    break;
                case "ZBlock":
                    imagePlaces[i].GetComponent<Image>().sprite = sprites[6];
                    break;
                default:
                    imagePlaces[i].GetComponent<Image>().sprite = sprites[7];
                    break;
            }

        }
    }
}
