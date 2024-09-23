using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStart : MonoBehaviour
{
    void Start(){
        System.Random random = new System.Random();

        if(GameManager.SetManager == -1)
            GameManager.SetManager = random.Next(0, 2);
        else
            GameManager.SetManager = 1-GameManager.SetManager;
            int offset = GameManager.SetManager*2;
        int randomSet = random.Next(offset, 2+offset);
        Debug.Log("Chosen Set: "+randomSet);
        GameManager.currentSet = GameManager.sets[randomSet];
        Shuffle(GameManager.currentSet.Cards);
        GameManager.cards = GameManager.currentSet.Cards;
        GameManager.player1Region = GameManager.currentSet.player1Region;
        GameManager.player2Region = GameManager.currentSet.player2Region;
        GameManager.player1Groundwater = GameManager.player1Region.groundwater;
        GameManager.player2Groundwater = GameManager.player2Region.groundwater;
    }
    public void StartGame(){
        SceneManager.LoadScene("Round");
    }

    public void InstructionsPanel(){
        SceneManager.LoadScene("GameComponents");
    }
    public void QuitGame(){
        Application.Quit();
    }
    // Fisher-Yates shuffle algorithm for the cards
    public void Shuffle(Card[] cards){
        System.Random random = new System.Random();
        for (int i = cards.Length - 1; i > 0; i--){
            int j = random.Next(0, i + 1);
            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }
    
    
    
}
