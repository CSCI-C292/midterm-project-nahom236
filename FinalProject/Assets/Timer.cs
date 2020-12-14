using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject display;
    public int secondsLeft = 10;
    public bool takingAway = false;

    void Start() {
        display.GetComponent<Text>().text = ":" + secondsLeft;
    }

    void Update() {
        if (takingAway == false && secondsLeft > 0) {
            StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake() {

        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10) {
            display.GetComponent<Text>().text = ":0" + secondsLeft;
        }
        else{
            display.GetComponent<Text>().text = ":" + secondsLeft;
        }
        takingAway = false;

    }

    public bool timeExpired() {
        if (secondsLeft == 0) {
            return true;
        }
        else {
            return false;
        }
    }
}
