using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField]
    string sceneName = "";

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            if(!string.IsNullOrEmpty(sceneName))
                SceneManager.LoadScene(sceneName);

        if(Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();


    }
}
