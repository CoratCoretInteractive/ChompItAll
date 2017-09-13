using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour {

	private StageGameManager sgm;

	public int totalBite, hungerPerBite;
	private int currBite;
	// Use this for initialization
	void Start () {
		sgm = GameObject.Find("GameManager").GetComponent<StageGameManager>();
	}

	void OnMouseDown(){
		sgm.ClickFood();
	}

}
