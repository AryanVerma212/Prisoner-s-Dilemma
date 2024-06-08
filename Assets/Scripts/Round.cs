using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Round : MonoBehaviour
{
    int[,] choices = new int[4,2];
    public Image bgIMG;
    public new GameObject camera;
    public TextMeshProUGUI roundNumberText;
    public TextMeshProUGUI playerNumberText;
    public TextMeshProUGUI cardName;
    public TextMeshProUGUI cardDescription1;
    public TextMeshProUGUI cardDescription2;
    public TextMeshProUGUI result;
    public TextMeshProUGUI cardNumberText;

    public TextMeshProUGUI player1RegionText;
    public TextMeshProUGUI player2RegionText;

    public Button cooperateButton;
    public Button defectButton;

    int cardNumber;
    int playerTurn;
    int roundNumber;
    //bool roundCompleted;

    Card[] cards = new Card[4];

    void Start(){
        for (int i=0;i<4;i++) cards[i] = GameManager.cards[(GameManager.roundNumber - 1) * 4 + i];
        GameManager.currentRoundCards = cards;
        //roundCompleted = false;
        playerTurn = 1;
        cardNumber = 0;
        roundNumber = GameManager.roundNumber;
        updateData();
        player1RegionText.text = GameManager.player1Regions[roundNumber-1].name;
        player2RegionText.text = GameManager.player2Regions[roundNumber-1].name;
    }

    private void updateData(){
        if(cardNumber>3){
            //roundCompleted = true;
            //GameManager.roundNumber++;
            GameManager.choices=choices;
            SceneManager.LoadScene("RoundEnd");
            return;
        }
        roundNumberText.text = "Round - " + roundNumber;
        playerNumberText.text = "Player " + playerTurn;
        cardNumberText.text = "Card " +roundNumber+"."+ (cardNumber + 1);
        cardName.text = cards[cardNumber].name;
        cardDescription1.text = cards[cardNumber].description1;
        cardDescription2.text = cards[cardNumber].description2;
        if (playerTurn == 1)
        {
            camera.GetComponent<Camera>().backgroundColor = new Color(0.694f, 0.478f, 0.208f);
            playerNumberText.color = player1RegionText.color;
            bgIMG.color = player1RegionText.color;
        }
        else if (playerTurn == 2)
        {
            camera.GetComponent<Camera>().backgroundColor = new Color(0.22f, 0.31f, 0.675f);
            playerNumberText.color = player2RegionText.color;
            bgIMG.color = player2RegionText.color;
        }
        result.text = "Player "+playerTurn+" must choose to COOPERATE or DEFECT";
    }

    public void playerChoice(int choice){
        choices[cardNumber,playerTurn-1]=choice;
        result.text = "Player "+playerTurn+" chose to "+(choice==1?"COOPERATE":"DEFECT")+"\nSwitch Players...";
        
        if(playerTurn==1)
            playerTurn=2;
        else if(playerTurn==2){
                playerTurn=1;
                cardNumber++;
        }
        StartCoroutine(updateDataCoroutine());
    }

    IEnumerator updateDataCoroutine()
    {
        cooperateButton.interactable = false;
        defectButton.interactable = false;
        yield return new WaitForSeconds(2.5f);
        updateData();
        cooperateButton.interactable = true;
        defectButton.interactable = true;
    }

}
