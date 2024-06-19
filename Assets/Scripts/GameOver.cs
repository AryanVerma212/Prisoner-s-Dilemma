using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI winner;
    public TextMeshProUGUI player1Score;
    public TextMeshProUGUI player2Score;
    public TextMeshProUGUI player1Region;
    public TextMeshProUGUI player2Region;
    void Start()
    {
        
        player1Score.text = GameManager.player1Score.ToString();
        player2Score.text = GameManager.player2Score.ToString();
        player1Region.text = GameManager.player1Region.name;
        player2Region.text = GameManager.player2Region.name;
        
        if(GameManager.player1Score>GameManager.player2Score){
            winner.text = GameManager.player1Region.name;
            winner.color=new Color(0.516f,1f,0.15f);
        }
        else if(GameManager.player1Score<GameManager.player2Score){
            winner.text = GameManager.player2Region.name;
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
