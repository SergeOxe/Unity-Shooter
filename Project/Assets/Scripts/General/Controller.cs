﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Controller : MonoBehaviour {
	public GameObject bullet;
	public GameObject heroPos;
	Vector3 startPos;
	private int score;
	//public Text scoreText;
		
	void Start(){
		score = 0;
		//scoreText.text = "Score: "+score;
	}

	public void addScore(int points){
		score += points;	
	}

	public int getScore(){
		return score;	
	}
}
