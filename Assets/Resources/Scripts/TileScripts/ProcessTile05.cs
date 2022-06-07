using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessTile05 : MonoBehaviour
{
    private Sprite[] Process05;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Process05 = Resources.LoadAll<Sprite>("GameBoardTiles/Process/05Process/");
        rend.sprite = Process05[whichTile];
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
        rend.sprite = Process05[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Process05[tileNo];
    }
}
