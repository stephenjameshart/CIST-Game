using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{
    public GameObject CISTInfo;
    public GameObject GameInformation;
    public GameObject Button01Information;
    public GameObject Step01Information;
    public GameObject Step02Information;
    public GameObject Step03Information;
    public GameObject Step04Information;
    public GameObject Step05Information;
    public GameObject Step06Information;
    public GameObject NewGame, Panel, PanelHelp;
    public List<Attack> attacks = new List<Attack>();
    public List<Defence> defence = new List<Defence>();
    public static bool attackStarted = false;
    public static bool gameOver = false;
    // Attack Number as start point increase from 1 to test
    public static int currentAttack = 1;
    public static int currentAttackAnswer = 1;
    public static int numberofAttacks = 1;
    public static string CISTCategoryAttack = "";
    public static string CISTCategoryDefence = "";
    public static int AttackStage = 0;
    public static int AdversarySkillLevel = 0;
    public static int DefenceID = 0;
    public static bool CorrectCISTCategory = false;
    public string AnalysisCISTCat = "";
    public static bool CorrectAdversary = false;
    public string AnalysisAdversary = "";
    public static bool CorrectStage = false;
    public string AnalysisStage = "";
    public static bool CorrectDefence = false;
    public string AnalysisDefence = "";
    public Defence temp;
    public static int currentAttackID;
    public static bool SucessfulDefence = false;
    public string AnalysisSummary = "";
    public string gamePointsMsg = "";
    public static int gamePoints = 0;
    public static bool optionsNotComplete = false;
    public static string InfoAttackMessage = "";
    public GameObject GameInfoAttackMessage;
    public GameObject GameStep01Message;
    public static int Cscore = 0;
    public static int Iscore = 0;
    public static int Sscore = 0;
    public static int Tscore = 0;
    public static int ScoreTotal = 0;
    public static int AttacksLeft;
    public GameObject CtextScore;
    public GameObject ItextScore;
    public GameObject StextScore;
    public GameObject TtextScore;
    public GameObject AlltextScore;
    public GameObject NoAttacksLeft;
    public static int NumAttacks = 0;
    public GameObject buttonAns;
    public static bool showAnswer = false;
    public static GameObject Stage01C, Stage01I, Stage01S, Stage01T;
    public static GameObject Stage02C, Stage02I, Stage02S, Stage02T;
    public static GameObject Stage03C, Stage03I, Stage03S, Stage03T;
    public static GameObject Stage04C, Stage04I, Stage04S, Stage04T;
    public static GameObject Stage05C, Stage05I, Stage05S, Stage05T;
    public static GameObject Stage06C, Stage06I, Stage06S, Stage06T;
    public static GameObject minAttackLevel, Class01, Class02, Class03, Class04, AdText;
    public GameObject Stage01C05, Stage01C06, Stage01C07, Stage01C08, Stage01C09, Stage01C10, Stage01C11, Stage01C12, Stage01C13;
    public GameObject Stage02C05, Stage02C06, Stage02C07, Stage02C08, Stage02C09, Stage02C10, Stage02C11, Stage02C12, Stage02C13;
    public GameObject Stage03C05, Stage03C06, Stage03C07, Stage03C08, Stage03C09, Stage03C10, Stage03C11, Stage03C12, Stage03C13;
    public GameObject Stage04C05, Stage04C06, Stage04C07, Stage04C08, Stage04C09, Stage04C10, Stage04C11, Stage04C12, Stage04C13;
    public GameObject Stage05C05, Stage05C06, Stage05C07, Stage05C08, Stage05C09, Stage05C10, Stage05C11, Stage05C12, Stage05C13;
    public GameObject Stage06C05, Stage06C06, Stage06C07, Stage06C08, Stage06C09, Stage06C10, Stage06C11, Stage06C12, Stage06C13;
    public GameObject GameDefenceAllDMessage, AttackAnswerPanel, AdminButtons;

    private void Awake()
    {
        BuildAttackDatabase();
        AttacksLeft = attacks.Count;
        NumAttacks = attacks.Count;
        BuildDefenceDatabase();
        GameInformation = GameObject.Find("CISTGamePlay");
        Button01Information = GameObject.Find("StartAttackBtnText");
        Step01Information = GameObject.Find("Step01Text");
        Step02Information = GameObject.Find("Step02Text");
        Step03Information = GameObject.Find("Step03Text");
        Step04Information = GameObject.Find("Step04Text");
        Step05Information = GameObject.Find("Step05Text");
        Step06Information = GameObject.Find("Step06Text");
        GameInfoAttackMessage = GameObject.Find("Step00Info");
        GameStep01Message = GameObject.Find("Step01P");
        GameStep01Message.GetComponent<TextMeshProUGUI>().text = "1. Click Button\nfor first\nAttack\n Number " + GameControl.currentAttack;
        CtextScore = GameObject.Find("textCScore");
        ItextScore = GameObject.Find("textIScore");
        StextScore = GameObject.Find("textSScore");
        TtextScore = GameObject.Find("textTScore");
        AlltextScore = GameObject.Find("textTotalScore");
        NoAttacksLeft = GameObject.Find("textAttacksLeft");
        NoAttacksLeft.GetComponent<TextMeshProUGUI>().text = "" + AttacksLeft;
        // Answers
        Stage01C = GameObject.Find("Stage01C");
        Stage01I = GameObject.Find("Stage01I");
        Stage01S = GameObject.Find("Stage01S");
        Stage01T = GameObject.Find("Stage01T");

        Stage02C = GameObject.Find("Stage02C");
        Stage02I = GameObject.Find("Stage02I");
        Stage02S = GameObject.Find("Stage02S");
        Stage02T = GameObject.Find("Stage02T");

        Stage03C = GameObject.Find("Stage03C");
        Stage03I = GameObject.Find("Stage03I");
        Stage03S = GameObject.Find("Stage03S");
        Stage03T = GameObject.Find("Stage03T");

        Stage04C = GameObject.Find("Stage04C");
        Stage04I = GameObject.Find("Stage04I");
        Stage04S = GameObject.Find("Stage04S");
        Stage04T = GameObject.Find("Stage04T");

        Stage05C = GameObject.Find("Stage05C");
        Stage05I = GameObject.Find("Stage05I");
        Stage05S = GameObject.Find("Stage05S");
        Stage05T = GameObject.Find("Stage05T");

        Stage06C = GameObject.Find("Stage06C");
        Stage06I = GameObject.Find("Stage06I");
        Stage06S = GameObject.Find("Stage06S");
        Stage06T = GameObject.Find("Stage06T");

        minAttackLevel = GameObject.Find("minAttackLevel");
        Class01 = GameObject.Find("Class01");
        Class02 = GameObject.Find("Class02");
        Class03 = GameObject.Find("Class03");
        Class04 = GameObject.Find("Class04");
        AdText = GameObject.Find("AdversaryTxt");

        Stage01C05 = GameObject.Find("BtnStage105"); 
        Stage02C05 = GameObject.Find("BtnStage205");
        Stage03C05 = GameObject.Find("BtnStage305");
        Stage04C05 = GameObject.Find("BtnStage405");
        Stage05C05 = GameObject.Find("BtnStage505");
        Stage06C05 = GameObject.Find("BtnStage605");

        Stage01C06 = GameObject.Find("BtnStage106");
        Stage02C06 = GameObject.Find("BtnStage206");
        Stage03C06 = GameObject.Find("BtnStage306");
        Stage04C06 = GameObject.Find("BtnStage406");
        Stage05C06 = GameObject.Find("BtnStage506");
        Stage06C06 = GameObject.Find("BtnStage606");

        Stage01C07 = GameObject.Find("BtnStage107");
        Stage02C07 = GameObject.Find("BtnStage207");
        Stage03C07 = GameObject.Find("BtnStage307");
        Stage04C07 = GameObject.Find("BtnStage407");
        Stage05C07 = GameObject.Find("BtnStage507");
        Stage06C07 = GameObject.Find("BtnStage607");

        Stage01C08 = GameObject.Find("BtnStage108");
        Stage02C08 = GameObject.Find("BtnStage208");
        Stage03C08 = GameObject.Find("BtnStage308");
        Stage04C08 = GameObject.Find("BtnStage408");
        Stage05C08 = GameObject.Find("BtnStage508");
        Stage06C08 = GameObject.Find("BtnStage608");

        Stage01C09 = GameObject.Find("BtnStage109");
        Stage02C09 = GameObject.Find("BtnStage209");
        Stage03C09 = GameObject.Find("BtnStage309");
        Stage04C09 = GameObject.Find("BtnStage409");
        Stage05C09 = GameObject.Find("BtnStage509");
        Stage06C09 = GameObject.Find("BtnStage609");

        Stage01C10 = GameObject.Find("BtnStage110");
        Stage02C10 = GameObject.Find("BtnStage210");
        Stage03C10 = GameObject.Find("BtnStage310");
        Stage04C10 = GameObject.Find("BtnStage410");
        Stage05C10 = GameObject.Find("BtnStage510");
        Stage06C10 = GameObject.Find("BtnStage610");

        Stage01C11 = GameObject.Find("BtnStage111");
        Stage02C11 = GameObject.Find("BtnStage211");
        Stage03C11 = GameObject.Find("BtnStage311");
        Stage04C11 = GameObject.Find("BtnStage411");
        Stage05C11 = GameObject.Find("BtnStage511");
        Stage06C11 = GameObject.Find("BtnStage611");

        Stage01C12 = GameObject.Find("BtnStage112");
        Stage02C12 = GameObject.Find("BtnStage212");
        Stage03C12 = GameObject.Find("BtnStage312");
        Stage04C12 = GameObject.Find("BtnStage412");
        Stage05C12 = GameObject.Find("BtnStage512");
        Stage06C12 = GameObject.Find("BtnStage612");

        Stage01C13 = GameObject.Find("BtnStage113");
        Stage02C13 = GameObject.Find("BtnStage213");
        Stage03C13 = GameObject.Find("BtnStage313");
        Stage04C13 = GameObject.Find("BtnStage413");
        Stage05C13 = GameObject.Find("BtnStage513");
        Stage06C13 = GameObject.Find("BtnStage613");

        GameDefenceAllDMessage = GameObject.Find("DefenceAllText");
        AttackAnswerPanel = GameObject.Find("AttackAnswer");
    }

    public void Start()
    {
        //   Panel.SetActive(false);
        //    Panel.SetActive(true
        //    );
        //loadAnswers();
    }

    public void StartAttack()
    {
        if (!gameOver)
        {
            
            if (attackStarted == false)
            {
                if (currentAttack > attacks.Count)
                {
                    GameInformation.GetComponent<TextMeshProUGUI>().text = "Game Over last attack completed";
                    gameOver = true;
                }
                else
                {
                    //NewGame.GetComponent<NewGame>().TurnOverTiles();
                    showAnswer = false;
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
                    attackStarted = true;
                    CISTCategoryAttack = "";
                    CISTCategoryDefence = "";
                    AttackStage = 0;
                    AdversarySkillLevel = 0;
                    DefenceID = 0;
                    CorrectCISTCategory = false;
                    Step01Information.GetComponent<TextMeshProUGUI>().text = GetAttack(currentAttack).description;
                    //loadAnswers();
                    GameInfoAttackMessage.GetComponent<TextMeshProUGUI>().text = "Click on the Information Card for Info on current Attack ID" + GetAttack(currentAttack).attackid; 
                    InfoAttackMessage = GetAttack(currentAttack).informationAttack;
                    Step02Information.GetComponent<TextMeshProUGUI>().text = "2. CIST Category: Not Selected";
                    Step03Information.GetComponent<TextMeshProUGUI>().text = "3. Select Adversary: Not Selected";
                    Step04Information.GetComponent<TextMeshProUGUI>().text = "4. Select Attack Location: Not Selected";
                    Step05Information.GetComponent<TextMeshProUGUI>().text = "5. Select Defence: Not Selected";
                    Step06Information.GetComponent<TextMeshProUGUI>().text = "6. Analysis of Attack & Defence: Not Completed";
                    Button01Information.GetComponent<TextMeshProUGUI>().text = "1. Attack " + numberofAttacks + " Started";
                    GameInformation.GetComponent<TextMeshProUGUI>().text = "Now select 2. CIST Category; 3. Adversay;\n 4. Location; and 5. Defence for this attack";
                }
            }
            else
            {
                GameInformation.GetComponent<TextMeshProUGUI>().text = "CIST Game Play: Attack Started and cannot start New Attack";
            }
        }
        else
        {
            GameInformation.GetComponent<TextMeshProUGUI>().text = "CIST Game Play: Last Attack " + attacks.Count + " Game Over";
        }

    }

    public void EndAttack()
    {
        if (GameControl.attackStarted)
        {
            if (!gameOver)
            {
                // Attack Evaluation
                optionsNotComplete = false;
                if (CISTCategoryAttack == "")
                {
                    optionsNotComplete = true;
                    Step02Information.GetComponent<TextMeshProUGUI>().text = "2. Warning! Missing CIST Category";
                }
                if (CISTCategoryDefence != CISTCategoryAttack)
                {
                    optionsNotComplete = true;
                    Step02Information.GetComponent<TextMeshProUGUI>().text = "2. Warning!: CIST Attack and Defence category must be the same";
                }
                if (AdversarySkillLevel == 0)
                {
                    optionsNotComplete = true;
                    Step03Information.GetComponent<TextMeshProUGUI>().text = "3. Warning! Missing Select Adversary";
                }
                if (AttackStage == 0)
                {
                    optionsNotComplete = true;
                    Step04Information.GetComponent<TextMeshProUGUI>().text = "4. Warning! Missing Attack Location";
                }
                if (DefenceID == 0)
                {
                    optionsNotComplete = true;
                    Step05Information.GetComponent<TextMeshProUGUI>().text = "5. Warning! Missing Defence";
                }


                if (optionsNotComplete)
                {
                    Step06Information.GetComponent<TextMeshProUGUI>().text = "Warning! Select missing Options";
                }
                else
                {
                    Button01Information.GetComponent<TextMeshProUGUI>().text = "1. Attack " + numberofAttacks + " Ended";
                    // 2. Check CIST Category

                    CorrectCISTCategory = false;
                    switch (CISTCategoryAttack)
                    {
                        case "C":
                            CorrectCISTCategory = (GetAttack(currentAttack).counterfeiting);
                            break;
                        case "I":
                            CorrectCISTCategory = (GetAttack(currentAttack).informationleakage);
                            break;
                        case "S":
                            CorrectCISTCategory = (GetAttack(currentAttack).sabotage);
                            break;
                        case "T":
                            CorrectCISTCategory = (GetAttack(currentAttack).tampering);
                            break;
                    }
                    if (CorrectCISTCategory)
                    {
                        AnalysisCISTCat = "2. Correct CIST Attack Category? Yes";
                    }
                    else
                    {
                        AnalysisCISTCat = "2. Correct CIST Attack Category? No";
                    }
                    // 3. Check Adversary
                    CorrectAdversary = false;
                    CorrectAdversary = (AdversarySkillLevel >= GetAttack(currentAttack).attackdifficulty);
                    if (CorrectAdversary)
                    {
                        AnalysisAdversary = "3. Correct Adversary Capability? Yes";
                    }
                    else
                    {
                        AnalysisAdversary = "3. Correct Adversary Capability? No";
                    }
                    // 4. Attack Location Correct?
                    CorrectStage = false;
                    switch (AttackStage)
                    {
                        case 1:
                            CorrectStage = (GetAttack(currentAttack).stage1);
                            break;
                        case 2:
                            CorrectStage = (GetAttack(currentAttack).stage2);
                            break;
                        case 3:
                            CorrectStage = (GetAttack(currentAttack).stage3);
                            break;
                        case 4:
                            CorrectStage = (GetAttack(currentAttack).stage4);
                            break;
                        case 5:
                            CorrectStage = (GetAttack(currentAttack).stage5);
                            break;
                        case 6:
                            CorrectStage = (GetAttack(currentAttack).stage6);
                            break;
                    }
                    if (CorrectStage)
                    {
                        AnalysisStage = "4. Correct Stage Location for Attack? Yes";
                    }
                    else
                    {
                        AnalysisStage = "4. Correct Stage Location for Attack? No";
                    }
                    // 5. Defence Correct?
                    CorrectDefence = false;
                    //CorrectDefence = GetDefence(currentAttack, DefenceID).stage1;

                    switch (AttackStage)
                    {
                        case 1:
                            CorrectDefence = (GetDefence(GetAttack(currentAttack).attackid, DefenceID).stage1);
                            break;
                        case 2:
                            CorrectDefence = (GetDefence(GetAttack(currentAttack).attackid, DefenceID).stage2);
                            break;
                        case 3:
                            CorrectDefence = (GetDefence(GetAttack(currentAttack).attackid, DefenceID).stage3);
                            break;
                        case 4:
                            CorrectDefence = (GetDefence(GetAttack(currentAttack).attackid, DefenceID).stage4);
                            break;
                        case 5:
                            CorrectDefence = (GetDefence(GetAttack(currentAttack).attackid, DefenceID).stage5);
                            break;
                        case 6:
                            CorrectDefence = (GetDefence(GetAttack(currentAttack).attackid, DefenceID).stage6);
                            break;
                    }
                    if (CorrectDefence)
                    {
                        AnalysisDefence = "5. Correct Defence & Stage for Attack? Yes";
                    }
                    else
                    {
                        AnalysisDefence = "5. Correct Defence & Stage for Attack?  No";
                    }

                    SucessfulDefence = false;
                    SucessfulDefence = (CorrectCISTCategory && CorrectAdversary && CorrectStage && CorrectDefence);
                    if (SucessfulDefence)
                    {
                        AnalysisSummary = "Did you sucessfully defend? Yes - 1 point";
                        gamePoints = ++gamePoints;
                        switch (CISTCategoryAttack)
                        {
                            case "C":
                                Cscore = ++Cscore;
                                CtextScore.GetComponent<TextMeshProUGUI>().text = "" + Cscore;
                                AlltextScore.GetComponent<TextMeshProUGUI>().text = "" + gamePoints;
                                break;
                            case "I":
                                Iscore = ++Iscore;
                                ItextScore.GetComponent<TextMeshProUGUI>().text = "" + Iscore;
                                AlltextScore.GetComponent<TextMeshProUGUI>().text = "" + gamePoints;
                                break;
                            case "S":
                                Sscore = ++Sscore;
                                StextScore.GetComponent<TextMeshProUGUI>().text = "" + Sscore;
                                AlltextScore.GetComponent<TextMeshProUGUI>().text = "" + gamePoints;
                                break;
                            case "T":
                                Tscore = ++Tscore;
                                TtextScore.GetComponent<TextMeshProUGUI>().text = "" + Tscore;
                                AlltextScore.GetComponent<TextMeshProUGUI>().text = "" + gamePoints;
                                break;
                        }

                    }
                    else
                    {
                        AnalysisSummary = "Did you sucessfully defend? No - 0 point";
                    }
                    // Check if got 10 points
                    if (gamePoints == 10)
                    {
                        gamePointsMsg = "You have " + gamePoints + " and won the game";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = "You have " + gamePoints + " and won the game\nContinue to play or click New Game to start back at first attack";
                        Step06Information.GetComponent<TextMeshProUGUI>().text = "<align=center>6. Analysis of Attack\n</align=center>" + AnalysisCISTCat + "\n" + AnalysisAdversary + "\n" + AnalysisStage + "\n" + AnalysisDefence +
                            "\n" + AnalysisSummary + "\n" + gamePointsMsg;
                        attackStarted = false;
                        AttacksLeft = attacks.Count - currentAttack;
                        NoAttacksLeft.GetComponent<TextMeshProUGUI>().text = "" + AttacksLeft;
                        showAnswer = true;
                        currentAttackAnswer = currentAttack;
                        currentAttack = ++currentAttack;
                        numberofAttacks = ++numberofAttacks;
                        GameStep01Message.GetComponent<TextMeshProUGUI>().text = "1. Click to continue\nPlaying Game\nNext Attack Number " + currentAttack;
                        // gameOver = true;
                    }
                    else
                    {
                        gamePointsMsg = "You have " + gamePoints + " and need 10 points to win";
                        GameInformation.GetComponent<TextMeshProUGUI>().text = "CIST Game Play: Attack Evaluation - \nClick Button 1. for next attack";
                        Step06Information.GetComponent<TextMeshProUGUI>().text = "<align=center>6. Analysis of Attack\n</align=center>" + AnalysisCISTCat + "\n" + AnalysisAdversary + "\n" + AnalysisStage + "\n" + AnalysisDefence +
                            "\n" + AnalysisSummary + "\n" + gamePointsMsg;
                        attackStarted = false;
                        AttacksLeft = attacks.Count - currentAttack;
                        NoAttacksLeft.GetComponent<TextMeshProUGUI>().text = "" + AttacksLeft;
                        showAnswer = true;
                        currentAttackAnswer = currentAttack;
                        currentAttack = ++currentAttack;
                        numberofAttacks = ++numberofAttacks;
                        GameStep01Message.GetComponent<TextMeshProUGUI>().text = "1. Click to continue\nPlaying Game\nNext Attack Number " + currentAttack;
                    }
                }

            }
            else
            {
                GameInformation.GetComponent<TextMeshProUGUI>().text = "CIST Game Play: Last Attack Game Ended";
            }
            
        }
    }

    public void loadAnswers()
    {
        GameDefenceAllDMessage.GetComponent<TextMeshProUGUI>().text = "Click on button to see defence for this attack by stage location";
        currentAttackID = GetAttack(currentAttackAnswer).attackid;
        AttackAnswerPanel.GetComponent<TextMeshProUGUI>().text = GetAttack(currentAttackAnswer).description;
        // Attack Level
        minAttackLevel.GetComponent<TextMeshProUGUI>().text = "" + GetAttack(currentAttackAnswer).attackdifficulty;

        AdText.GetComponent<TextMeshProUGUI>().text = "Attack Level & Adversary has capability for the attack ID" + GetAttack(currentAttackAnswer).attackid;

        switch (GetAttack(currentAttackAnswer).attackdifficulty)
        {
            case 1:
                Class01.GetComponent<TextMeshProUGUI>().text = "Yes";
                Class02.GetComponent<TextMeshProUGUI>().text = "Yes";
                Class03.GetComponent<TextMeshProUGUI>().text = "Yes";
                Class04.GetComponent<TextMeshProUGUI>().text = "Yes";
                break;
            case 2:
                Class01.GetComponent<TextMeshProUGUI>().text = "Yes";
                Class02.GetComponent<TextMeshProUGUI>().text = "Yes";
                Class03.GetComponent<TextMeshProUGUI>().text = "Yes";
                Class04.GetComponent<TextMeshProUGUI>().text = "Yes";
                break;
            case 3:
                Class01.GetComponent<TextMeshProUGUI>().text = "No";
                Class02.GetComponent<TextMeshProUGUI>().text = "Yes";
                Class03.GetComponent<TextMeshProUGUI>().text = "Yes";
                Class04.GetComponent<TextMeshProUGUI>().text = "Yes";
                break;
            case 4:
                Class01.GetComponent<TextMeshProUGUI>().text = "No";
                Class02.GetComponent<TextMeshProUGUI>().text = "No";
                Class03.GetComponent<TextMeshProUGUI>().text = "No";
                Class04.GetComponent<TextMeshProUGUI>().text = "Yes";
                break;
        }
        // Stage 01
        if (GetAttack(currentAttackAnswer).stage1 == true && GetAttack(currentAttackAnswer).counterfeiting == true)
        {
            Stage01C.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage01C.GetComponent<TextMeshProUGUI>().text = "";
        }
        
        if (GetAttack(currentAttackAnswer).stage1 == true && GetAttack(currentAttackAnswer).informationleakage == true)
        {
            Stage01I.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage01I.GetComponent<TextMeshProUGUI>().text = "";
        }
        if (GetAttack(currentAttackAnswer).stage1 == true && GetAttack(currentAttackAnswer).sabotage == true)
        {
            Stage01S.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage01S.GetComponent<TextMeshProUGUI>().text = "";
        }
        if (GetAttack(currentAttackAnswer).stage1 == true && GetAttack(currentAttackAnswer).tampering == true)
        {
            Stage01T.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage01T.GetComponent<TextMeshProUGUI>().text = "";
        }
        // Stage 02
        if (GetAttack(currentAttackAnswer).stage2 == true && GetAttack(currentAttackAnswer).counterfeiting == true)
        {
            Stage02C.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage02C.GetComponent<TextMeshProUGUI>().text = "";
        }

        if (GetAttack(currentAttackAnswer).stage2 == true && GetAttack(currentAttackAnswer).informationleakage == true)
        {
            Stage02I.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage02I.GetComponent<TextMeshProUGUI>().text = "";
        }
        if (GetAttack(currentAttackAnswer).stage2 == true && GetAttack(currentAttackAnswer).sabotage == true)
        {
            Stage02S.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage02S.GetComponent<TextMeshProUGUI>().text = "";
        }
        if (GetAttack(currentAttackAnswer).stage2 == true && GetAttack(currentAttackAnswer).tampering == true)
        {
            Stage02T.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage02T.GetComponent<TextMeshProUGUI>().text = "";
        }
        // Stage 03
        if (GetAttack(currentAttackAnswer).stage3 == true && GetAttack(currentAttackAnswer).counterfeiting == true)
        {
            Stage03C.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage03C.GetComponent<TextMeshProUGUI>().text = "";
        }

        if (GetAttack(currentAttackAnswer).stage3 == true && GetAttack(currentAttackAnswer).informationleakage == true)
        {
            Stage03I.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage03I.GetComponent<TextMeshProUGUI>().text = "";
        }
        if (GetAttack(currentAttackAnswer).stage3 == true && GetAttack(currentAttackAnswer).sabotage == true)
        {
            Stage03S.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage03S.GetComponent<TextMeshProUGUI>().text = "";
        }
        if (GetAttack(currentAttackAnswer).stage3 == true && GetAttack(currentAttackAnswer).tampering == true)
        {
            Stage03T.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage03T.GetComponent<TextMeshProUGUI>().text = "";
        }
        // Stage 04
        if (GetAttack(currentAttackAnswer).stage4 == true && GetAttack(currentAttackAnswer).counterfeiting == true)
        {
            Stage04C.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage04C.GetComponent<TextMeshProUGUI>().text = "";
        }

        if (GetAttack(currentAttackAnswer).stage4 == true && GetAttack(currentAttackAnswer).informationleakage == true)
        {
            Stage04I.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage04I.GetComponent<TextMeshProUGUI>().text = "";
        }
        if (GetAttack(currentAttackAnswer).stage4 == true && GetAttack(currentAttackAnswer).sabotage == true)
        {
            Stage04S.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage04S.GetComponent<TextMeshProUGUI>().text = "";
        }
        if (GetAttack(currentAttackAnswer).stage4 == true && GetAttack(currentAttackAnswer).tampering == true)
        {
            Stage04T.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage04T.GetComponent<TextMeshProUGUI>().text = "";
        }
        // Stage 05
        if (GetAttack(currentAttackAnswer).stage5 == true && GetAttack(currentAttackAnswer).counterfeiting == true)
        {
            Stage05C.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage05C.GetComponent<TextMeshProUGUI>().text = "";
        }

        if (GetAttack(currentAttackAnswer).stage5 == true && GetAttack(currentAttackAnswer).informationleakage == true)
        {
            Stage05I.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage05I.GetComponent<TextMeshProUGUI>().text = "";
        }
        if (GetAttack(currentAttackAnswer).stage5 == true && GetAttack(currentAttackAnswer).sabotage == true)
        {
            Stage05S.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage05S.GetComponent<TextMeshProUGUI>().text = "";
        }
        if (GetAttack(currentAttackAnswer).stage5 == true && GetAttack(currentAttackAnswer).tampering == true)
        {
            Stage05T.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage05T.GetComponent<TextMeshProUGUI>().text = "";
        }
        // Stage 06
        if (GetAttack(currentAttackAnswer).stage6 == true && GetAttack(currentAttackAnswer).counterfeiting == true)
        {
            Stage06C.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage06C.GetComponent<TextMeshProUGUI>().text = "";
        }

        if (GetAttack(currentAttackAnswer).stage6 == true && GetAttack(currentAttackAnswer).informationleakage == true)
        {
            Stage06I.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage06I.GetComponent<TextMeshProUGUI>().text = "";
        }
        if (GetAttack(currentAttackAnswer).stage6 == true && GetAttack(currentAttackAnswer).sabotage == true)
        {
            Stage06S.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage06S.GetComponent<TextMeshProUGUI>().text = "";
        }
        if (GetAttack(currentAttackAnswer).stage6 == true && GetAttack(currentAttackAnswer).tampering == true)
        {
            Stage06T.GetComponent<TextMeshProUGUI>().text = "True";
        }
        else
        {
            Stage06T.GetComponent<TextMeshProUGUI>().text = "";
        }

        
        // For Defence Buttons - Card 05
        if (GetDefenceCard(currentAttackID, 5).stage1 == true) { Stage01C05.SetActive(true); } else {Stage01C05.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 5).stage2 == true) { Stage02C05.SetActive(true); } else {Stage02C05.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 5).stage3 == true) { Stage03C05.SetActive(true); } else {Stage03C05.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 5).stage4 == true) { Stage04C05.SetActive(true); } else {Stage04C05.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 5).stage5 == true) { Stage05C05.SetActive(true); } else {Stage05C05.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 5).stage6 == true) { Stage06C05.SetActive(true); } else {Stage06C05.SetActive(false); }
        // For Defence Buttons - Card 06
        if (GetDefenceCard(currentAttackID, 6).stage1 == true) { Stage01C06.SetActive(true); } else { Stage01C06.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 6).stage2 == true) { Stage02C06.SetActive(true); } else { Stage02C06.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 6).stage3 == true) { Stage03C06.SetActive(true); } else { Stage03C06.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 6).stage4 == true) { Stage04C06.SetActive(true); } else { Stage04C06.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 6).stage5 == true) { Stage05C06.SetActive(true); } else { Stage05C06.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 6).stage6 == true) { Stage06C06.SetActive(true); } else { Stage06C06.SetActive(false); }
        // For Defence Buttons - Card 07
        if (GetDefenceCard(currentAttackID, 7).stage1 == true) { Stage01C07.SetActive(true); } else { Stage01C07.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 7).stage2 == true) { Stage02C07.SetActive(true); } else { Stage02C07.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 7).stage3 == true) { Stage03C07.SetActive(true); } else { Stage03C07.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 7).stage4 == true) { Stage04C07.SetActive(true); } else { Stage04C07.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 7).stage5 == true) { Stage05C07.SetActive(true); } else { Stage05C07.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 7).stage6 == true) { Stage06C07.SetActive(true); } else { Stage06C07.SetActive(false); }
        // For Defence Buttons - Card 08
        if (GetDefenceCard(currentAttackID, 8).stage1 == true) { Stage01C08.SetActive(true); } else { Stage01C08.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 8).stage2 == true) { Stage02C08.SetActive(true); } else { Stage02C08.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 8).stage3 == true) { Stage03C08.SetActive(true); } else { Stage03C08.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 8).stage4 == true) { Stage04C08.SetActive(true); } else { Stage04C08.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 8).stage5 == true) { Stage05C08.SetActive(true); } else { Stage05C08.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 8).stage6 == true) { Stage06C08.SetActive(true); } else { Stage06C08.SetActive(false); }
        // For Defence Buttons - Card 09
        if (GetDefenceCard(currentAttackID, 9).stage1 == true) { Stage01C09.SetActive(true); } else { Stage01C09.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 9).stage2 == true) { Stage02C09.SetActive(true); } else { Stage02C09.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 9).stage3 == true) { Stage03C09.SetActive(true); } else { Stage03C09.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 9).stage4 == true) { Stage04C09.SetActive(true); } else { Stage04C09.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 9).stage5 == true) { Stage05C09.SetActive(true); } else { Stage05C09.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 9).stage6 == true) { Stage06C09.SetActive(true); } else { Stage06C09.SetActive(false); }
        // For Defence Buttons - Card 10
        if (GetDefenceCard(currentAttackID, 10).stage1 == true) { Stage01C10.SetActive(true); } else { Stage01C10.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 10).stage2 == true) { Stage02C10.SetActive(true); } else { Stage02C10.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 10).stage3 == true) { Stage03C10.SetActive(true); } else { Stage03C10.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 10).stage4 == true) { Stage04C10.SetActive(true); } else { Stage04C10.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 10).stage5 == true) { Stage05C10.SetActive(true); } else { Stage05C10.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 10).stage6 == true) { Stage06C10.SetActive(true); } else { Stage06C10.SetActive(false); }
        // For Defence Buttons - Card 11
        if (GetDefenceCard(currentAttackID, 11).stage1 == true) { Stage01C11.SetActive(true); } else { Stage01C11.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 11).stage2 == true) { Stage02C11.SetActive(true); } else { Stage02C11.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 11).stage3 == true) { Stage03C11.SetActive(true); } else { Stage03C11.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 11).stage4 == true) { Stage04C11.SetActive(true); } else { Stage04C11.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 11).stage5 == true) { Stage05C11.SetActive(true); } else { Stage05C11.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 11).stage6 == true) { Stage06C11.SetActive(true); } else { Stage06C11.SetActive(false); }
        // For Defence Buttons - Card 12
        if (GetDefenceCard(currentAttackID, 12).stage1 == true) { Stage01C12.SetActive(true); } else { Stage01C12.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 12).stage2 == true) { Stage02C12.SetActive(true); } else { Stage02C12.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 12).stage3 == true) { Stage03C12.SetActive(true); } else { Stage03C12.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 12).stage4 == true) { Stage04C12.SetActive(true); } else { Stage04C12.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 12).stage5 == true) { Stage05C12.SetActive(true); } else { Stage05C12.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 12).stage6 == true) { Stage06C12.SetActive(true); } else { Stage06C12.SetActive(false); }
        // For Defence Buttons - Card 13
        if (GetDefenceCard(currentAttackID, 13).stage1 == true) { Stage01C13.SetActive(true); } else { Stage01C13.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 13).stage2 == true) { Stage02C13.SetActive(true); } else { Stage02C13.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 13).stage3 == true) { Stage03C13.SetActive(true); } else { Stage03C13.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 13).stage4 == true) { Stage04C13.SetActive(true); } else { Stage04C13.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 13).stage5 == true) { Stage05C13.SetActive(true); } else { Stage05C13.SetActive(false); }
        if (GetDefenceCard(currentAttackID, 13).stage6 == true) { Stage06C13.SetActive(true); } else { Stage06C13.SetActive(false); }

        GetInfoAttack();
    }


    public Attack GetAttack(int id)
    {
        // Use sequnce ID to present in this order
        return attacks.Find(attack => attack.sequenceid == id);
    }

    public void ClosePanel()
    {
        Panel.SetActive(false);
        if (Panel.activeSelf == true)
        {
            GameDefenceAllDMessage.GetComponent<TextMeshProUGUI>().text = "Click on button to see defence for this attack by stage location";
            GameInformation.GetComponent<TextMeshProUGUI>().text = "See all the possible answers for the attack in the panel to the right";
        }
        else
        {
            GameInformation.GetComponent<TextMeshProUGUI>().text = "Click Button 1. to start your next defence from attack";
        }

        //
    }
    public void OpenPanel()
    {
        if (showAnswer)
        {
            Panel.SetActive(!Panel.activeSelf);
            AdminButtons = GameObject.Find("AdminHelp");
            AdminButtons.SetActive(false);
            CISTInfo = GameObject.Find("InformationDeck");
            CISTInfo.GetComponent<InformationDeck>().ChangeTile(0, "");
            CISTInfo = GameObject.Find("HelpScreen");
            CISTInfo.SetActive(false);
        }
        else
        {
            GameInformation.GetComponent<TextMeshProUGUI>().text = "Answers only avialble after you have completed the attack";
        }
    }
    void OnGUI()
    {
        Event e = Event.current;
        if (e.type == EventType.KeyDown && e.control && e.keyCode == KeyCode.A)
        {
            // CTRL + A
            AdminButtons.SetActive(true);
        }
    }
    public void OpenCloseHelp()
    {
        PanelHelp.SetActive(!PanelHelp.activeSelf);
        CISTInfo = GameObject.Find("AnswerCanvas");
        CISTInfo.SetActive(false);

    }
    void BuildAttackDatabase()
    {
        attacks = new List<Attack>()
        {
            // Attack 1
            new Attack(1, 2, "Attack ID1: IC Overproduction – the adversary is able produce more copies by fraudulently imitating an original IC", 3, 
            true, false, false, false, 
            false, false, true, false, false, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Outsourcing the IC fabrication\n\u2022 Ease of access to IC black markets\n\u2022 Ineffective regulations or law enforcement measures to protect IPs\n\u2022 Technical difficulty associated with detection of overproduced chips"),
            // Attack 2
            new Attack(2, 1, "Attack ID2: Cyberattacks on IP companies (IP Piracy Attack), the attacker is trying to collect information", 2, 
            false, true, false, false, 
            true, true, true, true, false, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Weak security defences in IT infrastructures"),
            // Attack 3
            new Attack(3, 5, "Attack ID3: Rowhammer attack used as a mechanism by waging a persistent attack to cause large number of errors", 2,
            false, false, true, false, 
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 This is a form of fault attack which exploits the fact that repeated accesses to DRAM can cause bits to flip in adjacent DRAM rows"),
            // Attack 4
            new Attack(4, 3, "Attack ID4: Fault Injection Attack - In this case, an adversary can induce errors during the computation of a cryptographic algorithm to generate faulty results", 2,
            false, false, false, true, 
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Susceptibility of electronics circuit to temperature variations, supply voltage fluctuations and electromagnetic interference \n\n\u2022 Intrinsic correlation between side channel information and secret information processed on the chip"),
            // Attack 5
            new Attack(5, 4, "Attack ID5: Chip reverse engineering attack – the attacker has access to a working chip files and able to extract the IP gate-level netlist using a range of tools and reverse engineering technologies", 3, false, true, false, false,
            false, false, false, true, false, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Correlation between circuit layout and the gate-level netlist and ultimately the design functionality"),
            // Attack 6
            new Attack(6, 30, "Attack ID6: Selling defective chips Defective ICs are chips that have failed the functional or parametric tests or found to be out of spec, and subsequently placed in the market as authentic products", 1, true, false, false, false,
            false, false, false, true, false, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Ease of access to IC black markets"),
            // Attack 7
            new Attack(7, 9, "Attack ID7: Recover discarded chips then repackaged and sold in the market as new", 2, true, false, false, false,
            false, false, false, false, false, true,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Availability of remarking technologies\n\u2022 Unmatched demands for certain types of ICs (e.g. military grade, discontinued chips)"),
            // Attack 8
            new Attack(8, 29, "Attack ID8: IP theft attack by a malicious engineer in the SoC design house, who has access to third party IPs, can steal design secrets", 2, false, true, false, false,
            true, true, false, false, false, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Single company having access to the layout files of the design, making it easy to recover the IP by rogue employees"),
            // Attack 9
            new Attack(9, 20, "Attack ID9: Remote CLKSCREW attack (read as clock screw attack) that exploits the security of energy management systems in ICs to compromise the system’s availability", 3, false, false, true, false,
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Unfettered software access to energy management hardware\n\u2022 Ability of the hardware regulators to be able to push voltage/frequency past the operating limits" +
            "\n\u2022 Using the same power domain across security boundaries"),
            // Attack 10
            new Attack(10, 27, "Attack ID10: Reverse engineering attack – by using De-capsulation that is the removal of the chip’s packaging and De-processing which consists of removing the chip layers one by one in reverse order and photographing each layer, this information will be used to re-construct the netlist and ultimately expose design secrets", 3, false, true, false, false,
            false, false, true, false, false, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Correlation between circuit layout and the gate-level netlist and ultimately the design functionality"),
            // Attack 11
            new Attack(11, 12,"Attack ID11: Hardware Trojan inserted by attacker into the design file", 3, false, false, false, true,
            true, false, false, false, false, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Outsourcing of IP development and IC fabrication\n\u2022 High complexity of integrated circuits that makes it harder to detect Trojan"),
            // Attack 12
            new Attack(12, 7, "Attack ID12: An attacker can compromise the software updates or patch to add own functionality to gain control of a system", 2, false, false, true, false,
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Software updates/patches (SolarWinds/Stuxnet)"),
            // Attack 13
            new Attack(13, 21, "Attack ID13: Attack is able to insert Trojan in the RTL code, during the system integration or during the manufacturing of the Integrated Circuit (IC)", 3, false, false, false, true,
            false, false, true, false, false, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Outsourcing of IP development and IC fabrication\n\u2022 High complexity of integrated circuits that makes it harder to detect Trojan"),
            // Attack 14
            new Attack(14, 8, "Attack ID14: An attacker has access to a fabrication facility and ability to obtain a gate-level netlist of the chip through reverse engineering or other IP piracy methods to clone the ICs", 3, true, false, false, false,
            false, false, true, false, false, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022Ease of access to IC black markets\n\u2022 Lack of regulations or law enforcement measures to protect IPs\n\u2022 Technical difficulty associated with detection of cloned chips"),
            // Attack 15
            new Attack(15, 28, "Attack ID15: An attacker has access to a fabricated chips and IC remarking tool to remark ICs", 2, true, false, false, false,
            false, false, true, true, true, true,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Ease of access to fabricated ICs\n\u2022Availability of remarking technologies\n\u2022 Unmatched demands for certain types of ICs" +
            "\n\u2022 Lack of regulations or law enforcement\n\u2022 Technical difficulty associated with detection of cloned chips"),
            // Attack 16
            new Attack(16, 16, "Attack ID16: An attacker has Access to PUF response/challenge pairs and can complete a PUF modelling attack (PUF modelling attack)", 2, false, true, false, false,
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 PUF design is simple hence can be modelled using machine learning algorithms"),
            // Attack 17
            new Attack(17, 13, "Attack ID17: An attacker uses a Rowhammer techniques to undermine the integrity of electronics systems by facilitating an elevation of privilege attack", 2, false, false, true, false,
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 DRAM physical structure and fabrication technology"),
            // Attack 18
            new Attack(18, 26, "Attack ID18: The attacker is to be able to inject an intentional fault, using a series of techniques to manipulate the environmental conditions of a circuit, that results in the desired fault effect", 3, false, false, false, true,
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Inject a fault in the computation against almost all known ciphers"),
            // Attack 19
            new Attack(19, 6, "Attack ID19: An attacker installs a Trojan in attempt to perform malicious operations (Side-channel analysis)", 3, false, true, false, false,
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Correlation between side-channel information and secret data being computed"),
            // Attack 20
            new Attack(20, 14, "Attack ID20: An attacker can break the isolation between different applications running on the same machine, which they can then steal/copy sensitive data from a victim process (Speculative execution attack)", 3, false, true, false, false,
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Speculative operations can affect the micro-architectural state, such as information stored in Translation Lookaside Buffers (TLBs) and " +
            "caches, which may lead to leakage of sensitive data when combined with Cache side-channel attacks"),
            new Attack(21, 25, "Attack ID21: An attacker uses microprobing by attaching a microscopic needle onto the internal wiring of a chip, which allows reading out internal signals and revealing sensitive data that are not meant to leave the chip", 3, false, true, false, false,
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 The transmission of sensitive information on the internal wires without sufficient protection"),
            new Attack(22, 10, "Attack ID22: An attacker can compromise a cryptosystem by analysing the time taken to execute cryptographic algorithms (Cache timing attack)", 2, false, true, false, false,
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 The dependency of the memory access time on the location of data item being fetched (e.g. whether or not it is present in the cache or the main memory)"),
            new Attack(23, 19, "Attack ID23: An attacker can monitor the external outputs of the hardware while cryptographic operations are running with the goal of attempting to gain information which would result in the security of the device being compromised", 2, false, true, false, false,
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\u2022 Correlation between side-channel information and secret data being computed"),
            new Attack(24, 17, "Attack ID24: An attacker can create copies of smartcard by monitoring the power consumption is able break the cryptographic functions create unauthorized signatures and clone the device", 2, true, false, false, false,
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Correlation between side-channel information and secret data being computed"),
            new Attack(25, 15, "Attack ID25: An attacker is able to recycle ICs and repackage them as new IC and  able to pass physical inspection", 2, true, false, false, false,
            false, false, false, false, false, true,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Availability of remarking technologies\n\u2022 Unmatched demands for certain types of ICs (e.g. military grade, discontinued chips)"),
            new Attack(26, 24, "Attack ID26: A malicious foundry can replicate programable data and overbuild the ICs because of transparency of their designed IP to the foundry that requires a complete description of the design components and layout to fabricate the ICs", 3, true, false, false, false,
            false, false, true, false, false, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Vulnerability of the serial numbers and digital identification numbers to cloning"),
            new Attack(27, 18, "Attack ID27: A malicious recycling centres can recycle ICs as if they were new and can be used as ICs are not chip locked", 3, true, false, false, false,
            false, false, false, false, false, true,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 The standard chip/package/system level tests are often inadequate in detecting various forms of counterfeit ICs\n\u2022 IC authentication are often not attractive due to significant design effort"),
            new Attack(28, 11, "Attack ID28: An attacker has, collected a subset of all challenge–response pair (CRPs) of the IC PUF and uses Machine Learning to derive a numerical model from this CRP data, which correctly predicts the PUF’s responses to arbitrary challenges with high probability", 2, false, true, false, false,
            false, false, false, false, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 PUF design is simple hence can be modelled using machine learning algorithms"),
            new Attack(29, 23, "Attack ID29: An attacker in the untrusted foundry has access only to the complete IC design as by manufacturing the front-end-of-line (FEOL) layers and back-end-of-line (BEOL) in same foundry", 3, false, true, false, false,
            false, false, true, false, false, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 Many design companies cannot afford owning and acquiring expensive foundries; hence, outsourcing their fabrication process"),
            new Attack(30, 22, "Attack ID30: An attacker can replace valid firmware images with malicious images or make alterations to existing firmware", 2, false, false, true, false,
            false, false, true, true, true, false,
            "<align=center>Root of vulnerability</align=center>\n\n\u2022 The firmware is not signed, or integrity checked by trusted element on the component")
        };
    }

    public Defence GetDefence(int Attackid, int Defenceid)
    {
        temp = defence.Find(defence => (defence.Aid == Attackid) && (defence.Did == Defenceid));
        if (temp == null)
        {
            return defence.Find(defence => defence.Did == 99);
        }
        else
        {
            return defence.Find(defence => (defence.Aid == Attackid) && (defence.Did == Defenceid));
        }
    }

    public Defence GetDefenceCard(int Attackid, int CardNo)
    {
        temp = defence.Find(defence => (defence.Aid == Attackid) && (defence.CardNo == CardNo));
        if (temp == null)
        {
            return defence.Find(defence => defence.Did == 99);
        }
        else
        {
            return defence.Find(defence => (defence.Aid == Attackid) && (defence.CardNo == CardNo));
        }
    }

    public void NextAttack()
    {
        if (currentAttackAnswer > attacks.Count)
            {
            GameDefenceAllDMessage.GetComponent<TextMeshProUGUI>().text = "Last Attack";
        }
        else
        {
            currentAttackAnswer = ++currentAttackAnswer;
            loadAnswers();
            GetInfoAttack();
        }
    }

    public void PreviousAttack()
    {
        if (currentAttackAnswer == 1)
        {
            GameDefenceAllDMessage.GetComponent<TextMeshProUGUI>().text = "First Attack";
        }
        else
        {
            currentAttackAnswer = currentAttackAnswer - 1;
            loadAnswers();
            GetInfoAttack(); 
        }
    }

    public void GetInfoAttack()
    {
        CISTInfo = GameObject.Find("InformationDeck");
        CISTInfo.GetComponent<InformationDeck>().ChangeTile(1, GetAttack(currentAttackAnswer).informationAttack);
    }
    void BuildDefenceDatabase()
    {
        defence = new List<Defence>()
        {
            // Attack 1
            new Defence(1, 3, 7, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center> " +
            "Detection Method: Fingerprinting Conventional serial numbers", false, false, true, false, false, false),
            new Defence(1, 4, 8, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center> Detection Method: Fingerprinting DNA Marking", false, false, true, false, false, false),
            new Defence(1, 5, 9, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting: Physical Unclonable Functions", false, false, true, false, false, false),
            new Defence(1, 6, 10, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting: Digital Fingerprinting", false, false, true, false, false, false),
            // Attack 2
            new Defence(2, 10, 5, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Split Manufacturing", true, true, true, true, false, false),
            new Defence(2, 11, 6, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Hardware Obfuscation - IC Camouflaging", true, true, true, true, false, false),
            new Defence(2, 12, 7, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                       "IP Piracy: Prevention Method: Hardware Obfuscation - Combinational Logic Locking", true, true, true, true, false, false),
            new Defence(2, 13, 8, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Hardware Obfuscation - Sequential Logic Locking", true, true, true, true, false, false),
            new Defence(2, 14, 9, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Detection Method: Watermarking - Digital Watermarking to hide information in the signal", true, true, true, true, false, false),
            // Attack 3
            new Defence(3, 19, 10, "<align=center>Countermeasures\nSabotage\n\n</align=center>" +
                       "Detection Method: Monitoring the rate of cache misses for unusual peaks using", false, false, false, false, true, false),
            new Defence(3, 21, 12, "<align=center>Countermeasures\nSabotage\n\n</align=center>" +
                        "Prevention Method: Increase memory refresh frequency, use less leaky memory technology", false, false, false, false, true, false),
            // Attack 4
            new Defence(4, 27, 13, "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: Fault Injections Attacks\nTamper Resistant Techniques", false, false, false, false, true, false),
            // Attack 5
            new Defence(5, 10, 5, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Split Manufacturing", false, false, false, true, false, false),
            new Defence(5, 11, 6, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Hardware Obfuscation - IC Camouflaging", false, false, false, true, false, false),
            new Defence(5, 12, 7, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                       "IP Piracy: Prevention Method: Hardware Obfuscation - Combinational Logic Locking", false, false, false, true, false, false),
            new Defence(5, 13, 8, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Hardware Obfuscation - Sequential Logic Locking", false, false, false, true, false, false),
            new Defence(5, 14, 9, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Detection Method: Watermarking - Digital Watermarking to hide information in the signal", false, false, false, true, false, false),
            // Attack 6
            new Defence(6, 9, 13, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Prevention Method: Supply Chain Compromise IC Supply Chain Assurance", false, false, false, true, false, false),
            // Attack 7
            new Defence(7, 3, 7, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting Conventional serial numbers", false, false, false, false, false, true),
            new Defence(7, 4, 8, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting DNA Marking", false, false, false, false, false, true),
            new Defence(7, 5, 9, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting: Physical Unclonable Functions", false, false, false, false, false, true),
            new Defence(7, 6, 10, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting: Digital Fingerprinting", false, false, false, false, false, true),
            // Attack 8
            new Defence(8, 10, 5, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Split Manufacturing", true, true, false, false, false, false),
            // Attack 9
            new Defence(9, 22, 13, "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention or Detection Methods: Tamper-Proof Design", false, false, false, false, true, false),
            // Attack 10
            new Defence(10, 11, 6, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Hardware Obfuscation - IC Camouflaging", false, false, true, false, false, false),
            new Defence(10, 12, 7, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                       "IP Piracy: Prevention Method: Hardware Obfuscation - Combinational Logic Locking", false, false, true, false, false, false),
            new Defence(10, 13, 8, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Hardware Obfuscation - Sequential Logic Locking", false, false, true, false, false, false),
            // Attack 11
            new Defence(11, 23, 9, "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: Hardware Trojan Insert\nReplace functional cells to implement an LFSR/MISR-like circuit that generates a digital signature", true, false, false, false, false, false),
            new Defence(11, 24, 10, "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: Hardware Trojan Insert\nPre-silicon detection", true, false, false, false, false, false),
            new Defence(11, 25, 11, "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: Hardware Trojan Insert\nPost-silicon detection", true, false, false, false, false, false),
            new Defence(11, 26, 12, "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                       "Detection Method: Hardware Trojan Insert\nRuntime detection", true, false, false, false, false, false),
            // Attack 12
            new Defence(12, 20, 11, "<align=center>Countermeasures\nSabotage\n\n</align=center>" +
                       "Prevention or Detection Methods: Cyber Physical Attacks Monitor predefined constraints; " +
                       "Strict one-way communication from IC to cyber physical system command centre", false, false, false, false, true, false),
            // Attack 13
            new Defence(13, 23, 9, "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: Hardware Trojan Insert\nReplace functional cells to implement an LFSR/MISR-like circuit that generates a digital signature", false, false, true, false, false, false),
            new Defence(13, 24, 10, "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: Hardware Trojan Insert\nPre-silicon detection", false, false, true, false, false, false),
            new Defence(13, 25, 11, "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: Hardware Trojan Insert\nPost-silicon detection", false, false, true, false, false, false),
            new Defence(13, 26, 12, "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                       "Detection Method: Hardware Trojan Insert\nRuntime detection",false, false, true, false, false, false),
            // Attack 14
            new Defence(14, 5, 9, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting: Physical Unclonable Functions", false, false, true, false, false, false),
            // Attack 15
            new Defence(15, 3, 7, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting Conventional serial numbers", false, false, true, true, true, true),
            new Defence(15, 4, 8, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting DNA Marking", false, false, true, true, false, false),
            new Defence(15, 6, 10, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Fingerprinting: Digital Fingerprinting", false, false, true, true, false, false),
            // Attack 16
            new Defence(16, 18, 13, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "Prevention Method: PUF Modelling Attacks - Response Obfuscation, Multi-PUF Design", false, false, false, false, true, false),
            // Attack 17
            new Defence(17, 21, 12, "<align=center>Countermeasures\nSabotage\n\n</align=center>" +
                        "Prevention Method: Increase memory refresh frequency, use less leaky memory technology", false, false, false, false, true, false),
            // Attack 18
            new Defence(18, 28, 8, "<align=center>Countermeasures\nTampering\n\n</align=center>" +
                        "Prevention Method: IP encrypted so that even if the IC is physically attacked, its IP cannot be deciphered", false, false, false, false, true, false),
            // Attack 19
            new Defence(19, 15, 10, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "SCA Detection Method: Side Channel Analysis - Leakage reduction approaches; Noise injection methods", false, false, false, false, true, false),
            new Defence(19, 16, 11, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                       "SCA Detection Method: Side Channel Analysis - Architecture Optimisation", false, false, false, false, true, false),
            new Defence(19, 17, 12, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "SCA Prevention Method: Speculative Execution Attacks - Bounds check bypass; Branch target injection; Rogue data cache load", false, false, false, false, true, false),
            // Attack 20
            new Defence(20, 15, 10, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "SCA Detection Method: Side Channel Analysis - Leakage reduction approaches; Noise injection methods", false, false, false, false, true, false),
            new Defence(20, 16, 11, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                       "SCA Detection Method: Side Channel Analysis - Architecture Optimisation", false, false, false, false, true, false),
            new Defence(20, 17, 12, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "SCA Prevention Method: Speculative Execution Attacks - Bounds check bypass; Branch target injection; Rogue data cache load", false, false, false, false, true, false),
            // Attack 21
            new Defence(21, 14, 9, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Detection Method: Watermarking - Digital Watermarking to hide information in the signal", false, false, false, false, true, false),
            // Attack 22
            new Defence(22, 15, 10, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "SCA Detection Method: Side Channel Analysis - Leakage reduction approaches; Noise injection methods", false, false, false, false, true, false),
            // Attack 23
            new Defence(23, 15, 10, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "SCA Detection Method: Side Channel Analysis - Leakage reduction approaches; Noise injection methods", false, false, false, false, true, false),
            // Attack 24
            new Defence(24, 1, 5, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Side Channel Analysis Differential Power Analysis (DPA)", false, false, false, false, true, false),
            // Attack 25
            new Defence(25, 2, 6, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Detection Method: Physical Inspection: X-Ray Inspection; Visual Inspection", false, false, false, false, false, true),
            // Attack 26
            new Defence(26, 7, 11, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Prevention Method: Active IC Metering: Active metering, force new IC process to be activated", false, false, true, false, false, false),
            // Attack 27
            new Defence(27, 8, 12, "<align=center>Countermeasures\nCounterfeiting\n\n</align=center>" +
                        "Prevention Method: Anti-fuse-Based Package-Level Defence", false, false, false, false, false, true),
            // Attack 28
            new Defence(28, 18, 13, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "Prevention Method: PUF Modelling Attacks - Response Obfuscation, Multi-PUF Design", false, false, false, false, true, false),
            // Attack 29
            new Defence(29, 10, 5, "<align=center>Countermeasures\nInformation Leakage\n\n</align=center>" +
                        "IP Piracy: Prevention Method: Split Manufacturing", false, false, true, false, false, false),
            // Attack 30
            new Defence(30, 22, 13, "<align=center>Countermeasures\nSabotage\n\n</align=center>" +
                        "Prevention or Detection Methods: Tamper-Proof Design", false, false, true, true, true, false),
            // If not found (Combination Attack & Defence) then false
            new Defence(99, 99, 0, "Error",false, false, false, false, false, false)
        };
    }
}
