using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStart : MonoBehaviour
{
    void Start(){

        GameManager.roundNumber = 1;
        GameManager.player1Infra = 0;
        GameManager.player2Infra = 0;
        GameManager.player1Score = GameManager.initialScore;
        GameManager.player2Score = GameManager.initialScore;

        
        System.Random random = new System.Random();
        if(GameManager.SetManager == -1)
            GameManager.SetManager = random.Next(0, 2);
        else
            GameManager.SetManager = 1-GameManager.SetManager;
        int offset = GameManager.SetManager*2;
        int randomSet = random.Next(offset, 2+offset);
        Debug.Log("Chosen Set: "+randomSet);
        GameManager.currentSet = GameManager.sets[randomSet];
        ShuffleInParts(GameManager.currentSet.Cards, 4);
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
    public void Shuffle(Card[] cards, System.Random random){
        for (int i = cards.Length - 1; i > 0; i--){
            int j = random.Next(0, i + 1);
            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }
    
    public void ShuffleInParts(Card[] array, int partSize)
    {
        System.Random random = new System.Random();
        for (int i = 0; i < array.Length; i += partSize)
        {
            int end = Math.Min(i + partSize, array.Length);
            Card[] subArray = new Card[end - i];
            Array.Copy(array, i, subArray, 0, end - i);
            Shuffle(subArray, random);
            Array.Copy(subArray, 0, array, i, end - i);
        }
    }
    
    
}
