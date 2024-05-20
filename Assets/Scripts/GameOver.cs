using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI winner;
    public TextMeshProUGUI player1Score;
    public TextMeshProUGUI player2Score;
    // Start is called before the first frame update
    void Start()
    {
        
        player1Score.text = GameManager.player1Score.ToString("F1");
        player2Score.text = GameManager.player2Score.ToString("F1");
        if(GameManager.player1Score>GameManager.player2Score){
            winner.text = "Player 1";
            winner.color=new Color(0.516f,1f,0.15f);
        }
        else if(GameManager.player1Score<GameManager.player2Score){

            winner.text = "Player 2";
            winner.color=new Color(0.965f,1f,0.308f);
        }
        else{
            winner.text = "Tie";
            winner.color=Color.blue;
        }

    }

    public void StartOver(){
        GameManager.roundNumber=1;
        GameManager.player1Score=30;
        GameManager.player2Score=30;
        SceneManager.LoadScene("GameStart");
    }
    public void Quit(){
        Application.Quit();
    }
}
