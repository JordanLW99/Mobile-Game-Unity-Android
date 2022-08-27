using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintPopUp : MonoBehaviour
{

    public GameObject PopUp;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            PopUp.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            PopUp.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        PopUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
