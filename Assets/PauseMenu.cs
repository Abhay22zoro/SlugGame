using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
   
    
      public GameObject pausePanel;
    void Update()
    { 
    }
  public void Resume(){
   pausePanel.SetActive(false);
   Time.timeScale = 1f;
  
   
   }
  public void Pause(){
    pausePanel.SetActive(true);
    Time.timeScale = 0;
   
   }
   public void QuitGame(){
    Debug.Log("Quitting game...");
    Application.Quit();
   }
}
