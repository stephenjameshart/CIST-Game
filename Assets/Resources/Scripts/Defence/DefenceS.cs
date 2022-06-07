using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefenceS : MonoBehaviour
{
    private Sprite[] DefenceCIST_S;
    private SpriteRenderer rend;
    private int whichTile = 0;
    public GameObject CISTInfo;
    public GameObject GameInformation;
    public GameObject GameInformation2;
    public GameObject GameDefenceSMessage;
    private string messageText;
    private string messageText2;

    public void Awake()
    {
        GameDefenceSMessage = GameObject.Find("DefenceSabotageText");
        GameInformation = GameObject.Find("Step05Text");
        GameInformation2 = GameObject.Find("Step02Text");
    }
    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        DefenceCIST_S = Resources.LoadAll<Sprite>("DefenceCards/Sabotage/");
        rend.sprite = DefenceCIST_S[whichTile];
    }

    private void OnMouseDown()
    {
        if (GameControl.attackStarted)
        {
            if (whichTile < 4)
            {
                whichTile += 1;
            }
            else
            {
                whichTile = 0;
            }
            rend.sprite = DefenceCIST_S[whichTile];
            //GameInformation = GameObject.Find("Step05Text");
            if (whichTile < 1)
            {
                GameInformation.GetComponent<TextMeshProUGUI>().text = "5. Select Defence: Not Selected";
                GameDefenceSMessage.GetComponent<TextMeshProUGUI>().text = "";
                GameControl.CISTCategoryDefence = "";
            }
            else
            {
                switch (whichTile)
                {
                    case 1:
                        messageText = "<align=center>5.Select Defence: Sabotage\n</align=center>" +
                        "Detection Method: Monitoring the rate of cache misses for unusual peaks using";
                        messageText2 = "<align=center>Countermeasures\nSabotage\n\n</align=center>" +
                       "Detection Method: Monitoring the rate of cache misses for unusual peaks using";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceSMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 19;
                        break;
                    case 2:
                        messageText = "<align=center>5.Select Defence: Sabotage\n</align=center>" +
                        "Prevention or Detection Methods: Cyber Physical Attacks Monitor predefined constraints; " +
                        "Strict one-way communication from IC to cyber physical system command centre";
                        messageText2 = "<align=center>Countermeasures\nSabotage\n\n</align=center>" +
                       "Prevention or Detection Methods: Cyber Physical Attacks Monitor predefined constraints; " +
                       "Strict one-way communication from IC to cyber physical system command centre";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceSMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 20;
                        break;
                    case 3:
                        messageText = "<align=center>5.Select Defence: Sabotage\n</align=center>" +
                        "Prevention Method: Increase memory refresh frequency, use less leaky memory technology";
                        messageText2 = "<align=center>Countermeasures\nSabotage\n\n</align=center>" +
                        "Prevention Method: Increase memory refresh frequency, use less leaky memory technology";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceSMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 21;
                        break;
                    case 4:
                        messageText = "<align=center>5.Select Defence: Sabotage\n</align=center>" +
                        "Prevention or Detection Methods: Tamper-Proof Design";
                        messageText2 = "<align=center>Countermeasures\nSabotage\n\n</align=center>" +
                        "Prevention or Detection Methods: Tamper-Proof Design";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceSMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 22;
                        break;
                }

            }
            CISTInfo = GameObject.Find("DefenceCounterfeiting");
            CISTInfo.GetComponent<DefenceC>().ChangeTile(0);
            CISTInfo = GameObject.Find("DefenceInformationLeakage");
            CISTInfo.GetComponent<DefenceI>().ChangeTile(0);
            CISTInfo = GameObject.Find("DefenceTampering");
            CISTInfo.GetComponent<DefenceT>().ChangeTile(0);
            GameControl.CISTCategoryDefence = "S";
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
            GameDefenceSMessage.GetComponent<TextMeshProUGUI>().text = "";
        }
        rend.sprite = DefenceCIST_S[tileNo];
        whichTile = tileNo;
    }
}
