using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityTile04 : MonoBehaviour
{
    private Sprite[] Entity04;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Entity04 = Resources.LoadAll<Sprite>("GameBoardTiles/Entity/04Entity/");
        rend.sprite = Entity04[whichTile];
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
        rend.sprite = Entity04[whichTile];
        //      }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Entity04[tileNo];
    }
}
