using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasMgr : MonoBehaviour {

    public Text hungerPointText, thirstPointText, messageText;
    private int maxHungerPoint, maxThirstPoint;
    

    public void Blip(string message, int seconds){
        StartCoroutine(quickieMessage(message, seconds));
    }

    IEnumerator quickieMessage(string message, int seconds){
        Debug.Log("enumerator called");
        ShowMessage(message);
        yield return new WaitForSecondsRealtime(seconds);
        HideMessage();
    }

    private void ShowMessage(string message){
        Debug.Log("showing message "+message);
        messageText.text = message;
        messageText.gameObject.SetActive(true);
    }

    private void HideMessage(){
        messageText.gameObject.SetActive(false);
    }

    public void SetMaxHungerPoint(int x){
        maxHungerPoint = x;
    }

    public void SetMaxThirstPoint(int x){
        maxThirstPoint = x;
    }

    public void SetHungerPointText(int currPoint){
        if (currPoint <= maxHungerPoint) {hungerPointText.text = string.Format("{0}/{1}", currPoint, maxHungerPoint);}
    }

    public void SetThirstPointText(int currPoint){
        if (currPoint <= maxThirstPoint) {thirstPointText.text = string.Format("{0}/{1}", currPoint, maxThirstPoint);}
    }

    void Start(){
        HideMessage();
    }
}
