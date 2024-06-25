using UnityEngine;

public class ZeroGW1 : MonoBehaviour
{

    public Canvas Assam;
    public Canvas Karntk;
    public Canvas Himachal;
    void Start()
    {
        if (GameManager.player1Groundwater <= 0)
        {
            if (GameManager.player1Region == GameManager.Assam)
            {
                Assam.gameObject.SetActive(true);
                Karntk.gameObject.SetActive(false);
                Himachal.gameObject.SetActive(false);
            }
            else if (GameManager.player1Region == GameManager.Karnataka)
            {
                Karntk.gameObject.SetActive(true);
                Assam.gameObject.SetActive(false);
                Himachal.gameObject.SetActive(false);
            }
            else if (GameManager.player1Region == GameManager.Himachal)
            {
                Himachal.gameObject.SetActive(true);
                Karntk.gameObject.SetActive(false);
                Himachal.gameObject.SetActive(false);
            }
        }
        else if (GameManager.player2Groundwater <= 0)
        {
            if (GameManager.player2Region == GameManager.Assam)
            {
                Assam.gameObject.SetActive(true);
                Karntk.gameObject.SetActive(false);
                Himachal.gameObject.SetActive(false);
            }
            else if (GameManager.player2Region == GameManager.Karnataka)
            {
                Karntk.gameObject.SetActive(true);
                Assam.gameObject.SetActive(false);
                Himachal.gameObject.SetActive(false);
            }
            else if (GameManager.player2Region == GameManager.Himachal)
            {
                Himachal.gameObject.SetActive(true);
                Karntk.gameObject.SetActive(false);
                Himachal.gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
   
}
