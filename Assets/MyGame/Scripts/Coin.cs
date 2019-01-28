using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    GameLogic gameLogic;

    void Start () 
    {
        gameLogic = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameLogic> ();

    }
	
    private void OnTriggerEnter2D(Collider2D col)
	{
        if (col.CompareTag("Player"))
        {

            gameLogic.AddCoin ();
            Destroy(this.gameObject);

            Debug.Log("playercollision");
        }
        else if(col.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
            Debug.Log("groundcollision");
        }
	}




}
// Soll coins die eingesammelt werden zählen