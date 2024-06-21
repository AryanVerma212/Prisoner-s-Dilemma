using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Dice : MonoBehaviour
{
    //public TextMeshProUGUI diceText;
    public GameObject[] canvas;
    public Sprite[] BackgroundSprites;
    public Image BackgroundImage;
    public TextMeshProUGUI diceNumber;
    public TextMeshProUGUI player1;
    public TextMeshProUGUI player2;

    public TextMeshProUGUI player1Deduction;
    public TextMeshProUGUI player2Deduction;

    public TextMeshProUGUI player1Score;
    public TextMeshProUGUI player2Score;

    public TextMeshProUGUI player1Infra;
    public TextMeshProUGUI player2Infra;

    public Button rollButton;
    public Button nextButton;
    int roundNumber=GameManager.roundNumber;

    int[,] dice={{1,2,3,0,0,0},
                 {1,2,3,0,0,0},
                 {1,2,3,4,0,0},
                 {1,2,3,4,0,0},
                 {1,2,3,4,5,0},
                 {1,2,3,4,5,0}};
    
    void Start(){
        player1.gameObject.SetActive(false);
        player2.gameObject.SetActive(false);
        
        nextButton.interactable=false;
        canvas[0].SetActive(true);
        canvas[1].SetActive(false);
    }

    private void updateStuff()
    {
        if(roundNumber == 1 || roundNumber == 2)
        {
            BackgroundImage.sprite = BackgroundSprites[0];
        }
        else if(roundNumber == 3 || roundNumber == 4)
        {
            BackgroundImage.sprite = BackgroundSprites[1];
        }
        else if(roundNumber==5 || roundNumber==6)
        {
            BackgroundImage.sprite = BackgroundSprites[2];
        }
        System.Random random=new System.Random();
        int n=dice[roundNumber-1,random.Next(0,6)];
        Debug.Log("Disaster Intensity: " + n);
        diceNumber.text = n.ToString();

        player1.gameObject.SetActive(true);
        player2.gameObject.SetActive(true);

        int deduction1=(int)Math.Round((double)(n*25/(1+GameManager.player1Infra)));
        int deduction2=(int)Math.Round((double)(n*25/(1+GameManager.player2Infra)));
        

        player1Deduction.text = deduction1.ToString();
        player2Deduction.text = deduction2.ToString();

        GameManager.player1Score-=deduction1;
        GameManager.player2Score-=deduction2;

        player1Score.text = GameManager.player1Score.ToString();
        player2Score.text = GameManager.player2Score.ToString();
        player1Infra.text = GameManager.player1Infra.ToString();
        player2Infra.text = GameManager.player2Infra.ToString();

        nextButton.interactable=true;
    }

    public void rollDice(){
        canvas[0].SetActive(false);
        canvas[1].SetActive(true);
        updateStuff();
    }

    public void next(){
        if(GameManager.roundNumber==GameManager.totalRounds){
            SceneManager.LoadScene("GameOver");
        }
        else{
            GameManager.roundNumber++;
            SceneManager.LoadScene("Round");
        }
    }

}
