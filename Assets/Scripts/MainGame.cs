using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class MainGame : MonoBehaviour
{
    private bool _paused = false;

    public List<GameObject> imagePlaces = new List<GameObject>();
    
    public List<Sprite> sprites = new List<Sprite>();

    private List<GameObject> blocks;

    private List<GameObject> currentNextBlocks = new List<GameObject>();
    private static GameObject CurrentBlock;
    
    void Start()
    {
        
    }
    
    void LateUpdate()
    {
        if (!_paused)
        {
            if (CurrentBlock == null)
            {
                Instantiate(incomingBlocks.getCurrentBlock());
            }

        }
    }
    private void GetNextBlocks()
    {
        
        currentNextBlocks.Add(blocks[Random.Range(0,7)]);
        CurrentBlock = currentNextBlocks[0];
        MainGame.CurrentBlock = currentNextBlocks[0];
        currentNextBlocks.RemoveAt(0);
        for (int i = 0; i < currentNextBlocks.Count; i++)
        {
            Debug.Log(i + ": " + currentNextBlocks[i].name);
        }

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
