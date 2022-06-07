using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stage06 : MonoBehaviour
{
    private Sprite[] Stage06Tiles;
    private SpriteRenderer rend;
    private int whichTile = 0;
    public GameObject CISTInfo;
    public GameObject GameInformation;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Stage06Tiles = Resources.LoadAll<Sprite>("GameBoardTiles/Stages/Stage06");
        rend.sprite = Stage06Tiles[whichTile];
    }

    private void OnMouseDown()
    {
        if (GameControl.attackStarted)
        {
            if (whichTile < 1)
            {
                whichTile += 1;
            }
            else
            {
                whichTile = 0;
            }
            rend.sprite = Stage06Tiles[whichTile];
            GameInformation = GameObject.Find("Step04Text");
            if (whichTile < 1)
            {
                GameInformation.GetComponent<TextMeshProUGUI>().text = "4. Select Attack Location: Not Selected";
                GameControl.AttackStage = 0;
            }
            else
            {
                GameInformation.GetComponent<TextMeshProUGUI>().text = "4. Select Attack Location: Stage 6";
                GameControl.AttackStage = 6;
            }
            CISTInfo = GameObject.Find("01Stage");
            CISTInfo.GetComponent<Stage01>().ChangeTile(0);
            CISTInfo = GameObject.Find("02Stage");
            CISTInfo.GetComponent<Stage02>().ChangeTile(0);
            CISTInfo = GameObject.Find("03Stage");
            CISTInfo.GetComponent<Stage03>().ChangeTile(0);
            CISTInfo = GameObject.Find("04Stage");
            CISTInfo.GetComponent<Stage04>().ChangeTile(0);
            CISTInfo = GameObject.Find("05Stage");
            CISTInfo.GetComponent<Stage05>().ChangeTile(0);
        }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Stage06Tiles[tileNo];
        whichTile = tileNo;
    }
}
