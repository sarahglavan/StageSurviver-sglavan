using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomatoe : MonoBehaviour {

   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       

		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
        else if (col.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }
    }
}

// wenn dich Tomaten treffen soll man ein Leben Leben verlieren. Der Counter 
// soll von drei Leben runterzählen
