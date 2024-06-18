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
        CalculateStuff();
        roundNumberText.text = "Round "+roundNumber+" Completed";
        showResult();
        player1Region.text = GameManager.player1Region.name;
        player2Region.text = GameManager.player2Region.name;
    }
    private void CalculateStuff(){
        Card[] cards=new Card[4];
        for(int i=0;i<4;i++)
            cards[i]=GameManager.cards[(roundNumber-1)*4+i];

        int player1Water=0, player2Water=0;
        int player1Infra=0, player2Infra=0;
        int[,] currentRoundWater=new int[4,2];
        int[,] currentRoundInfra=new int[4,2];
        for(int i=0;i<4;i++){
            int player1Weight=GameManager.player1Region.weights[cards[i].id];
            int player2Weight=GameManager.player2Region.weights[cards[i].id];
            if(choices[i,0]==1 && choices[i,1]==1){
                currentRoundWater[i,0]=10;
                currentRoundWater[i,1]=10;
                currentRoundInfra[i,0]=player1Weight;
                currentRoundInfra[i,1]=player2Weight;
            }
            else if(choices[i,0]==1 && choices[i,1]==-1){
                currentRoundWater[i,0]=0;
                currentRoundWater[i,1]=20;
                currentRoundInfra[i,0]=2*player2Weight;
                currentRoundInfra[i,1]=0;
            }
            else if(choices[i,0]==-1 && choices[i,1]==1){
                currentRoundWater[i,0]=20;
                currentRoundWater[i,1]=0;
                currentRoundInfra[i,0]=0;
                currentRoundInfra[i,1]=2*player1Weight;
            }
            else if(choices[i,0]==-1 && choices[i,1]==-1){
                currentRoundWater[i,0]=5;
                currentRoundWater[i,1]=5;
                currentRoundInfra[i,0]=0;
                currentRoundInfra[i,1]=0;
                
            }
        }
        for(int i=0;i<4;i++){
            player1Water+=currentRoundWater[i,0];
            player2Water+=currentRoundWater[i,1];
            player1Infra+=currentRoundInfra[i,0];
            player2Infra+=currentRoundInfra[i,1];
        }
        GameManager.player1Score+=player1Water;
        GameManager.player2Score+=player2Water;
        GameManager.player1Region.groundwater-=player1Water;
        GameManager.player2Region.groundwater-=player2Water;
        GameManager.player1Infra+=player1Infra;
        GameManager.player2Infra+=player2Infra;

        if(GameManager.player1Region.groundwater<0 || GameManager.player2Region.groundwater<0){
            //Game Finished
        }
    }
    private void showResult(){
        player1ScoreText.text = GameManager.player1Score.ToString("F1");
        player2ScoreText.text = GameManager.player2Score.ToString("F1");
    }

    public void showData(){
        SceneManager.LoadScene("ShowData");
    }
}
