using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class HowToPlayManager : MonoBehaviour
{
    public Canvas Screen1;
    public Canvas Screen2;
    public Canvas Screen3;
    public Canvas Screen4;
    public Canvas Screen5;
    public Canvas Screen6;
    public Canvas Screen7;
    public Canvas Screen8;
    void Start()
    {
        Screen1.gameObject.SetActive(true);
        Screen2.gameObject.SetActive(false);
        Screen3.gameObject.SetActive(false);
        Screen4.gameObject.SetActive(false);
        Screen5.gameObject.SetActive(false);
        Screen6.gameObject.SetActive(false);
        Screen7.gameObject.SetActive(false);
        Screen8.gameObject.SetActive(false);
    }
    public void ShowScene2()
    {
        Screen1.gameObject.SetActive(false);
        Screen2.gameObject.SetActive(true);
        Screen3.gameObject.SetActive(false);
        Screen4.gameObject.SetActive(false);
        Screen5.gameObject.SetActive(false);
        Screen6.gameObject.SetActive(false);
        Screen7.gameObject.SetActive(false);
        Screen8.gameObject.SetActive(false);
    }
    public void ShowScene3()
    {
        Screen1.gameObject.SetActive(false);
        Screen2.gameObject.SetActive(false);
        Screen3.gameObject.SetActive(true);
        Screen4.gameObject.SetActive(false);
        Screen5.gameObject.SetActive(false);
        Screen6.gameObject.SetActive(false);
        Screen7.gameObject.SetActive(false);
        Screen8.gameObject.SetActive(false);
    }
    public void ShowScene4()
    {
        Screen1.gameObject.SetActive(false);
        Screen2.gameObject.SetActive(false);
        Screen3.gameObject.SetActive(false);
        Screen4.gameObject.SetActive(true);
        Screen5.gameObject.SetActive(false);
        Screen6.gameObject.SetActive(false);
        Screen7.gameObject.SetActive(false);
        Screen8.gameObject.SetActive(false);
    }
    
    public void ShowScene5()
    {
        Screen1.gameObject.SetActive(false);
        Screen2.gameObject.SetActive(false);
        Screen3.gameObject.SetActive(false);
        Screen4.gameObject.SetActive(false);
        Screen5.gameObject.SetActive(true);
        Screen6.gameObject.SetActive(false);
        Screen7.gameObject.SetActive(false);
        Screen8.gameObject.SetActive(false);
           
    }
    public void ShowScene6()
    {
        Screen1.gameObject.SetActive(false);
        Screen2.gameObject.SetActive(false);
        Screen3.gameObject.SetActive(false);
        Screen4.gameObject.SetActive(false);
        Screen5.gameObject.SetActive(false);
        Screen6.gameObject.SetActive(true);
        Screen7.gameObject.SetActive(false);
        Screen8.gameObject.SetActive(false);
    }
    public void ShowScene7()
    {
        Screen1.gameObject.SetActive(false);
        Screen2.gameObject.SetActive(false);
        Screen3.gameObject.SetActive(false);
        Screen4.gameObject.SetActive(false);
        Screen5.gameObject.SetActive(false);
        Screen6.gameObject.SetActive(false);
        Screen7.gameObject.SetActive(true);
        Screen8.gameObject.SetActive(false);
    }
    public void ShowScene8()
    {
        Screen1.gameObject.SetActive(false);
        Screen2.gameObject.SetActive(false);
        Screen3.gameObject.SetActive(false);
        Screen4.gameObject.SetActive(false);
        Screen5.gameObject.SetActive(false);
        Screen6.gameObject.SetActive(false);
        Screen7.gameObject.SetActive(false);
        Screen8.gameObject.SetActive(true);
    }
    public void ShowScene1()
    {
        Screen1.gameObject.SetActive(true);
        Screen2.gameObject.SetActive(false);
        Screen3.gameObject.SetActive(false);
        Screen4.gameObject.SetActive(false);
        Screen5.gameObject.SetActive(false);
        Screen6.gameObject.SetActive(false);
        Screen7.gameObject.SetActive(false);
        Screen8.gameObject.SetActive(false);
    }
    public void Home()
    {
        GameManager.home = true;
        SceneManager.LoadScene(0);
    }

}
