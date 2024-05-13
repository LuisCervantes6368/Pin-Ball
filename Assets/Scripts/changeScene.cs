using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private GameObject Ball;
    private int contador = 0;
    private void Start()
    {
        Ball = GameObject.FindWithTag("Ball");
    }
   
        void OnGUI()
    {
        
        if (Ball != null && Ball.transform.position.z <= -6.9f)
        {
            if (GUI.Button(new Rect(5, 5, 100, 20), "Restart"))
            {
                contador++;
                if (contador >= 3)
                {
                    SceneManager.LoadScene("Assets/Scenes/scene2.unity", LoadSceneMode.Single);
                }
                else
                {
                    SceneManager.LoadScene("Assets/Scenes/scene1.unity", LoadSceneMode.Single);
                }
            }
        }
    }
}
