using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefenceI : MonoBehaviour
{
    private Sprite[] DefenceCIST_I;
    private SpriteRenderer rend;
    private int whichTile = 0;
    public GameObject CISTInfo;
    public GameObject GameInformation;
    public GameObject GameInformation2;
    public GameObject GameDefenceIMessage;
    private string messageText;
    private string messageText2;

    public void Awake()
    {
        GameDefenceIMessage = GameObject.Find("DefenceInfoLeakageText");
        GameInformation = GameObject.Find("Step05Text");
        GameInformation2 = GameObject.Find("Step02Text");
    }
    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        DefenceCIST_I = Resources.LoadAll<Sprite>("DefenceCards/InformationLeakage/");
        rend.sprite = DefenceCIST_I[whichTile];
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
            rend.sprite = DefenceCIST_I[whichTile];
            //GameInformation = GameObject.Find("Step05Text");
            if (whichTile < 1)
            {
                GameInformation.GetComponent<TextMeshProUGUI>().text = "5. Select Defence: Not Selected";
                GameDefenceIMessage.GetComponent<TextMeshProUGUI>().text = "";
                GameControl.CISTCategoryDefence = "";
            }
            else
            {
                switch (whichTile)
                {
                    case 1:
                        messageText = "<align=center>5.Select Defence: Information Leakage\n</align=center>" +
                        "IP Piracy: Prevention Method: Split Manufacturing";
                        messageText2 = "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Split Manufacturing";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceIMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 10;
                        break;
                    case 2:
                        messageText = "<align=center>5.Select Defence: Information Leakage\n</align=center>" +
                        "IP Piracy: Prevention Method: Hardware Obfuscation - IC Camouflaging";
                        messageText2 = "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Hardware Obfuscation - IC Camouflaging";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceIMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 11;
                        break;
                    case 3:
                        messageText = "<align=center>5.Select Defence: Information Leakage\n</align=center>" +
                        "IP Piracy: Prevention Method: Hardware Obfuscation - Combinational Logic Locking";
                        messageText2 = "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                       "IP Piracy: Prevention Method: Hardware Obfuscation - Combinational Logic Locking";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceIMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 12;
                        break;
                    case 4:
                        messageText = "<align=center>5.Select Defence: Information Leakage\n</align=center>" +
                        "IP Piracy: Prevention Method: Hardware Obfuscation - Sequential Logic Locking";
                        messageText2 = "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Hardware Obfuscation - Sequential Logic Locking";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceIMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 13;
                        break;
                    case 5:
                        messageText = "<align=center>5.Select Defence: Information Leakage\n</align=center>" +
                        "IP Piracy: Detection Method: Watermarking - Digital Watermarking to hide information in the signal";
                        messageText2 = "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Detection Method: Watermarking - Digital Watermarking to hide information in the signal";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceIMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 14;
                        break;
                    case 6:
                        messageText = "<align=center>5.Select Defence: Information Leakage\n</align=center>" +
                        "SCA Detection Method: Side Channel Analysis - Leakage reduction approaches; Noise injection methods";
                        messageText2 = "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "SCA Detection Method: Side Channel Analysis - Leakage reduction approaches; Noise injection methods";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceIMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 15;
                        break;
                    case 7:
                        messageText = "<align=center>5.Select Defence: Information Leakage\n</align=center>" +
                        "SCA Detection Method: Side Channel Analysis - Architecture Optimisation";
                        messageText2 = "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                       "SCA Detection Method: Side Channel Analysis - Architecture Optimisation";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceIMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 16;
                        break;
                    case 8:
                        messageText = "<align=center>5.Select Defence: Information Leakage\n</align=center>" +
                        "SCA Prevention Method: Speculative Execution Attacks - Bounds check bypass; Branch target injection; Rogue data cache load";
                        messageText2 = "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "SCA Prevention Method: Speculative Execution Attacks - Bounds check bypass; Branch target injection; Rogue data cache load";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceIMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 17;
                        break;
                    case 9:
                        messageText = "<align=center>5.Select Defence: Information Leakage\n</align=center>" +
                        "Prevention Method: PUF Modelling Attacks - Response Obfuscation, Multi-PUF Design";
                        messageText2 = "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "Prevention Method: PUF Modelling Attacks - Response Obfuscation, Multi-PUF Design";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceIMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 18;
                        break;
                }
            }
            CISTInfo = GameObject.Find("DefenceCounterfeiting");
            CISTInfo.GetComponent<DefenceC>().ChangeTile(0);
            CISTInfo = GameObject.Find("DefenceSabotage");
            CISTInfo.GetComponent<DefenceS>().ChangeTile(0);
            CISTInfo = GameObject.Find("DefenceTampering");
            CISTInfo.GetComponent<DefenceT>().ChangeTile(0);
            GameControl.CISTCategoryDefence = "I";
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
            GameDefenceIMessage.GetComponent<TextMeshProUGUI>().text = "";
        }
        rend.sprite = DefenceCIST_I[tileNo];
        whichTile = tileNo;
    }
}
