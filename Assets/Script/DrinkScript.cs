using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkScript : MonoBehaviour {

	private StageGameManager sgm;

	// Use this for initialization
	void Start () {
		sgm = GameObject.Find("GameManager").GetComponent<StageGameManager>();
	}
	
	void OnMouseDown(){
		sgm.ClickWater();
	}
}
