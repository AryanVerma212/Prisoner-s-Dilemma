using UnityEngine;
using UnityEngine.SceneManagement;

public class ZeroGW1 : MonoBehaviour
{
    public Canvas Karnataka;
    public Canvas Punjab;
    void Start()
    {
        Karnataka.gameObject.SetActive(false);
        Punjab.gameObject.SetActive(false);
        if(GameManager.player1Groundwater<=0 && GameManager.player1Region.name=="Karnataka (Plateau)")
            Karnataka.gameObject.SetActive(true);
        if(GameManager.player2Groundwater<=0 && GameManager.player2Region.name=="Karnataka (Plateau)")
            Karnataka.gameObject.SetActive(true);
        if(GameManager.player1Groundwater<=0 && GameManager.player1Region.name=="Punjab (Agricultural)")
            Punjab.gameObject.SetActive(true);
        if(GameManager.player2Groundwater<=0 && GameManager.player2Region.name=="Punjab (Agricultural)")
            Punjab.gameObject.SetActive(true);
    }
    public void Finish(){
        SceneManager.LoadScene("GameOver");
    }
   
}
