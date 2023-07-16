using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscToMenu : MonoBehaviour
{
   
    void Update()
    {
     

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Game")
        {
            Debug.Log("The Current Scene is the game");
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("Menu");
                Debug.Log("changed scene");
            }
        }
        else if (sceneName != "Game")
        {
            Debug.Log("Cannot Change scene becasue the scene is already open");
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }

        
        
    }
}
