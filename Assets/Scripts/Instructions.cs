using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    public GameObject[] panels;
    /*[SerializeField] GameObject btn;
    [SerializeField] GameObject btn2;*/
    [SerializeField] Button bt;
    [SerializeField] Button bt2;

    int clicked = 1;
    // Start is called before the first frame update
    void Start()
    {
        bt.onClick.AddListener(Deselect);
        bt2.onClick.AddListener(Deselect);
        //btn2.SetActive(false);
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
        //btn2.SetActive(true);
        panels[clicked-1].SetActive(false);
        panels[clicked].SetActive(true);
        Debug.Log(clicked);
        if(clicked < panels.Length - 1) 
        {
            clicked++;
        }        
    }
    public void Back()
    {
        if (clicked == 1)
        {
            SceneManager.LoadScene("GameStart");
        }
        else if (clicked > 1) 
        { 
            panels[clicked - 1].SetActive(false);
            panels[clicked - 2].SetActive(true);
            Debug.Log("clicked back");
            clicked--;
        }
    }
}
