using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessTile01 : MonoBehaviour
{
    private Sprite[] Process01;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Process01 = Resources.LoadAll<Sprite>("GameBoardTiles/Process/01Process/");
        rend.sprite = Process01[whichTile];
    }

    private void OnMouseDown()
    {
        //      if (!MainMenu.HelpStarted)
        //      {
        if (whichTile < 1)
        {
            whichTile += 1;
        }
        else
        {
            whichTile = 0;
        }
        rend.sprite = Process01[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Process01[tileNo];
    }
}
