using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    public Canvas Punjab;
    public Canvas Karnataka;
    public Canvas Himachal;
    public Canvas Kerala;
    void Start()
    {
        if(GameManager.player1Score>GameManager.player2Score){
            if(GameManager.player1Region.name=="Punjab")
                Punjab.enabled=true;
            else if(GameManager.player1Region.name=="Karnataka")
                Karnataka.enabled=true;
            else if(GameManager.player1Region.name=="Himachal")
                Himachal.enabled=true;
            else if(GameManager.player1Region.name=="Kerala")
                Kerala.enabled=true;
        }
        else{
            if(GameManager.player2Region.name=="Punjab")
                Punjab.enabled=true;
            else if(GameManager.player2Region.name=="Karnataka")
                Karnataka.enabled=true;
            else if(GameManager.player2Region.name=="Himachal")
                Himachal.enabled=true;
            else if(GameManager.player2Region.name=="Kerala")
                Kerala.enabled=true;
        }
    }
}
