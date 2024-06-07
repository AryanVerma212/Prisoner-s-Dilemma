using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    public GameObject[] panels;
    [SerializeField] GameObject btn;
    int clicked = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMainScreen()
    {
        SceneManager.LoadScene("GameStart");
    }
    public void SceneChange()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void OnContinuePressed()
    {
        panels[clicked-1].SetActive(false);
        panels[clicked].SetActive(true);
        Debug.Log(clicked);
        if(clicked == 4)
        {
            btn.SetActive(false);
        }
        if(clicked < panels.Length) 
        {
            clicked++;
        }
        
    }
}
