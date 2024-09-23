using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameExit : MonoBehaviour
{
    public Canvas Punjab;
    public Canvas Karnataka;
    public Canvas Himachal;
    public Canvas Kerala;
    void Start()
    {
        String winner;
        if(GameManager.player1Groundwater<=0) winner = GameManager.player2Region.name;
        else if(GameManager.player2Groundwater<=0) winner = GameManager.player1Region.name;
        else if(GameManager.player1Score>GameManager.player2Score) winner = GameManager.player1Region.name;
        else if(GameManager.player1Score<GameManager.player2Score) winner = GameManager.player2Region.name;
        else winner = "Draw";

        switch(winner){
            case "Punjab (Agricultural)":
                Punjab.gameObject.SetActive(true);
                break;
            case "Karnataka (Plateau)":
                Karnataka.gameObject.SetActive(true);
                break;
            case "Himachal (Himalayan)":
                Himachal.gameObject.SetActive(true);
                break;
            case "Kerala (Coastal)":
                Kerala.gameObject.SetActive(true);
                break;
        }
    }

    public void QuitGame(){
        SceneManager.LoadScene("GameStart");
    }
}
