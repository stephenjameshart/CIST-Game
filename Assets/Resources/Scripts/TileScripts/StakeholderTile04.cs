using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StakeholderTile04 : MonoBehaviour
{
    private Sprite[] Stakeholder04;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Stakeholder04 = Resources.LoadAll<Sprite>("GameBoardTiles/Stakeholder/04Stakeholder/");
        rend.sprite = Stakeholder04[whichTile];
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
        rend.sprite = Stakeholder04[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Stakeholder04[tileNo];
    }
}
