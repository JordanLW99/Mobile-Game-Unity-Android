using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2Puzz : MonoBehaviour
{
    public GameObject BouncePlatform;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            Destroy(gameObject);
            BouncePlatform.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        BouncePlatform.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
