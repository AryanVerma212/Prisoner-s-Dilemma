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
    public TextMeshProUGUI waterResult1;
    public TextMeshProUGUI infraResult1;


    public TextMeshProUGUI card2Name;
    public Image card2Player1Image;
    public Image card2Player2Image;
    public TextMeshProUGUI waterResult2;
    public TextMeshProUGUI infraResult2;


    public TextMeshProUGUI card3Name;
    public Image card3Player1Image;
    public Image card3Player2Image;
    public TextMeshProUGUI waterResult3;
    public TextMeshProUGUI infraResult3;

    public TextMeshProUGUI card4Name;
    public Image card4Player1Image;
    public Image card4Player2Image;
    public TextMeshProUGUI waterResult4;
    public TextMeshProUGUI infraResult4;
    public TextMeshProUGUI roundScore1;
    public TextMeshProUGUI roundScore2;

    public TextMeshProUGUI totalScore1;
    public TextMeshProUGUI totalScore2;
    public TextMeshProUGUI totalInfra1;
    public TextMeshProUGUI totalInfra2;
    public TextMeshProUGUI GW1;
    public TextMeshProUGUI GW2;

    private Card[] cards;
    void Start()
    {
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

        waterResult1.text=GameManager.currentRoundWater[0,0].ToString()+" - "+GameManager.currentRoundWater[0,1].ToString();
        waterResult2.text=GameManager.currentRoundWater[1,0].ToString()+" - "+GameManager.currentRoundWater[1,1].ToString();
        waterResult3.text=GameManager.currentRoundWater[2,0].ToString()+" - "+GameManager.currentRoundWater[2,1].ToString();
        waterResult4.text=GameManager.currentRoundWater[3,0].ToString()+" - "+GameManager.currentRoundWater[3,1].ToString();

        infraResult1.text=GameManager.currentRoundInfra[0,0].ToString()+" - "+GameManager.currentRoundInfra[0,1].ToString();
        infraResult2.text=GameManager.currentRoundInfra[1,0].ToString()+" - "+GameManager.currentRoundInfra[1,1].ToString();
        infraResult3.text=GameManager.currentRoundInfra[2,0].ToString()+" - "+GameManager.currentRoundInfra[2,1].ToString();
        infraResult4.text=GameManager.currentRoundInfra[3,0].ToString()+" - "+GameManager.currentRoundInfra[3,1].ToString();

        float score1 = 0, score2 = 0;
        for (int i = 0; i < 4; i++)
        {
            score1 += GameManager.currentRoundWater[i, 0];
            score2 += GameManager.currentRoundWater[i, 1];
        }
        roundScore1.text = score1.ToString();
        roundScore2.text = score2.ToString();

        totalScore1.text = GameManager.player1Score.ToString();
        totalScore2.text = GameManager.player2Score.ToString();
        totalInfra1.text = GameManager.player1Infra.ToString();
        totalInfra2.text = GameManager.player2Infra.ToString();
        GW1.text = GameManager.player1Groundwater.ToString();
        GW2.text = GameManager.player2Groundwater.ToString();

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
    public void Next(){
        SceneManager.LoadScene("Dice");
    }
}
