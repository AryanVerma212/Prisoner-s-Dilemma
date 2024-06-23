using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    public Canvas Assam;
    public Canvas Karntk;
    public Canvas Himachal;
    void Start()
    {
        if (GameManager.player1Score > GameManager.player2Score)
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
        else
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
        if (GameManager.player1Score <=0)
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
        else if(GameManager.player2Score <= 0)
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
}
