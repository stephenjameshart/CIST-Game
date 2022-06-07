using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StakeholderTile03 : MonoBehaviour
{
    private Sprite[] Stakeholder03;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Stakeholder03 = Resources.LoadAll<Sprite>("GameBoardTiles/Stakeholder/03Stakeholder/");
        rend.sprite = Stakeholder03[whichTile];
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
        rend.sprite = Stakeholder03[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Stakeholder03[tileNo];
    }
}
