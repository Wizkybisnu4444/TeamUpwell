using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
 
    public static bool GameIsPaused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            PauseGame();
        }
       

    }

    void PauseGame()
    {
        if (GameIsPaused == false)
        {
            Time.timeScale = 0;
            GameIsPaused = true;
        }
        else if(GameIsPaused == true)
        {
            ResumeGame();
            GameIsPaused=false;
        }
       
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
    }


}
