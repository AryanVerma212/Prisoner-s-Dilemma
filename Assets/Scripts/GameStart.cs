using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStart : MonoBehaviour
{

    void Start(){
        Shuffle(GameManager.cards);
        ShuffleRegions(GameManager.regions);
    }
    public void StartGame(){
        SceneManager.LoadScene("Round");
    }

    public void InstructionsPanel()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void QuitGame(){
        Application.Quit();
    }

    private void Shuffle<T>(T[] arr){
        for (int i = arr.Length - 1; i > 0; i--){
            int r = UnityEngine.Random.Range(0, i);
            T temp = arr[i];
            arr[i] = arr[r];
            arr[r] = temp;
        }
    }
    private void ShuffleRegions(Region[] originalArray){

        Shuffle(originalArray);

        Region[] array1 = new Region[6];
        Region[] array2 = new Region[6];

        List<int> usedIndices = new List<int>();

        for (int i = 0; i < 6; i++){
            array1[i] = originalArray[i];
            usedIndices.Add(i);
        }

        bool hasMatchingElements = true;
        while (hasMatchingElements){
            Shuffle(originalArray);
            hasMatchingElements = false;

            for (int i = 0; i < 6; i++){
                array2[i] = originalArray[i];

                if (array2[i] == array1[i]){
                    hasMatchingElements = true;
                    break;
                }
            }
        }

        GameManager.player1Regions = array1;
        GameManager.player2Regions = array2;
        // for(int i=0;i<6;i++)
        //     Debug.Log(GameManager.player1Regions[i].name+" "+GameManager.player2Regions[i].name);
    }
}
