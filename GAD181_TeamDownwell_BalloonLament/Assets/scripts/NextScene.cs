using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    bool next = false;
    public GameObject text;
    public GameObject button;
    public Text buttontext;
    
    // Start is called before the first frame update
    void Start()
    {
        buttontext.text = ("continue in 7").ToString();
        text.SetActive(true);
        button.SetActive(false);
        next = false;
        StartCoroutine(Next());
    }

    // Update is called once per frame
    void Update()
    {
        if (next == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                LoadNextScene();
            }
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }  

    IEnumerator Next()
    {
        yield return new WaitForSeconds(1f);
        buttontext.text = ("continue in 6").ToString();
        yield return new WaitForSeconds(1f);
        buttontext.text = ("continue in 5").ToString();
        yield return new WaitForSeconds(1f);
        buttontext.text = ("continue in 4").ToString();
        yield return new WaitForSeconds(1f);
        buttontext.text = ("continue in 3").ToString();
        yield return new WaitForSeconds(1f);
        buttontext.text = ("continue in 2").ToString();
        yield return new WaitForSeconds(1f);
        buttontext.text = ("continue in 1").ToString();
        yield return new WaitForSeconds(1f);
        buttontext.text = ("continue in 0").ToString();
        yield return new WaitForSeconds(0.5f);
        buttontext.text = ("continue to game").ToString();
        button.SetActive(true);
        next = true;
    }
}
