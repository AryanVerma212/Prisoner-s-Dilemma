using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    public GameObject[] panels;
    [SerializeField] GameObject btn;
    [SerializeField] Button bt;
    int clicked = 1;
    // Start is called before the first frame update
    void Start()
    {
        bt.onClick.AddListener(Deselect);
    }
    void Deselect()
    {
        // Deselect the button
        EventSystem.current.SetSelectedGameObject(null);
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
