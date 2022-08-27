using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text display_Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        display_Text.text = "Score: " + Movement.crystalscore.ToString();

        if (CrossPlatformInputManager.GetButtonDown("B2M"))
        {
            SceneManager.LoadScene(0);
            CrossPlatformInputManager.SetButtonUp("B2M");
        }
    }
}
