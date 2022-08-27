using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityNormal : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rigidBody;

    public GameObject nextTrigger;

    void OnCollisionEnter2D(Collision2D collision)
    {
        player.transform.Rotate(180, 0, 0);
        rigidBody.gravityScale = 0.5f;
        nextTrigger.active = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        nextTrigger.active = false;
        rigidBody = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
