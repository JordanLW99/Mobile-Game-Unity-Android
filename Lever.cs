using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public BoxCollider2D BOXCOL2D;

    public GameObject player;
    public GameObject lever;

    public GameObject ObstacleYPos;

    public int mouseclick = 0;

    public static bool firstleverclicked = false;

    private void OnMouseDown()
    {
        mouseclick = mouseclick + 1;
        if (mouseclick <= 1)
        {
            lever.transform.localScale = new Vector3(-0.7221537f, -0.6309671f, 1);
            //Destroy(gameObject);
            ObstacleYPos.transform.Translate(3, 0, 0);
            Destroy(BOXCOL2D);
        }
        firstleverclicked = true;
        //Debug.Log("MOUSECLICK");
    }
    // Start is called before the first frame update
    void Start()
    {
        ObstacleYPos = GameObject.FindGameObjectWithTag("Obstacle");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
