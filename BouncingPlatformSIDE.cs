using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPlatformSIDE : MonoBehaviour
{
    public Rigidbody2D player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.AddForce(transform.right * -400);
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
