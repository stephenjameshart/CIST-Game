using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stage02 : MonoBehaviour
{
    private Sprite[] Stage02Tiles;
    private SpriteRenderer rend;
    private int whichTile = 0;
    public GameObject CISTInfo;
    public GameObject GameInformation;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Stage02Tiles = Resources.LoadAll<Sprite>("GameBoardTiles/Stages/Stage02");
        rend.sprite = Stage02Tiles[whichTile];
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
            rend.sprite = Stage02Tiles[whichTile];
            GameInformation = GameObject.Find("Step04Text");
            if (whichTile < 1)
            {
                GameInformation.GetComponent<TextMeshProUGUI>().text = "4. Select Attack Location: Not Selected";
                GameControl.AttackStage = 0;
            }
            else
            {
                GameInformation.GetComponent<TextMeshProUGUI>().text = "4. Select Attack Location: Stage 2";
                GameControl.AttackStage = 2;
            }
            CISTInfo = GameObject.Find("01Stage");
            CISTInfo.GetComponent<Stage01>().ChangeTile(0);
            CISTInfo = GameObject.Find("03Stage");
            CISTInfo.GetComponent<Stage03>().ChangeTile(0);
            CISTInfo = GameObject.Find("04Stage");
            CISTInfo.GetComponent<Stage04>().ChangeTile(0);
            CISTInfo = GameObject.Find("05Stage");
            CISTInfo.GetComponent<Stage05>().ChangeTile(0);
            CISTInfo = GameObject.Find("06Stage");
            CISTInfo.GetComponent<Stage06>().ChangeTile(0);
        }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = Stage02Tiles[tileNo];
        whichTile = tileNo;
    }
}
