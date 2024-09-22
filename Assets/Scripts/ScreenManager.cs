using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    public Canvas Screen1;
    public Canvas Screen2;
    public Canvas Screen3;
    public Canvas Screen4;
    void Start()
    {
        if(GameManager.home){
            //if the opening titles have already been displayed, skip them
           ShowScene4();
           //Debug.Log("Home Visited");
           return;
        }
        Screen1.gameObject.SetActive(true);
        Screen2.gameObject.SetActive(false);
        Screen3.gameObject.SetActive(false);
        Screen4.gameObject.SetActive(false);
    }
    public void ShowScene2()
    {
        Screen1.gameObject.SetActive(false);
        Screen2.gameObject.SetActive(true);
        Screen3.gameObject.SetActive(false);
        Screen4.gameObject.SetActive(false);
    }
    public void ShowScene3()
    {
        Screen1.gameObject.SetActive(false);
        Screen2.gameObject.SetActive(false);
        Screen3.gameObject.SetActive(true);
        Screen4.gameObject.SetActive(false);
    }
    public void ShowScene4()
    {
        Screen1.gameObject.SetActive(false);
        Screen2.gameObject.SetActive(false);
        Screen3.gameObject.SetActive(false);
        Screen4.gameObject.SetActive(true);
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void Play()
    {
        SceneManager.LoadScene("Round");
    }
    
    public void Instruction()
    {
        SceneManager.LoadScene("GameComponents");
    }

    public void Exit()
    {
        Application.Quit();
    }

    
}
