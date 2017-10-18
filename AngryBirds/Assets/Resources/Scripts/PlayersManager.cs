﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersManager : MonoBehaviour {

    private string strPlayer;
    private int numPlayers;

    public Transform playerPos;

	// Use this for initialization
	void Start () 
    {
        strPlayer = "cat";
        numPlayers = 3;
        createPlayer();
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    void createPlayer()
    {
        GameObject playerPrefab = (GameObject)Resources.Load("Prefabs/Players/"+strPlayer, typeof(GameObject));
        if(playerPrefab)
            Instantiate(playerPrefab, playerPos.position, playerPrefab.transform.rotation);
    }

    public string getSelectedPlayer()
    {
        return strPlayer;
    }

    public int getNumOfPlayers()
    {
        return numPlayers;
    }

}
