using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour 
{
    private SceneLoader sceneLoader;
    public TextMeshProUGUI tomatoNumber;
    public TextMeshProUGUI coinNumber;
    public int tomatoAmount;
    public int maxTomatoAmount;
    public int coinAmount;
    public GameObject player;

	void Start() 
    {
        tomatoAmount = 3; 
        sceneLoader = GameObject.FindGameObjectWithTag("Manager").GetComponent<SceneLoader>(); //definiere Sceneloader Script den ich brauche
    }
	
	void Update() 
    {
        tomatoNumber.text = tomatoAmount.ToString();
        coinNumber.text = coinAmount.ToString();
    }

    public void DecreaseTomatos()
    {
        tomatoAmount --;
        if (tomatoAmount == 0)
        {
            PlayerPrefs.SetInt("coinAmount", coinAmount);
            sceneLoader.SwitchToScene("GameOver");
        }
    }

    public void AddCoin() 
    {
        coinAmount ++ ; 
    }
}
