using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzz : MonoBehaviour
{
    public GameObject Box2;
    public GameObject Button2;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Box")
        {
            Destroy(gameObject);
            Button2.SetActive(true);
            Instantiate(Box2, new Vector3(64.1f, 7.17f, 0), Quaternion.Euler(0,0,180));
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Button2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
