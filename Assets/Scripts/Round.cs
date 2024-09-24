using System.Collections;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class Round : MonoBehaviour
{
    int[,] choices = new int[4,2];

    public GameObject[] canvas;
    public TextMeshProUGUI timerText;
    public Image bgIMG;
    public Image CardPanelImage;
    public Sprite[] bgSprites;
    public Sprite[] CardSprites;
    public new GameObject camera;
    public TextMeshProUGUI roundNumberText;
    public TextMeshProUGUI playerNumberText;
    
    
    public TextMeshProUGUI result;
    public TextMeshProUGUI cardNumberText;


    public TextMeshProUGUI player1Region;
    public TextMeshProUGUI player2Region;
    public TextMeshProUGUI player1RegionText;
    public TextMeshProUGUI player2RegionText;
    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;

    public Image RegionalCard1;
    public Image RegionalCard2;
    public Sprite[] RegionalCards;

    public Button cooperateButton;
    public Button defectButton;

    int cardNumber;
    int playerTurn;
    int roundNumber;
    //bool roundCompleted;
    private float startTime;
    bool isTimerRunning;
    Card[] cards = new Card[4];

    void Start(){
        for (int i=0;i<4;i++) cards[i] = GameManager.cards[4*(GameManager.roundNumber-1)+i];
        GameManager.currentRoundCards = cards;
        //roundCompleted = false;
        playerTurn = 1;
        cardNumber = 0;
        roundNumber = GameManager.roundNumber;
        updateData();
        player1RegionText.text = GameManager.player1Region.name;
        player2RegionText.text = GameManager.player2Region.name;
        player1ScoreText.text = GameManager.player1Score.ToString();
        player2ScoreText.text = GameManager.player2Score.ToString();
        RegionalCard1.sprite = RegionalCards.FirstOrDefault(sprite => sprite.name == GameManager.player1Region.name);
        RegionalCard2.sprite = RegionalCards.FirstOrDefault(sprite => sprite.name == GameManager.player2Region.name);
        startTime = Time.time;
        isTimerRunning = true;
        canvas[1].SetActive(false);
        canvas[0].SetActive(true);
    }
    private void Update()
    {
        if (!isTimerRunning)
            return;
        float elapsedTime = Time.time - startTime;
        string seconds = ((5.0-elapsedTime) % 60).ToString("00");
        timerText.text = seconds;
        if (elapsedTime > 5.0)
        {
            isTimerRunning = false;
            canvas[0].SetActive(false);
            canvas[1].SetActive(true);
        }
    }
    private void updateData(){
        if(cardNumber>3){
            //roundCompleted = true;
            //GameManager.roundNumber++;
            GameManager.choices=choices;
            SceneManager.LoadScene("ShowData");
            return;
        }
        roundNumberText.text = "Round " + roundNumber;
        cardNumberText.text = "Card " +roundNumber+"."+ (cardNumber + 1);
        CardPanelImage.sprite = CardSprites[GameManager.currentRoundCards[cardNumber].id];
        Debug.Log(GameManager.currentRoundCards[cardNumber].id + " "+ GameManager.currentRoundCards[cardNumber].name);
        player1Region.text = GameManager.player1Region.name.Split(' ')[0];
        player2Region.text = GameManager.player2Region.name.Split(' ')[0];
        if (playerTurn == 1)
        {
            //camera.GetComponent<Camera>().backgroundColor = new Color(0.694f, 0.478f, 0.208f);
            //playerNumberText.color = player1RegionText.color;
            string turn = GameManager.player1Region.name;
            player1Region.color = player1ScoreText.color;
            player2Region.color = Color.white;
            playerNumberText.text = turn.Split(' ')[0] + "'s" + " " + "Turn!";
            bgIMG.sprite = bgSprites.FirstOrDefault(sprite => sprite.name == GameManager.player1Region.name);
           
        }
        else if (playerTurn == 2)
        {
            //camera.GetComponent<Camera>().backgroundColor = new Color(0.22f, 0.31f, 0.675f);
            string turn = GameManager.player2Region.name;
            player2Region.color = player1ScoreText.color;
            player1Region.color = Color.white;
            playerNumberText.text = turn.Split(' ')[0] + "'s" + " " + "Turn!";
            bgIMG.sprite = bgSprites.FirstOrDefault(sprite => sprite.name == GameManager.player2Region.name);
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
        yield return new WaitForSeconds(2.0f);
        updateData();
        cooperateButton.interactable = true;
        defectButton.interactable = true;
    }

}
