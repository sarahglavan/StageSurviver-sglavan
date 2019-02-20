using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuDisplay : MonoBehaviour 
{
    public TextMeshProUGUI coinText; 

	void Start() 
    {
        coinText.text = PlayerPrefs.GetInt("coinAmount").ToString(); //Updated Text in der Gamover Scene

    }
}
