using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionChangeBack : MonoBehaviour
{
    public GameObject player;
    public GameObject[] GroundLayer1;
    public SpriteRenderer Dimension1;

    public static bool change = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            player.layer = LayerMask.NameToLayer("Default");
            GroundLayer1 = GameObject.FindGameObjectsWithTag("Ground");
            change = true;
            DimensionChange.change = false;

            foreach (GameObject GroundObject1 in GroundLayer1)
            {
                Dimension1 = GroundObject1.GetComponent<SpriteRenderer>();
                Dimension1.color = new Color(1f, 1f, 1f, 1f);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("DimensionTrigger").GetComponent<DimensionChange>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
