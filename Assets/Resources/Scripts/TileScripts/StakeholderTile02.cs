using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StakeholderTile02 : MonoBehaviour
{
    private Sprite[] Stakeholder02;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Stakeholder02 = Resources.LoadAll<Sprite>("GameBoardTiles/Stakeholder/02Stakeholder/");
        rend.sprite = Stakeholder02[whichTile];
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
        rend.sprite = Stakeholder02[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Stakeholder02[tileNo];
    }
}
