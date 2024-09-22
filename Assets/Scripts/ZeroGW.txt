using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZeroGW : MonoBehaviour
{
    public TextMeshProUGUI loser;
    public TextMeshProUGUI winner;
    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;
    public TextMeshProUGUI player1Region;
    public TextMeshProUGUI player2Region;
    public TextMeshProUGUI originalGW;
    public TextMeshProUGUI extractedWater;

    void Start()
    {
        if(GameManager.player1Groundwater<0){
            loser.text = player1Region.name + "is out of groundwater";
            winner.text = "Player 2";
        }
        else{
            loser.text = player2Region.name + "is out of groundwater";
            winner.text = "Player 1";
        }
        player1ScoreText.text = GameManager.player1Score.ToString();
        player2ScoreText.text = GameManager.player2Score.ToString();
        player1Region.text = GameManager.player1Region.name;
        player2Region.text = GameManager.player2Region.name;
        originalGW.text = "Original GW: " + GameManager.player1Region.groundwater.ToString();
        extractedWater.text = "Extracted Water: "+ (GameManager.player1Score-GameManager.initialScore).ToString();
    }

    public void Restart(){
        SceneManager.LoadScene("GameStart");
    }
    public void Quit(){
        Application.Quit();
    }
}
