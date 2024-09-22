using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{

    public Sprite cooperate;
    public Sprite defect;

    public TextMeshProUGUI roundNumber;
    public TextMeshProUGUI player1Region;
    public TextMeshProUGUI player2Region;

    public TextMeshProUGUI card1Name;
    public Image card1Player1Image;
    public Image card1Player2Image;
    public TextMeshProUGUI waterResult1Player1;
    public TextMeshProUGUI infraResult1Player1;
    public TextMeshProUGUI waterResult1Player2;
    public TextMeshProUGUI infraResult1Player2;

    public TextMeshProUGUI card2Name;
    public Image card2Player1Image;
    public Image card2Player2Image;
    public TextMeshProUGUI waterResult2Player1;
    public TextMeshProUGUI infraResult2Player1;
    public TextMeshProUGUI waterResult2Player2;
    public TextMeshProUGUI infraResult2Player2;


    public TextMeshProUGUI card3Name;
    public Image card3Player1Image;
    public Image card3Player2Image;
    public TextMeshProUGUI waterResult3Player1;
    public TextMeshProUGUI infraResult3Player1;
    public TextMeshProUGUI waterResult3Player2;
    public TextMeshProUGUI infraResult3Player2;

    public TextMeshProUGUI card4Name;
    public Image card4Player1Image;
    public Image card4Player2Image;
    public TextMeshProUGUI waterResult4Player1;
    public TextMeshProUGUI infraResult4Player1;
    public TextMeshProUGUI waterResult4Player2;
    public TextMeshProUGUI infraResult4Player2;


    public TextMeshProUGUI roundScore1;
    public TextMeshProUGUI roundScore2;

    public TextMeshProUGUI[] totalScore1;
    public TextMeshProUGUI[] totalScore2;
    public TextMeshProUGUI totalInfra1;
    public TextMeshProUGUI totalInfra2;
    public TextMeshProUGUI GW1;
    public TextMeshProUGUI GW2;

    public TextMeshProUGUI infraAddedP1;
    public TextMeshProUGUI infraAddedP2;

    public TextMeshProUGUI GWUsedP1;
    public TextMeshProUGUI GWUsedP2;

    int infraInCurrentRoundP1;
    int infraInCurrentRoundP2;
    int GroundWaterUsedInCurrentRoundP1;
    int GroundWaterUsedInCurrentRoundP2;
    private Card[] cards;

    // Infra Efficiency
    public TextMeshProUGUI infraEffP1R1;
    public TextMeshProUGUI infraEffP2R1;

    public TextMeshProUGUI infraEffP1R2;
    public TextMeshProUGUI infraEffP2R2;

    public TextMeshProUGUI infraEffP1R3;
    public TextMeshProUGUI infraEffP2R3;

    public TextMeshProUGUI infraEffP1R4;
    public TextMeshProUGUI infraEffP2R4;

    //Infra Built
    public TextMeshProUGUI InfraBuiltP1R1;
    public TextMeshProUGUI InfraBuiltP2R1;

    public TextMeshProUGUI InfraBuiltP1R2;
    public TextMeshProUGUI InfraBuiltP2R2;

    public TextMeshProUGUI InfraBuiltP1R3;
    public TextMeshProUGUI InfraBuiltP2R3;

    public TextMeshProUGUI InfraBuiltP1R4;
    public TextMeshProUGUI InfraBuiltP2R4;

    private int RoundNumber;
    private int[,] choices;

    void Start()
    {
        choices = GameManager.choices;
        RoundNumber = GameManager.roundNumber;
        CalculateStuff();
        roundNumber.text = "Round " + GameManager.roundNumber + " Completed";
        cards = GameManager.currentRoundCards;
        card1Name.text = cards[0].name;
        card2Name.text = cards[1].name;
        card3Name.text = cards[2].name;
        card4Name.text = cards[3].name;

        SetImage(GameManager.choices[0, 0] == 1 ? "COOPERATE" : "DEFECT", card1Player1Image);
        SetImage(GameManager.choices[0, 1] == 1 ? "COOPERATE" : "DEFECT", card1Player2Image);

        SetImage(GameManager.choices[1, 0] == 1 ? "COOPERATE" : "DEFECT", card2Player1Image);
        SetImage(GameManager.choices[1, 1] == 1 ? "COOPERATE" : "DEFECT", card2Player2Image);

        SetImage(GameManager.choices[2, 0] == 1 ? "COOPERATE" : "DEFECT", card3Player1Image);
        SetImage(GameManager.choices[2, 1] == 1 ? "COOPERATE" : "DEFECT", card3Player2Image);

        SetImage(GameManager.choices[3, 0] == 1 ? "COOPERATE" : "DEFECT", card4Player1Image);
        SetImage(GameManager.choices[3, 1] == 1 ? "COOPERATE" : "DEFECT", card4Player2Image);

        waterResult1Player1.text = GameManager.currentRoundWater[0, 0].ToString();
        waterResult1Player2.text = GameManager.currentRoundWater[0, 1].ToString();
        waterResult2Player1.text = GameManager.currentRoundWater[1, 0].ToString();
        waterResult2Player2.text = GameManager.currentRoundWater[1, 1].ToString();
        waterResult3Player1.text = GameManager.currentRoundWater[2, 0].ToString();
        waterResult3Player2.text = GameManager.currentRoundWater[2, 1].ToString();
        waterResult4Player1.text = GameManager.currentRoundWater[3, 0].ToString();
        waterResult4Player2.text = GameManager.currentRoundWater[3, 1].ToString();

        infraResult1Player1.text = GameManager.currentRoundInfra[0, 0].ToString();
        infraResult1Player2.text = GameManager.currentRoundInfra[0, 1].ToString();
        infraResult2Player1.text = GameManager.currentRoundInfra[1, 0].ToString();
        infraResult2Player2.text = GameManager.currentRoundInfra[1, 1].ToString();
        infraResult3Player1.text = GameManager.currentRoundInfra[2, 0].ToString();
        infraResult3Player2.text = GameManager.currentRoundInfra[2, 1].ToString();
        infraResult4Player1.text = GameManager.currentRoundInfra[3, 0].ToString();
        infraResult4Player2.text = GameManager.currentRoundInfra[3, 1].ToString();

        //infraInCurrentRound[0] = GameManager.currentRoundInfra[0, 0] + GameManager.currentRoundInfra[1, 0] + GameManager.currentRoundInfra[2, 0] + GameManager.currentRoundInfra[3, 0];
        infraInCurrentRoundP2 = GameManager.currentRoundInfra[0, 1] + GameManager.currentRoundInfra[1, 1] + GameManager.currentRoundInfra[2, 1] + GameManager.currentRoundInfra[3, 1];
        infraInCurrentRoundP1 = GameManager.currentRoundInfra[0, 0] + GameManager.currentRoundInfra[1, 0] + GameManager.currentRoundInfra[2, 0] + GameManager.currentRoundInfra[3, 0];
        GroundWaterUsedInCurrentRoundP1 = GameManager.currentRoundWater[0, 0] + GameManager.currentRoundWater[1, 0] + GameManager.currentRoundWater[2, 0] + GameManager.currentRoundWater[3, 0];
        GroundWaterUsedInCurrentRoundP2 = GameManager.currentRoundWater[0, 1] + GameManager.currentRoundWater[1, 1] + GameManager.currentRoundWater[2, 1] + GameManager.currentRoundWater[3, 1];

        infraAddedP1.text = "+" + infraInCurrentRoundP1.ToString();
        infraAddedP2.text = "+" + infraInCurrentRoundP2.ToString();

        GWUsedP1.text = "-" + GroundWaterUsedInCurrentRoundP1.ToString();
        GWUsedP2.text = "-" + GroundWaterUsedInCurrentRoundP2.ToString();

        float score1 = 0, score2 = 0;
        for (int i = 0; i < 4; i++)
        {
            score1 += GameManager.currentRoundWater[i, 0];
            score2 += GameManager.currentRoundWater[i, 1];
        }
        roundScore1.text = score1.ToString();
        roundScore2.text = score2.ToString();

        totalScore1[0].text = GameManager.player1Score.ToString();
        totalScore2[0].text = GameManager.player2Score.ToString();
        totalScore1[1].text = GameManager.player1Score.ToString();
        totalScore2[1].text = GameManager.player2Score.ToString();
        totalInfra1.text = GameManager.player1Infra.ToString();
        totalInfra2.text = GameManager.player2Infra.ToString();
        GW1.text = GameManager.player1Groundwater.ToString();
        GW2.text = GameManager.player2Groundwater.ToString();
        player1Region.text = GameManager.player1Region.name.Split(' ')[0];
        player2Region.text = GameManager.player2Region.name.Split(' ')[0];
        //Debug.Log(player1Region.text);
        infraEffP1R1.text = GameManager.player1Region.weights[GameManager.currentRoundCards[0].id].ToString();
        infraEffP2R1.text = GameManager.player2Region.weights[GameManager.currentRoundCards[0].id].ToString();
        infraEffP1R2.text = GameManager.player1Region.weights[GameManager.currentRoundCards[1].id].ToString();
        infraEffP2R2.text = GameManager.player2Region.weights[GameManager.currentRoundCards[1].id].ToString();
        infraEffP1R3.text = GameManager.player1Region.weights[GameManager.currentRoundCards[2].id].ToString();
        infraEffP2R3.text = GameManager.player2Region.weights[GameManager.currentRoundCards[2].id].ToString();
        infraEffP1R4.text = GameManager.player1Region.weights[GameManager.currentRoundCards[3].id].ToString();
        infraEffP2R4.text = GameManager.player2Region.weights[GameManager.currentRoundCards[3].id].ToString();

        // Setting Infra Built
        SetInfraBuilt(
            GameManager.choices[0, 0] == 1 ? "COOPERATE" : "DEFECT",
            GameManager.choices[0, 1] == 1 ? "COOPERATE" : "DEFECT",
            InfraBuiltP1R1,
            InfraBuiltP2R1
            );
        SetInfraBuilt(
            GameManager.choices[1, 0] == 1 ? "COOPERATE" : "DEFECT",
            GameManager.choices[1, 1] == 1 ? "COOPERATE" : "DEFECT",
            InfraBuiltP1R2,
            InfraBuiltP2R2
            );
        SetInfraBuilt(
            GameManager.choices[2, 0] == 1 ? "COOPERATE" : "DEFECT",
            GameManager.choices[2, 1] == 1 ? "COOPERATE" : "DEFECT",
            InfraBuiltP1R3,
            InfraBuiltP2R3
            );
        SetInfraBuilt(
            GameManager.choices[3, 0] == 1 ? "COOPERATE" : "DEFECT",
            GameManager.choices[3, 1] == 1 ? "COOPERATE" : "DEFECT",
            InfraBuiltP1R4,
            InfraBuiltP2R4
            );
    }
    private void CalculateStuff()
    {
        Card[] cards = new Card[4];
        for (int i = 0; i < 4; i++)
            cards[i] = GameManager.cards[(RoundNumber - 1) * 4 + i];
        int player1Water = 0, player2Water = 0;
        int player1Infra = 0, player2Infra = 0;
        int[,] currentRoundWater = new int[4, 2];
        int[,] currentRoundInfra = new int[4, 2];
        for (int i = 0; i < 4; i++)
        {
            int player1Weight = GameManager.player1Region.weights[cards[i].id];
            int player2Weight = GameManager.player2Region.weights[cards[i].id];
            if (choices[i, 0] == 1 && choices[i, 1] == 1)
            {
                currentRoundWater[i, 0] = 10;
                currentRoundWater[i, 1] = 10;
                currentRoundInfra[i, 0] = player1Weight;
                currentRoundInfra[i, 1] = player2Weight;
            }
            else if (choices[i, 0] == 1 && choices[i, 1] == -1)
            {
                currentRoundWater[i, 0] = 0;
                currentRoundWater[i, 1] = 20;
                currentRoundInfra[i, 0] = 2 * player1Weight;
                currentRoundInfra[i, 1] = 0;
            }
            else if (choices[i, 0] == -1 && choices[i, 1] == 1)
            {
                currentRoundWater[i, 0] = 20;
                currentRoundWater[i, 1] = 0;
                currentRoundInfra[i, 0] = 0;
                currentRoundInfra[i, 1] = 2 * player2Weight;
            }
            else if (choices[i, 0] == -1 && choices[i, 1] == -1)
            {
                currentRoundWater[i, 0] = 5;
                currentRoundWater[i, 1] = 5;
                currentRoundInfra[i, 0] = 0;
                currentRoundInfra[i, 1] = 0;

            }
        }
        for (int i = 0; i < 4; i++)
        {
            player1Water += currentRoundWater[i, 0];
            player2Water += currentRoundWater[i, 1];
            player1Infra += currentRoundInfra[i, 0];
            player2Infra += currentRoundInfra[i, 1];
        }
        GameManager.player1Score += player1Water;
        GameManager.player2Score += player2Water;
        GameManager.player1Groundwater -= player1Water;
        GameManager.player2Groundwater -= player2Water;
        GameManager.player1Infra += player1Infra;
        GameManager.player2Infra += player2Infra;
        GameManager.currentRoundWater = currentRoundWater;
        GameManager.currentRoundInfra = currentRoundInfra;

        // if (GameManager.player1Groundwater < 0 || GameManager.player2Groundwater < 0)
        // {
        //     SceneManager.LoadScene("ZeroGW");
        // }
    }
    public void SetImage(string txt, Image img)
    {
        if (txt == "COOPERATE")
        {
            img.sprite = cooperate;
        }
        else
        {
            img.sprite = defect;
        }
    }
    void SetInfraBuilt(string txtP1,string txtP2 ,TextMeshProUGUI UItxtP1, TextMeshProUGUI UItxtP2)
    {
        if (txtP1 == "COOPERATE" && txtP2 == "COOPERATE")
        {
            UItxtP1.text = "1";
            UItxtP2.text = "1";
        }
        else if (txtP1 == "COOPERATE" && txtP2 == "DEFECT")
        {
            UItxtP1.text = "2";
            UItxtP2.text = "0";
        }
        else if(txtP1 == "DEFECT" && txtP2 == "COOPERATE")
        {
            UItxtP1.text = "0";
            UItxtP2.text = "2";
        }
        else if(txtP1 == "DEFECT" && txtP2 == "DEFECT")
        {
            UItxtP1.text = "0";
            UItxtP2.text = "0";
        }
    }
    public void Next(){
        SceneManager.LoadScene("Dice");
    }
}
