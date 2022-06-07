using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityTile02 : MonoBehaviour
{
    private Sprite[] Entity02;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Entity02 = Resources.LoadAll<Sprite>("GameBoardTiles/Entity/02Entity/");
        rend.sprite = Entity02[whichTile];
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
        rend.sprite = Entity02[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Entity02[tileNo];
    }
}
