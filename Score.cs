using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public bool drawGUI;
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        drawGUI = true;
    }

    void OnGUI()
    {
        if (drawGUI == true)
        {
            //GUI.Box(new Rect(Screen.width * 0.5f - 51, 100, 0, 22), "Ammo: " + counter);
            GUIStyle textStyle = new GUIStyle();
            textStyle.fontSize = 30;
            textStyle.normal.textColor = Color.white;

            GUI.Label(new Rect(-185.4f, 180.47f, 118.4001f, 46.9481f), "SCORE" + counter.ToString(), textStyle);
        }
    }
}
