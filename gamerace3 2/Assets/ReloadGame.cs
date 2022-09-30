using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour
{
    public float timer;
    public float maxTime = 3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))  
        {
            timer += Time.deltaTime;
        
            if (timer > maxTime)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else
        {
            timer = 0;
        }
    }
}
