using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dice : MonoBehaviour
{
    //public TextMeshProUGUI diceText;

    public TextMeshProUGUI player1;
    public TextMeshProUGUI player2;

    public TextMeshProUGUI player1Initial;
    public TextMeshProUGUI player2Initial;

    public TextMeshProUGUI player1Deduction;
    public TextMeshProUGUI player2Deduction;

    public TextMeshProUGUI player1Score;
    public TextMeshProUGUI player2Score;

    public TextMeshProUGUI info;

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
        info.gameObject.SetActive(false);
        player1Initial.text = GameManager.player1Score.ToString("F1");
        player2Initial.text = GameManager.player2Score.ToString("F1");
        nextButton.interactable=false;
    }

    private void updateStuff(){
        player1Initial.text = GameManager.player1Score.ToString("F1");
        player2Initial.text = GameManager.player2Score.ToString("F1");
        int player1Coo=0, player2Coo=0, player1Def=0, player2Def=0;
        for(int i=0;i<4;i++){
            player1Coo+=(GameManager.choices[i,0]==1)?1:0;
            player2Coo+=(GameManager.choices[i,1]==1)?1:0;
            player1Def+=(GameManager.choices[i,0]==-1)?1:0;
            player2Def+=(GameManager.choices[i,1]==-1)?1:0;
        }
        float f;
        if(roundNumber==1 || roundNumber==2) f=6;
        else if(roundNumber==3 || roundNumber==4) f=3.6f;
        else f=2.4f;

        System.Random random=new System.Random();
        int n=dice[roundNumber-1,random.Next(0,6)];
        Debug.Log(n);

        float deduction1=player1Coo*n+f*player1Def*n;
        float deduction2=player2Coo*n+f*player2Def*n;

        player1.gameObject.SetActive(true);
        player2.gameObject.SetActive(true);
        info.gameObject.SetActive(true);

        player1Deduction.text = deduction1.ToString("F1");
        player2Deduction.text = deduction2.ToString("F1");

        GameManager.player1Score-=deduction1;
        GameManager.player2Score-=deduction2;
        if(GameManager.player1Score<0) GameManager.player1Score=0;
        if(GameManager.player2Score<0) GameManager.player2Score=0;

        player1Score.text = GameManager.player1Score.ToString();
        player2Score.text = GameManager.player2Score.ToString();

        rollButton.interactable=false;
        nextButton.interactable=true;
    }

    public void rollDice(){
        updateStuff();
    }

    public void next(){
        if(GameManager.roundNumber==GameManager.totalRounds){
            SceneManager.LoadScene("GameOver");
            return;
        }
        else{
            GameManager.roundNumber++;
            SceneManager.LoadScene("Round");
        }
    }

}
