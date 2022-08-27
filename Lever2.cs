using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever2 : MonoBehaviour
{
    public GameObject player;
    public GameObject lever;

    public GameObject ObstacleYPos;

    public int mouseclick = 0;

    private void OnMouseDown()
    {
        mouseclick = mouseclick + 1;
        if (mouseclick <= 1 && Lever.firstleverclicked == true)
        {
            lever.transform.localScale = new Vector3(0.7221537f, -0.6309671f, 1);
            //Destroy(gameObject);
            ObstacleYPos.transform.Translate(-3, 0, 0);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("LeverObjectUp").GetComponent<Lever>();

        ObstacleYPos = GameObject.FindGameObjectWithTag("Obstacle");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
