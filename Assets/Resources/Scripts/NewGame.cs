using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NewGame : MonoBehaviour
{
    public int whichTile = 0;
    public  GameObject CISTInfo;
    public GameObject GameInformation;

    // Reset for new game
    public void Restart() 
    {
        GameControl.currentAttack = 1;
        GameControl.numberofAttacks = 1;
        NextAttack();
    }

    public void NextAttack()
    {
        CISTInfo = GameObject.Find("AdversariesDeck");
        CISTInfo.GetComponent<Adversaries>().ChangeTile(0);
        CISTInfo = GameObject.Find("CISTCatTileC");
        CISTInfo.GetComponent<CounterfeitCat>().ChangeTile(0);
        CISTInfo = GameObject.Find("CISTCatTileI");
        CISTInfo.GetComponent<InfoLeakageCat>().ChangeTile(0);
        CISTInfo = GameObject.Find("CISTCatTileS");
        CISTInfo.GetComponent<SabotageCat>().ChangeTile(0);
        CISTInfo = GameObject.Find("CISTCatTileT");
        CISTInfo.GetComponent<TamperingCat>().ChangeTile(0);
        CISTInfo = GameObject.Find("DefenceCounterfeiting");
        CISTInfo.GetComponent<DefenceC>().ChangeTile(0);
        CISTInfo = GameObject.Find("DefenceInformationLeakage");
        CISTInfo.GetComponent<DefenceI>().ChangeTile(0);
        CISTInfo = GameObject.Find("DefenceSabotage");
        CISTInfo.GetComponent<DefenceS>().ChangeTile(0);
        CISTInfo = GameObject.Find("DefenceTampering");
        CISTInfo.GetComponent<DefenceT>().ChangeTile(0);
        CISTInfo = GameObject.Find("InformationDeck");
        CISTInfo.GetComponent<InformationDeck>().ChangeTile(0, "");
        CISTInfo = GameObject.Find("01Stage");
        CISTInfo.GetComponent<Stage01>().ChangeTile(0);
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
        CISTInfo = GameObject.Find("Tile17E01");
        CISTInfo.GetComponent<EntityTile01>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile10E02");
        CISTInfo.GetComponent<EntityTile02>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile21E03");
        CISTInfo.GetComponent<EntityTile03>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile24E04");
        CISTInfo.GetComponent<EntityTile04>().ChangeTile(0);
        // Process Tiles
        CISTInfo = GameObject.Find("Tile09P01");
        CISTInfo.GetComponent<ProcessTile01>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile11P02");
        CISTInfo.GetComponent<ProcessTile02>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile12P03");
        CISTInfo.GetComponent<ProcessTile03>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile13P04");
        CISTInfo.GetComponent<ProcessTile04>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile14P05");
        CISTInfo.GetComponent<ProcessTile05>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile15P06");
        CISTInfo.GetComponent<ProcessTile06>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile16P07");
        CISTInfo.GetComponent<ProcessTile07>().ChangeTile(0);
        // Stakeholder Tiles
        CISTInfo = GameObject.Find("Tile01S01");
        CISTInfo.GetComponent<StakeholderTile01>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile03S02");
        CISTInfo.GetComponent<StakeholderTile02>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile05S03");
        CISTInfo.GetComponent<StakeholderTile03>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile07S04");
        CISTInfo.GetComponent<StakeholderTile04>().ChangeTile(0);
        CISTInfo = GameObject.Find("Tile08S05");
        CISTInfo.GetComponent<StakeholderTile05>().ChangeTile(0);
        GameInformation = GameObject.Find("CISTGamePlay");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "New Game";
        GameInformation = GameObject.Find("Step01Text");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "1. Click to start attack: Not Selected";
        GameInformation = GameObject.Find("Step02Text");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "2. CIST Category: Not Selected";
        GameInformation = GameObject.Find("Step03Text");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "3. Select Adversary: Not Selected";
        GameInformation = GameObject.Find("Step04Text");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "4. Select Attack Location: Not Selected";
        GameInformation = GameObject.Find("Step05Text");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "5. Select Defence: Not Selected";
        GameInformation = GameObject.Find("Step06Text");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "6. Analysis of Attack & Defence: Not Completed";
        GameInformation = GameObject.Find("Step00Info");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "Information\nClick on Cards";
        // may need to change this
        GameControl.attackStarted = false;
        GameControl.showAnswer = false;
        GameControl.gameOver = false;
        GameControl.CISTCategoryAttack = "";
        GameControl.CISTCategoryDefence = "";
        GameControl.AttackStage = 0;
        GameControl.AdversarySkillLevel = 0;
        GameControl.DefenceID = 0;
        GameControl.CorrectCISTCategory = false;
        GameControl.gamePoints = 0;
        GameInformation = GameObject.Find("StartAttackBtnText");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "1. Start Attack";
        GameControl.InfoAttackMessage = "";
        GameInformation = GameObject.Find("Step01P");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "1. Click Button\nfor first\nAttack\n Number " + GameControl.currentAttack;
        GameControl.Cscore = 0;
        GameControl.Iscore = 0;
        GameControl.Sscore = 0;
        GameControl.Tscore = 0;
        GameControl.ScoreTotal = 0;
        GameInformation = GameObject.Find("textCScore");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "0";
        GameInformation = GameObject.Find("textIScore");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "0";
        GameInformation = GameObject.Find("textSScore");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "0";
        GameInformation = GameObject.Find("textTScore");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "0";
        GameInformation = GameObject.Find("textTotalScore");
        GameInformation.GetComponent<TextMeshProUGUI>().text = "0";
        GameInformation = GameObject.Find("textAttacksLeft");
        GameControl.AttacksLeft = GameControl.NumAttacks;
        GameInformation.GetComponent<TextMeshProUGUI>().text = "" + GameControl.NumAttacks;
        //GameObject.Find("AnswerBtn").GetComponent<Button>().gameObject.SetActive(false);
    }
    public void TurnOverTiles()
    {
        CISTInfo = GameObject.Find("AdversariesDeck");
        CISTInfo.GetComponent<Adversaries>().ChangeTile(0);
        CISTInfo = GameObject.Find("CISTCatTileC");
        CISTInfo.GetComponent<CounterfeitCat>().ChangeTile(0);
        CISTInfo = GameObject.Find("CISTCatTileI");
        CISTInfo.GetComponent<InfoLeakageCat>().ChangeTile(0);
        CISTInfo = GameObject.Find("CISTCatTileS");
        CISTInfo.GetComponent<SabotageCat>().ChangeTile(0);
        CISTInfo = GameObject.Find("CISTCatTileT");
        CISTInfo.GetComponent<TamperingCat>().ChangeTile(0);
        CISTInfo = GameObject.Find("DefenceCounterfeiting");
        CISTInfo.GetComponent<DefenceC>().ChangeTile(0);
        CISTInfo = GameObject.Find("DefenceInformationLeakage");
        CISTInfo.GetComponent<DefenceI>().ChangeTile(0);
        CISTInfo = GameObject.Find("DefenceSabotage");
        CISTInfo.GetComponent<DefenceS>().ChangeTile(0);
        CISTInfo = GameObject.Find("DefenceTampering");
        CISTInfo.GetComponent<DefenceT>().ChangeTile(0);
        CISTInfo = GameObject.Find("InformationDeck");
        CISTInfo.GetComponent<InformationDeck>().ChangeTile(0, "");
        CISTInfo = GameObject.Find("01Stage");
        CISTInfo.GetComponent<Stage01>().ChangeTile(0);
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