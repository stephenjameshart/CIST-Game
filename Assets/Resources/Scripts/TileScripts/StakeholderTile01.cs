using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StakeholderTile01 : MonoBehaviour
{
    private Sprite[] Stakeholder01;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Stakeholder01 = Resources.LoadAll<Sprite>("GameBoardTiles/Stakeholder/01Stakeholder/");
        rend.sprite = Stakeholder01[whichTile];
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
        rend.sprite = Stakeholder01[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Stakeholder01[tileNo];
    }
}
