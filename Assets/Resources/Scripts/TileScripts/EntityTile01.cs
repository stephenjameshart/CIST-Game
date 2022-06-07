using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityTile01 : MonoBehaviour
{
    private Sprite[] Entity01;
    private SpriteRenderer rend;
    private int whichTile = 0;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Entity01 = Resources.LoadAll<Sprite>("GameBoardTiles/Entity/01Entity/");
        rend.sprite = Entity01[whichTile];
    }

    private void OnMouseDown()
    {
    //if (GameControl.attackStarted)
     //        {
        if (whichTile < 1)
        {
            whichTile += 1;
        }
        else
        {
            whichTile = 0;
        }
        rend.sprite = Entity01[whichTile];
    //}
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Entity01[tileNo];
    }
}
