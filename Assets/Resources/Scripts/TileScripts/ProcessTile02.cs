using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessTile02 : MonoBehaviour
{
    private Sprite[] Process02;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Process02 = Resources.LoadAll<Sprite>("GameBoardTiles/Process/02Process/");
        rend.sprite = Process02[whichTile];
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
        rend.sprite = Process02[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Process02[tileNo];
    }
}
