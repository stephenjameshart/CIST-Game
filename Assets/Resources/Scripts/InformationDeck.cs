using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformationDeck : MonoBehaviour
{
    private Sprite[] InformationCards;
    private SpriteRenderer rend;
    private int whichTile = 0;
    public GameObject GameInfoAttackMessage;

    public void Awake()
    {
        GameInfoAttackMessage = GameObject.Find("InformationText");
    }

    // Use this for initialization
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        InformationCards = Resources.LoadAll<Sprite>("InformationCards/");
        rend.sprite = InformationCards[whichTile];
    }

    private void OnMouseDown()
    {
        
    if (whichTile < 1)
        {
            whichTile += 1;
            if (GameControl.InfoAttackMessage == "")
            {
                GameInfoAttackMessage.GetComponent<TextMeshProUGUI>().text = "Click on Information Card during attack to see further information on root of vulnerability of current attack";
            } 
            else
            {
                GameInfoAttackMessage.GetComponent<TextMeshProUGUI>().text = GameControl.InfoAttackMessage;
            }           
        }
        else
        {
            whichTile = 0;
            GameInfoAttackMessage.GetComponent<TextMeshProUGUI>().text = "";
        }       
    rend.sprite = InformationCards[whichTile];
       
    }
    public void ChangeTile(int tileNo, string infoMessage)
    {
        GameInfoAttackMessage.GetComponent<TextMeshProUGUI>().text = infoMessage;
        rend.sprite = InformationCards[tileNo];
    }
}
