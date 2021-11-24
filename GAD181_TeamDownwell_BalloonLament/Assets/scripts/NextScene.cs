using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextScene : MonoBehaviour
{
    bool next = false;
    public GameObject text;
    public GameObject button;
    
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        button.SetActive(false);
        next = true;
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
        yield return new WaitForSeconds(7.5f);
        text.SetActive(true);
        button.SetActive(true);
        next = true;
    }
}
