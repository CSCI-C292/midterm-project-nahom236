using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _gameOverP1;
    [SerializeField] GameObject _gameOverP2;

    public HealthSystem p2Health;
    public HealthSystem p1Health;

    void Start()
    {
        GameObject go = GameObject.Find("HealthBar");
        p2Health =  go.GetComponent<HealthSystem>();

        GameObject p1 = GameObject.Find("HealthBarP1");
        p1Health = p1.GetComponent<HealthSystem>();
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
    }
}
