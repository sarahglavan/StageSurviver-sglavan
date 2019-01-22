using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}

    private void OnTriggerEnter2D(Collider2D col)
	{
        if(col.CompareTag("Player")){
            Destroy(this.gameObject);
            Debug.Log("playercollision");
        }
        else if(col.CompareTag("Ground")){
            Destroy(this.gameObject);
            Debug.Log("groundcollision");
        }
	}
}
// Soll coins die eingesammelt werden zählen