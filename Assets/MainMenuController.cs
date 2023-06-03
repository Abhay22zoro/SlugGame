using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
 public CanvasGroup OptionPanel;

 public void PlayGame()
 {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 }

 public void QuitGame()
 {
    Application.Quit();
 }

}
