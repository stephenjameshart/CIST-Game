using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stage01 : MonoBehaviour
{
    private Sprite[] Stage01Tiles;
    private SpriteRenderer rend;
    private int whichTile = 0;
    public GameObject CISTInfo;
    public GameObject GameInformation;

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Stage01Tiles = Resources.LoadAll<Sprite>("GameBoardTiles/Stages/Stage01");
        rend.sprite = Stage01Tiles[whichTile];
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
            rend.sprite = Stage01Tiles[whichTile];
            GameInformation = GameObject.Find("Step04Text");
            if (whichTile < 1)
            {
                GameInformation.GetComponent<TextMeshProUGUI>().text = "4. Select Attack Location: Not Selected";
                GameControl.AttackStage = 0;
            }
            else
            {
                GameInformation.GetComponent<TextMeshProUGUI>().text = "4. Select Attack Location: Stage 1";
                GameControl.AttackStage = 1;
            }
            CISTInfo = GameObject.Find("02Stage");
            CISTInfo.GetComponent<Stage02>().ChangeTile(0);
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
        rend.sprite = Stage01Tiles[tileNo];
        whichTile = tileNo;
    }
}
