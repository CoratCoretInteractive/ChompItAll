using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGameManager : MonoBehaviour {
	public CanvasMgr canvas;
	public PlayerScript ps;

	// Use this for initialization
	void Awake () {
		initCanvas();
		initFood();
		initDrink();
	}

	void initCanvas(){
		canvas.SetMaxHungerPoint(ps.maxHungerPoint);
		canvas.SetMaxThirstPoint(ps.maxThirstPoint);
		canvas.SetHungerPointText(ps.currHungerPoint);
		canvas.SetThirstPointText(ps.currThirstPoint);
	}

	void updateCanvas(){
		canvas.SetHungerPointText(ps.currHungerPoint);
		canvas.SetThirstPointText(ps.currThirstPoint);
	}
	
	void initFood(){

	}

	void initDrink(){

	}

	void Update () {

	}

	public void ClickFood() {
		Debug.Log("food clicked");
		var successEat = ps.TryEat();
		if (!successEat) {
			canvas.Blip("You are full!!", 3);
		} else {
			updateCanvas();
		}
	}

	public void ClickWater(){
		Debug.Log("drink clicked");
		var successDrink = ps.TryDrink();
		if (!successDrink) {
			canvas.Blip("You are empty!!", 3);
		} else {
			updateCanvas();
		}
	}

}
