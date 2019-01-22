using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour {
    public TextMeshProUGUI TomatosNumber;
    public TextMeshProUGUI CoinNumber;
    public int tomatoAmount;
    public int MaxTomatoAmount;
    public int coinAmount;
    public GameObject Player;
    private SceneLoader sceneLoader;

	// Use this for initialization
	void Start () {
        tomatoAmount = 3;
        sceneLoader = GameObject.FindGameObjectWithTag("Manager").GetComponent<SceneLoader>();

    }
	
	// Update is called once per frame
	void Update () {

        if(tomatoAmount == 0){
            Debug.Log("wechsle Scene");

        }
        TomatosNumber.text = tomatoAmount.ToString();
        CoinNumber.text = coinAmount.ToString();

    }

    public void DecreaseTomatos(){
        tomatoAmount--;
        if (tomatoAmount == 0)
        {
            sceneLoader.SwitchToScene("GameOver");
        }

       

    }

    public void AddCoin(){
        coinAmount++;

        
    }


}
