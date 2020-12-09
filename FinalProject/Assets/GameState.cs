using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _gameOverP1;
    [SerializeField] GameObject _gameOverP2;
    [SerializeField] GameObject _tie;
    public Timer _time;
    public HealthSystem p2Health;
    public HealthSystem p1Health;
    public bool takingAway = false;
    public int secondsLeft = 5;

    void Start()
    {
        GameObject go = GameObject.Find("HealthBar");
        p2Health =  go.GetComponent<HealthSystem>();

        GameObject p1 = GameObject.Find("HealthBarP1");
        p1Health = p1.GetComponent<HealthSystem>();

        GameObject time = GameObject.Find("TimeCountdown");
        _time = time.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(p2Health.isDone() == true) {
            _gameOverP1.SetActive(true);

        }
        if(p1Health.isDone() == true) {
            _gameOverP2.SetActive(true);
        }
        if(p1Health.currentHealth() == p2Health.currentHealth() && _time.timeExpired() == true){
            _tie.SetActive(true);
        }    

    }

}
