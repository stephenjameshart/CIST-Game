using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessTile07 : MonoBehaviour
{
    private Sprite[] Process07;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Process07 = Resources.LoadAll<Sprite>("GameBoardTiles/Process/07Process/");
        rend.sprite = Process07[whichTile];
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
        rend.sprite = Process07[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Process07[tileNo];
    }
}
