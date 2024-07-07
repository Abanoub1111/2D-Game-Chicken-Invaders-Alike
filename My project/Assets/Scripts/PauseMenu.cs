using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused;
    public GameObject pausepanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Pause"))
        {
            if(isPaused)
               ResumeGame();
            else
               PauseGame();
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        pausepanel.SetActive(true);
        isPaused = true;
    }
     
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pausepanel.SetActive(false);
        isPaused = false;
    }
}
