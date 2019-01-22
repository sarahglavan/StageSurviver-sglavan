using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class MenuDisplay : MonoBehaviour {
    public TextMeshProUGUI coinText;
	// Use this for initialization
	void Start () {

        coinText.text = PlayerPrefs.GetInt("coinAmount").ToString();
		
	}
	

}
