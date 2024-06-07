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
    public TextMeshProUGUI result1;


    public TextMeshProUGUI card2Name;
    public Image card2Player1Image;
    public Image card2Player2Image;
    public TextMeshProUGUI result2;


    public TextMeshProUGUI card3Name;
    public Image card3Player1Image;
    public Image card3Player2Image;
    public TextMeshProUGUI result3;


    public TextMeshProUGUI card4Name;
    public Image card4Player1Image;
    public Image card4Player2Image;
    public TextMeshProUGUI result4;

    public TextMeshProUGUI roundScore1;
    public TextMeshProUGUI roundScore2;

    public TextMeshProUGUI totalScore1;
    public TextMeshProUGUI totalScore2;

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

        result1.text=GameManager.currentRoundScore[0,0].ToString("F1")+" - "+GameManager.currentRoundScore[0,1].ToString("F1");
        result2.text=GameManager.currentRoundScore[1,0].ToString("F1")+" - "+GameManager.currentRoundScore[1,1].ToString("F1");
        result3.text=GameManager.currentRoundScore[2,0].ToString("F1")+" - "+GameManager.currentRoundScore[2,1].ToString("F1");
        result4.text=GameManager.currentRoundScore[3,0].ToString("F1")+" - "+GameManager.currentRoundScore[3,1].ToString("F1");

        float score1 = 0, score2 = 0;
        for (int i = 0; i < 4; i++)
        {
            score1 += GameManager.currentRoundScore[i, 0];
            score2 += GameManager.currentRoundScore[i, 1];
        }
        roundScore1.text = score1.ToString();
        roundScore2.text = score2.ToString();

        totalScore1.text = GameManager.player1Score.ToString("F1");
        totalScore2.text = GameManager.player2Score.ToString("F1");

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
        SceneManager.LoadScene("Dice1");
    }
}
