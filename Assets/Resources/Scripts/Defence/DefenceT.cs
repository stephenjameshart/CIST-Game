using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefenceT : MonoBehaviour
{
    private Sprite[] DefenceCIST_T;
    private SpriteRenderer rend;
    private int whichTile = 0;
    public GameObject CISTInfo;
    public GameObject GameInformation;
    public GameObject GameInformation2;
    public GameObject GameDefenceTMessage;
    private string messageText;
    private string messageText2;

    public void Awake()
    {
        GameDefenceTMessage = GameObject.Find("DefenceTamperingText");
        GameInformation = GameObject.Find("Step05Text");
        GameInformation2 = GameObject.Find("Step02Text");
    }
    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        DefenceCIST_T = Resources.LoadAll<Sprite>("DefenceCards/Tampering/");
        rend.sprite = DefenceCIST_T[whichTile];
    }

    private void OnMouseDown()
    {
        if (GameControl.attackStarted)
        {
            if (whichTile < 6)
            {
                whichTile += 1;
            }
            else
            {
                whichTile = 0;
            }
            rend.sprite = DefenceCIST_T[whichTile];
            //GameInformation = GameObject.Find("Step05Text");
            if (whichTile < 1)
            {
                GameInformation.GetComponent<TextMeshProUGUI>().text = "5. Select Defence: Not Selected";
                GameDefenceTMessage.GetComponent<TextMeshProUGUI>().text = "";
                GameControl.CISTCategoryDefence = "";
            }
            else
            {
                switch (whichTile)
                {
                    case 1:
                        messageText = "<align=center>5.Select Defence: Tampering\n</align=center>" +
                        "Prevention Method: IP encrypted so that even if the IC is physically attacked, its IP cannot be deciphered";
                        messageText2 = "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: IP encrypted so that even if the IC is physically attacked, its IP cannot be deciphered";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceTMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 28;
                        break;
                    case 2:
                        messageText = "<align=center>5.Select Defence: Tampering\n</align=center>" +
                        "Prevention Method: Hardware Trojan Insert\nReplace functional cells to implement an LFSR/MISR-like circuit that generates a digital signature";
                        messageText2 = "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: Hardware Trojan Insert\nReplace functional cells to implement an LFSR/MISR-like circuit that generates a digital signature";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceTMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 23;
                        break;
                    case 3:
                        messageText = "<align=center>5.Select Defence: Tampering\n</align=center>" +
                        "Prevention Method: Hardware Trojan Insert\nPre-silicon detection";
                        messageText2 = "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: Hardware Trojan Insert\nPre-silicon detection";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceTMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 24;
                        break;
                    case 4:
                        messageText = "<align=center>5.Select Defence: Tampering\n</align=center>" +
                        "Prevention Method: Hardware Trojan Insert\nPost-silicon detection";
                        messageText2 = "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: Hardware Trojan Insert\nPost-silicon detection";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceTMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 25;
                        break;
                    case 5:
                        messageText = "<align=center>5.Select Defence: Tampering\n</align=center>" +
                        "Detection Method: Hardware Trojan Insert\nRuntime detection";
                        messageText2 = "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                       "Detection Method: Hardware Trojan Insert\nRuntime detection";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceTMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 26;
                        break;
                    case 6:
                        messageText = "<align=center>5.Select Defence: Tampering\n</align=center>" +
                        "Prevention Method: Fault Injections Attacks\nTamper Resistant Techniques";
                        messageText2 = "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: Fault Injections Attacks\nTamper Resistant Techniques";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = messageText;
                        GameDefenceTMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                        GameControl.DefenceID = 27;
                        break;
                }
            }
            CISTInfo = GameObject.Find("DefenceCounterfeiting");
            CISTInfo.GetComponent<DefenceC>().ChangeTile(0);
            CISTInfo = GameObject.Find("DefenceInformationLeakage");
            CISTInfo.GetComponent<DefenceI>().ChangeTile(0);
            CISTInfo = GameObject.Find("DefenceSabotage");
            CISTInfo.GetComponent<DefenceS>().ChangeTile(0);
            GameControl.CISTCategoryDefence = "T";
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
            GameDefenceTMessage.GetComponent<TextMeshProUGUI>().text = "";
        }
        rend.sprite = DefenceCIST_T[tileNo];
        whichTile = tileNo;
    }
}
