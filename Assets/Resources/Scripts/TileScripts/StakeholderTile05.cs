using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StakeholderTile05 : MonoBehaviour
{
    private Sprite[] Stakeholder05;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Stakeholder05 = Resources.LoadAll<Sprite>("GameBoardTiles/Stakeholder/05Stakeholder/");
        rend.sprite = Stakeholder05[whichTile];
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
        rend.sprite = Stakeholder05[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Stakeholder05[tileNo];
    }
}
