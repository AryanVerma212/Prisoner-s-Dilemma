using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class RoundEnd : MonoBehaviour
{
    public TextMeshProUGUI roundNumberText;
    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;
    public TextMeshProUGUI player1Region;
    public TextMeshProUGUI player2Region;
    private int roundNumber;
    private int[,] choices;
    void Start()
    {
        choices=GameManager.choices;
        roundNumber=GameManager.roundNumber;
        //Debug.Log(roundNumber);
        calculateStuff();
        roundNumberText.text = "Round "+roundNumber+" Completed";
        showResult();
        player1Region.text = GameManager.player1Regions[roundNumber-1].name;
        player2Region.text = GameManager.player2Regions[roundNumber-1].name;
    }
    private void calculateStuff(){
        Card[] cards=new Card[4];
        for(int i=0;i<4;i++)
            cards[i]=GameManager.cards[(roundNumber-1)*4+i];

        float player1Score=0, player2Score=0;
        float[,] currentRoundScore=new float[4,2];
        for(int i=0;i<4;i++){
            int player1Weight=GameManager.player1Regions[roundNumber-1].weights[cards[i].id];
            int player2Weight=GameManager.player2Regions[roundNumber-1].weights[cards[i].id];
            if(choices[i,0]==1 && choices[i,1]==1){
                currentRoundScore[i,0]=player1Weight;
                currentRoundScore[i,1]=player2Weight;
            }
            else if(choices[i,0]==1 && choices[i,1]==-1){
                currentRoundScore[i,0]=0;
                currentRoundScore[i,1]=player2Weight*2;
            }
            else if(choices[i,0]==-1 && choices[i,1]==1){
                currentRoundScore[i,0]=player1Weight*2;
                currentRoundScore[i,1]=0;
            }
            else if(choices[i,0]==-1 && choices[i,1]==-1){
                currentRoundScore[i,0]=player1Weight / 2.0f;
                currentRoundScore[i,1]=player2Weight / 2.0f;
                
            }
        }
        for(int i=0;i<4;i++){
            player1Score+=currentRoundScore[i,0];
            player2Score+=currentRoundScore[i,1];
        }
        GameManager.currentRoundScore=currentRoundScore;
        GameManager.player1Score+=player1Score;
        GameManager.player2Score+=player2Score;
    }
    private void showResult(){
        player1ScoreText.text = GameManager.player1Score.ToString("F1");
        player2ScoreText.text = GameManager.player2Score.ToString("F1");
    }

    public void showData(){
        SceneManager.LoadScene("ShowData");
    }
}
