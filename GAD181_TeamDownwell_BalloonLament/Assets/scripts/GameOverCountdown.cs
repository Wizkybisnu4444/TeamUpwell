using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverCountdown : MonoBehaviour
{
    public float timeLeft;
    public Text countDisplay;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        timeLeft--;
        if (timeLeft < 0)
        {
            GameOver();
        }



    }

    private void GameOver()
    {

    }

}
