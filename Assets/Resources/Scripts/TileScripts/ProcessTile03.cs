using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessTile03 : MonoBehaviour
{
    private Sprite[] Process03;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Process03 = Resources.LoadAll<Sprite>("GameBoardTiles/Process/03Process/");
        rend.sprite = Process03[whichTile];
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
        rend.sprite = Process03[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Process03[tileNo];
    }
}
