using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterfeitCat : MonoBehaviour
{
    private Sprite[] CISTCatC;
    private SpriteRenderer rend;
    private int whichTile = 0;
    public GameObject CISTInfo;
    public GameObject Step02Information;

    private void Awake()
    {
        Step02Information = GameObject.Find("Step02Text");
    }

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        CISTCatC = Resources.LoadAll<Sprite>("CISTCategories/Counterfeiting/");
        rend.sprite = CISTCatC[whichTile];
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
            rend.sprite = CISTCatC[whichTile];
            if (whichTile < 1)
            {
                Step02Information.GetComponent<TextMeshProUGUI>().text = "2. CIST Category: Not Selected";
                GameControl.CISTCategoryAttack = "";
            }
            else
            {
                Step02Information.GetComponent<TextMeshProUGUI>().text = "2. CIST Category: Counterfeiting";
                GameControl.CISTCategoryAttack = "C";
                // Check if defence same CIST category
                if (GameControl.CISTCategoryDefence != "")
                {
                    if (GameControl.CISTCategoryDefence != GameControl.CISTCategoryAttack)
                    {
                        Step02Information.GetComponent<TextMeshProUGUI>().text = "Warning!: CIST Attack and Defence category must be the same";
                    }
                }

                CISTInfo = GameObject.Find("CISTCatTileI");
                CISTInfo.GetComponent<InfoLeakageCat>().ChangeTile(0);
                CISTInfo = GameObject.Find("CISTCatTileS");
                CISTInfo.GetComponent<SabotageCat>().ChangeTile(0);
                CISTInfo = GameObject.Find("CISTCatTileT");
                CISTInfo.GetComponent<TamperingCat>().ChangeTile(0);
                //CISTInfo = GameObject.Find("DefenceInformationLeakage");
                //CISTInfo.GetComponent<DefenceI>().ChangeTile(0);
                //CISTInfo = GameObject.Find("DefenceSabotage");
                //CISTInfo.GetComponent<DefenceS>().ChangeTile(0);
                //CISTInfo = GameObject.Find("DefenceTampering");
                //CISTInfo.GetComponent<DefenceT>().ChangeTile(0);
                // Where change category
                //if (GameControl.CISTCategoryDefence != "C")
                //{
                //    CISTInfo = GameObject.Find("DefenceCounterfeiting");
                //    CISTInfo.GetComponent<DefenceC>().ChangeTile(0);
                //}   
            }
        }
    }
    public void ChangeTile(int tileNo)
    {
        rend.sprite = CISTCatC[tileNo];
        whichTile = tileNo;
    }
}
