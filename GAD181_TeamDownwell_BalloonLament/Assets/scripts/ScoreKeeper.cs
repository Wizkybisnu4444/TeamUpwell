using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour

{
    //public int Score;
    //public Text ScoreDisplay;
    //public bool WhiteCloud = false;
    //public bool ThunderCloud = false;
    //public bool RedGhost = false;
    public int score = 0;
    public bool cloud = false;
    public bool ghost = false;
    public bool thunder = false;
    public bool ccombo = false;
    public bool gcombo = false;
    public bool tcombo = false;
    public bool comboend = false;
    public bool reload = false;
    public Text scoretext;


    // Start is called before the first frame update
    void Start()
    {
        //Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //ScoreDisplay.text = Score.ToString();
        if (cloud == true)
        {
            cloud = false;
            if (ccombo == true)
            {
                score += 20;
                if (score > 0 && score < 100)
                {
                    scoretext.text = "0000" + score.ToString();
                }
                else if (score > 99 && score < 1000)
                {
                    scoretext.text = "000" + score.ToString();
                }
                else if (score > 999 && score < 10000)
                {
                    scoretext.text = "00" + score.ToString();
                }
                else if (score > 9999 && score < 100000)
                {
                    scoretext.text = "0" + score.ToString();
                }
                else
                {
                    scoretext.text = score.ToString();
                }
            }
            else
            {
                score += 10;
                if (score > 0 && score < 100)
                {
                    scoretext.text = "0000" + score.ToString();
                }
                else if (score > 99 && score < 1000)
                {
                    scoretext.text = "000" + score.ToString();
                }
                else if (score > 999 && score < 10000)
                {
                    scoretext.text = "00" + score.ToString();
                }
                else if (score > 9999 && score < 100000)
                {
                    scoretext.text = "0" + score.ToString();
                }
                else
                {
                    scoretext.text = score.ToString();
                }
            }
            StartCoroutine(CloudCombo());
        }
        if (ghost == true)
        {
            ghost = false;
            if (gcombo == true)
            {
                score += 40;
                if (score > 0 && score < 100)
                {
                    scoretext.text = "0000" + score.ToString();
                }
                else if (score > 99 && score < 1000)
                {
                    scoretext.text = "000" + score.ToString();
                }
                else if (score > 999 && score < 10000)
                {
                    scoretext.text = "00" + score.ToString();
                }
                else if (score > 9999 && score < 100000)
                {
                    scoretext.text = "0" + score.ToString();
                }
                else
                {
                    scoretext.text = score.ToString();
                }
            }
            else
            {
                score += 20;
                if (score > 0 && score < 100)
                {
                    scoretext.text = "0000" + score.ToString();
                }
                else if (score > 99 && score < 1000)
                {
                    scoretext.text = "000" + score.ToString();
                }
                else if (score > 999 && score < 10000)
                {
                    scoretext.text = "00" + score.ToString();
                }
                else if (score > 9999 && score < 100000)
                {
                    scoretext.text = "0" + score.ToString();
                }
                else
                {
                    scoretext.text = score.ToString();
                }
            }
            StartCoroutine(GhostCombo());
        }
        if (thunder == true)
        {
            thunder = false;
            if (tcombo == true)
            {
                score += 60;
                if (score > 0 && score < 100)
                {
                    scoretext.text = "0000" + score.ToString();
                }
                else if (score > 99 && score < 1000)
                {
                    scoretext.text = "000" + score.ToString();
                }
                else if (score > 999 && score < 10000)
                {
                    scoretext.text = "00" + score.ToString();
                }
                else if (score > 9999 && score < 100000)
                {
                    scoretext.text = "0" + score.ToString();
                }
                else
                {
                    scoretext.text = score.ToString();
                }
            }
            else
            {
                score += 30;
                if (score > 0 && score < 100)
                {
                    scoretext.text = "0000" + score.ToString();
                }
                else if (score > 99 && score < 1000)
                {
                    scoretext.text = "000" + score.ToString();
                }
                else if (score > 999 && score < 10000)
                {
                    scoretext.text = "00" + score.ToString();
                }
                else if (score > 9999 && score < 100000)
                {
                    scoretext.text = "0" + score.ToString();
                }
                else
                {
                    scoretext.text = score.ToString();
                }
            }
            StartCoroutine(ThunderCombo());
        }
        if (comboend == true)
        {
            comboend = false;
            ccombo = false;
            gcombo = false;
            tcombo = false;
        }
    }

    //public void AddToScore()
    //{
    //    Score += 100;
    //}
    IEnumerator CloudCombo()
    {
        ccombo = true;
        if (reload == true)
        {
            yield return new WaitForSeconds(2f);
            StartCoroutine(CloudCombo());
        }
        else
        {
            yield return new WaitForSeconds(2f);
            ccombo = false;
        }
    }
    IEnumerator GhostCombo()
    {
        gcombo = true;
        if (reload == true)
        {
            yield return new WaitForSeconds(2f);
            StartCoroutine(GhostCombo());
        }
        else
        {
            yield return new WaitForSeconds(4f);
            gcombo = false;
        }
    }
    IEnumerator ThunderCombo()
    {
        tcombo = true;
        if (reload == true)
        {
            yield return new WaitForSeconds(2f);
            StartCoroutine(ThunderCombo());
        }
        else
        {
            yield return new WaitForSeconds(6f);
            tcombo = false;
        }
    }
}
