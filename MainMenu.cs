using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Play"))
        {
            SceneManager.LoadScene(2);
            Movement.crystalscore = 0;
            CrossPlatformInputManager.SetButtonUp("Play");
        }
    }
}
