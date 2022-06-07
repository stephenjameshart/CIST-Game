using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefenceC : MonoBehaviour
{
    private Sprite[] DefenceCIST_C;
    private SpriteRenderer rend;
    private int whichTile = 0;
    public GameObject CISTInfo;
    public GameObject GameInformation;
    public GameObject GameInformation2;
    public GameObject GameDefenceCMessage;
    private string messageText;
    private string messageText2;

    public void Awake()
    {
        GameDefenceCMessage = GameObject.Find("DefenceCounterfeitingText");
        GameInformation = GameObject.Find("Step05Text");
        GameInformation2 = GameObject.Find("Step02Text");
    }
    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        DefenceCIST_C = Resources.LoadAll<Sprite>("DefenceCards/Counterfeiting/");
        rend.sprite = DefenceCIST_C[whichTile];
    }

    private void OnMouseDown()
    {
        if (GameControl.attackStarted)
        {
            if (whichTile < 9)
            {
                whichTile += 1;
            }
            else
            {
                whichTile = 0;
            }
            rend.sprite = DefenceCIST_C[whichTile];
            //GameInformation = GameObject.Find("Step05Text");
            if (whichTile < 1)
            {
                GameInformation.GetComponent<TextMeshProUGUI>().text = "5. Select Defence: Not Selected";
                GameDefenceCMessage.GetComponent<TextMeshProUGUI>().text = "";
                GameControl.CISTCategoryDefence = "";
            }
            else
            {
                switch (whichTile)
                {
                    case 1:
                        messageText = "<align=center>5.Select Defence: Counterfeiting\n</align=center>" +
                        "Detection Method: Side Channel Analysis Differential Power Analysis (DPA)";
                        messageText2 = "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Side Channel Analysis Differential Power Analysis (DPA)";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceCMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 1;
                        break;

                    case 2:
                        messageText = "<align=center>5.Select Defence: Counterfeiting\n</align=center>" +
                        "Detection Method: Physical Inspection: X-Ray Inspection; Visual Inspection";
                        messageText2 = "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Physical Inspection: X-Ray Inspection; Visual Inspection";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceCMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 2;
                        break;

                    case 3:
                        messageText = "<align=center>5.Select Defence: Counterfeiting\n</align=center>" +
                        "Detection Method: Fingerprinting Conventional serial numbers";
                        messageText2 = "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting Conventional serial numbers";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceCMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 3;
                        break;

                    case 4:
                        messageText = "<align=center>5.Select Defence: Counterfeiting\n</align=center>" +
                        "Detection Method: Fingerprinting DNA Marking";
                        messageText2 = "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting DNA Marking";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceCMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 4;
                        break;
                    case 5:
                        messageText = "<align=center>5.Select Defence: Counterfeiting\n</align=center>" +
                        "Detection Method: Fingerprinting: Physical Unclonable Functions";
                        messageText2 = "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting: Physical Unclonable Functions";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceCMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 5;
                        break;
                    case 6:
                        messageText = "<align=center>5.Select Defence: Counterfeiting\n</align=center>" +
                        "Detection Method: Fingerprinting: Digital Fingerprinting";
                        messageText2 = "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting: Digital Fingerprinting";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceCMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 6;
                        break;
                    case 7:
                        messageText = "<align=center>5.Select Defence: Counterfeiting\n</align=center>" +
                        "Prevention Method: Active IC Metering: Active metering, force new IC process to be activated";
                        messageText2 = "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Prevention Method: Active IC Metering: Active metering, force new IC process to be activated";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceCMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 7;
                        break;
                    case 8:
                        messageText = "<align=center>5.Select Defence: Counterfeiting\n</align=center>" +
                        "Prevention Method: Anti-fuse-Based Package-Level Defence";
                        messageText2 = "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Prevention Method: Anti-fuse-Based Package-Level Defence";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceCMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 8;
                        break;
                    case 9:
                        messageText = "<align=center>5.Select Defence: Counterfeiting\n</align=center>" +
                        "Prevention Method: Supply Chain Compromise IC Supply Chain Assurance";
                        messageText2 = "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Prevention Method: Supply Chain Compromise IC Supply Chain Assurance";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceCMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 9;
                        break;
                }
            }
            CISTInfo = GameObject.Find("DefenceInformationLeakage");
            CISTInfo.GetComponent<DefenceI>().ChangeTile(0);
            CISTInfo = GameObject.Find("DefenceSabotage");
            CISTInfo.GetComponent<DefenceS>().ChangeTile(0);
            CISTInfo = GameObject.Find("DefenceTampering");
            CISTInfo.GetComponent<DefenceT>().ChangeTile(0);
            GameControl.CISTCategoryDefence = "C";
            if (GameControl.CISTCategoryAttack != "")
            {
                if (GameControl.CISTCategoryDefence != GameControl.CISTCategoryAttack)
                {
                    GameInformation2.GetComponent<TextMeshProUGUI>().text = "Warning!: CIST Attack and Defence category must be the same";
                }
                else
                {
                    switch (GameControl.CISTCategoryDefence)
                    {
                        case "C":
                            GameInformation2.GetComponent<TextMeshProUGUI>().text = "2. CIST Category: Counterfeiting";
                            break;
                        case "I":
                            GameInformation2.GetComponent<TextMeshProUGUI>().text = "2. CIST Category: Information Leakage";
                            break;
                        case "S":
                            GameInformation2.GetComponent<TextMeshProUGUI>().text = "2. CIST Category: Sabotage";
                            break;
                        case "T":
                            GameInformation2.GetComponent<TextMeshProUGUI>().text = "2. CIST Category: Tampering";
                            break;

                    }
                }

            }
        }
    }

    public void ChangeTile(int tileNo)
    {
        if (tileNo == 0)
        {
            GameDefenceCMessage.GetComponent<TextMeshProUGUI>().text = "";
        }
        rend.sprite = DefenceCIST_C[tileNo];
        whichTile = tileNo;
    }
}
