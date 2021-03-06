using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessTile04 : MonoBehaviour
{
    private Sprite[] Process04;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Process04 = Resources.LoadAll<Sprite>("GameBoardTiles/Process/04Process/");
        rend.sprite = Process04[whichTile];
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
        rend.sprite = Process04[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Process04[tileNo];
    }
}
