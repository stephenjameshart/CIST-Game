using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessTile06 : MonoBehaviour
{
    private Sprite[] Process06;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Process06 = Resources.LoadAll<Sprite>("GameBoardTiles/Process/06Process/");
        rend.sprite = Process06[whichTile];
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
        rend.sprite = Process06[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Process06[tileNo];
    }
}
