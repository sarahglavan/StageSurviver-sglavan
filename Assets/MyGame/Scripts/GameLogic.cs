using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour {
    public TextMeshProUGUI TomatosNumber;
    public TextMeshProUGUI CoinNumber;
    public int TomatoAmount;
    public int MaxTomatoAmount;
    public int CoinAmount;
    public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DecreaseTomatos(int amount){
        TomatoAmount -= amount;
    }

    public void AddCoin(){
        CoinAmount++;
        
    }


}
