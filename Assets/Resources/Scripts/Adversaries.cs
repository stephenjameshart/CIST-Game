using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Adversaries : MonoBehaviour
{
    private Sprite[] AdversarySuit;
    private SpriteRenderer rend;
    private int whichTile = 0;
    public GameObject GameInformation;
    public GameObject GameAdversariesMessage;
    private string messageText;
    private string messageText2;

    public void Awake()
    {
        GameAdversariesMessage = GameObject.Find("AdversariesText");
        GameInformation = GameObject.Find("Step03Text");
    }
    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        AdversarySuit = Resources.LoadAll<Sprite>("AdversariesCards/");
        rend.sprite = AdversarySuit[whichTile];
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
            switch (whichTile)
            {
                case 0:
                    GameInformation.GetComponent<TextMeshProUGUI>().text = "3. Select Adversary: Not Selected";
                    GameControl.AdversarySkillLevel = 0;
                    GameAdversariesMessage.GetComponent<TextMeshProUGUI>().text = "";
                    rend.sprite = AdversarySuit[whichTile];
                    break;
                case 1:
                    messageText = "<align=center>Class 1\n</align=center>A small group of curious hackers\nGoal: Challenge/Presitge\nAttack Level can wage: 1 - 2 ";
                    messageText2 = "<align=center>Class 1\n</align=center>A small group of curious hackers\nGoal: Challenge/Presitge\nAttack Level\ncan wage: 1 - 2 ";
                    GameInformation.GetComponent<TextMeshProUGUI>().text = "3. Selected Adversary: " + messageText;
                    GameControl.AdversarySkillLevel = 2;
                    GameAdversariesMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                    rend.sprite = AdversarySuit[whichTile];
                    break;
                case 2:
                    messageText = "<align=center>Class 2\n</align=center>An academic research group\nGoal: Publicity\nAttack Level can wage: 1 - 3";
                    messageText2 = "<align=center>Class 2\n</align=center>An academic research group\nGoal: Publicity\nAttack Level\ncan wage: 1 - 3";
                    GameInformation.GetComponent<TextMeshProUGUI>().text = "3. Selected Adversary: " + messageText;
                    GameControl.AdversarySkillLevel = 3;
                    GameAdversariesMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                    rend.sprite = AdversarySuit[whichTile];
                    break;
                case 3:
                    messageText = "<align=center>Class 3\n</align=center>An organised criminal gang\nGoal: Money\nAttack Level can wage: 1 - 3";
                    messageText2 = "<align=center>Class 3\n</align=center>An organised criminal gang\nGoal: Money\nAttack Level\ncan wage: 1 - 3";
                    GameInformation.GetComponent<TextMeshProUGUI>().text = "3. Selected Adversary: " + messageText;
                    GameControl.AdversarySkillLevel = 3;
                    GameAdversariesMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                    rend.sprite = AdversarySuit[whichTile];
                    break;
                case 4:
                    messageText = "<align=center>Class 4\n</align=center>A state-funded organisation\nGoal: Varies\nAttack Level can wage: 1 - 4";
                    messageText2 = "<align=center>Class 4\n</align=center>A state-funded organisation\nGoal: Varies\nAttack Level\ncan wage: 1 - 4";
                    GameInformation.GetComponent<TextMeshProUGUI>().text = "3. Selected Adversary: " + messageText;
                    GameControl.AdversarySkillLevel = 4;
                    GameAdversariesMessage.GetComponent<TextMeshProUGUI>().text = messageText2;
                    rend.sprite = AdversarySuit[whichTile];
                    break;
            }

        }
    }
        public void ChangeTile(int tileNo)
        {
            if (tileNo == 0)
            {
                GameAdversariesMessage.GetComponent<TextMeshProUGUI>().text = "";
            }
            rend.sprite = AdversarySuit[tileNo];
            whichTile = tileNo;
        }

}
