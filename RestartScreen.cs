using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class RestartScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Restart"))
        {
            Movement.crystalscore = 0;
            SceneManager.LoadScene(2);
        }

        if (CrossPlatformInputManager.GetButtonDown("BackToMenu"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
