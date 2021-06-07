using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
  public string nameValue;
  
  public void StartNew()
  {
     SceneManager.LoadScene(1);
  }
  public void Exit()
  {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
     #endif
  }

    public void OnChange()
    {
        nameValue = GetComponent<InputField>().text;
        if (GameManager.Instance == null)
        {
            GameManager.Instance.playerName = nameValue;
        } 
        else
        {
            GameManager.Instance.newPlayerName = nameValue;
        }
    }
}
