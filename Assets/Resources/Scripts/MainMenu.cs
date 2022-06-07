using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public GameObject GameInformation, Panel;
    public GameObject GameDefenceAllDMessage, AttackAnswerPanel;

    public void Awake()
    {
        GameDefenceAllDMessage = GameObject.Find("DefenceAllText");
        GameInformation = GameObject.Find("CISTGamePlay");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void OpenPanel()
    {
        if (GameControl.showAnswer)
        {
            //if (Panel != null)
            //{
            if (!Panel.activeSelf)
            {
                GameDefenceAllDMessage.GetComponent<TextMeshProUGUI>().text = "Click on button to see defence for this attack by stage location";
                Panel.SetActive(true);
                GameInformation.GetComponent<TextMeshProUGUI>().text = "See all the possible answers for the attack in the panel to the right";
            }
            else
            {
                Panel.SetActive(false);
                GameInformation.GetComponent<TextMeshProUGUI>().text = "Click Button 1. to start your next defence from attack";
            }
            //}
        }
        else
        {
            GameInformation.GetComponent<TextMeshProUGUI>().text = "Answers only avialble after you have completed the attack";
        }
    }
}
