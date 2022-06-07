using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GetDefenceByCat : MonoBehaviour
{

    public GameObject GameInformation2, CISTInfo;
    public GameObject GameDefenceAllDMessage;
    public GameObject GameInformation;
    public int CardNo;
    public string temp;

    public void Awake()
    {
        GameDefenceAllDMessage = GameObject.Find("DefenceAllText");
        GameInformation = GameObject.Find("CISTGamePlay");
    }
    
    public void GetDefenceCard()
    {
        GameDefenceAllDMessage.GetComponent<TextMeshProUGUI>().text = "DEFENCE\n" + GetComponent<GameControl>().GetDefenceCard(GameControl.currentAttackID, CardNo).description;   
    }
    
}
