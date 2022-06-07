using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityTile03 : MonoBehaviour
{
    private Sprite[] Entity03;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Entity03 = Resources.LoadAll<Sprite>("GameBoardTiles/Entity/03Entity/");
        rend.sprite = Entity03[whichTile];
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
        rend.sprite = Entity03[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Entity03[tileNo];
    }
}
