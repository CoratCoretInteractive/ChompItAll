using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public int currHungerPoint, currThirstPoint, maxHungerPoint, maxThirstPoint;

	// Use this for initialization
	void Awake () {

	}
	
	public bool TryEat() {
		int addHunger = 0, addThirst = 0;
		if(currHungerPoint+addHunger <= maxHungerPoint && currThirstPoint+addThirst <= maxThirstPoint) {
			currHungerPoint += 10;
			currThirstPoint += 10;
			return true;
		}
		return false;
	}

	public bool TryDrink() {
		int decAmount = 10;
		if( currThirstPoint-decAmount >= 0) {
			currThirstPoint -= decAmount;
			return true;
		}
		return false;
	}

}
