using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionChange : MonoBehaviour
{
    public GameObject player;
    public GameObject[] GroundLayer;
    public SpriteRenderer Dimension;

    public static bool change = false;
    public GameObject platform;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            player.layer = LayerMask.NameToLayer("Background");
            GroundLayer = GameObject.FindGameObjectsWithTag("Ground");
            change = true;

            foreach (GameObject GroundObject in GroundLayer)
            {
                Dimension = GroundObject.GetComponent<SpriteRenderer>();
                Dimension.color = new Color(1f, 1f, 1f, .5f);
            }

            platform.active = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
