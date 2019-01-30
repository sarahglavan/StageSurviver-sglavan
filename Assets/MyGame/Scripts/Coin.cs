using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    GameLogic gameLogic;

    void Start () 
    {
        gameLogic = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameLogic> ();
        //gameLogic = null;

    }
	
    private void OnTriggerEnter2D(Collider2D col)
	{
        if (col.CompareTag("Player"))
        {
            if (gameLogic != null)
            {
                gameLogic.AddCoin();
                Destroy(this.gameObject);
                Debug.Log("Gamelogic!=null");
            }
            else
            {
                Debug.Log("Gamelogic=null");
            }


            Debug.Log("playercollision");
        }
        else if(col.CompareTag("Ground"))
        {
            if (gameLogic == null)
            {
                Debug.Log("Gamelogic=null22");
                return;
            }
            Destroy(this.gameObject);
            Debug.Log("groundcollision");
        }
      
    }




}
// Soll coins die eingesammelt werden zählen