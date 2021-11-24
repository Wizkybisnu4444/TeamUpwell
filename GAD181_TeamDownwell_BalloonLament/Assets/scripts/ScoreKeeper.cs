using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour

{

    public int Score;
    public Text ScoreDisplay;
    public bool WhiteCloud = false;
    public bool ThunderCloud = false;
    public bool RedGhost = false;


    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplay.text = Score.ToString();
    }

    public void AddToScore()
    {
        Score += 100;
    }

}
