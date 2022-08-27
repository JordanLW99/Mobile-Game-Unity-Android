using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour
{
    public float trans = 0.5f;
    public SpriteRenderer spriteOpacity;
    public GameObject changecheck;

    // Start is called before the first frame update
    void Start()
    {
        spriteOpacity = gameObject.GetComponent<SpriteRenderer>();
        GameObject.Find("DimensionTrigger").GetComponent<DimensionChange>();
        GameObject.Find("DimensionTriggerBack").GetComponent<DimensionChangeBack>();
        spriteOpacity.color = new Color(1f, 1f, 1f, .5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(DimensionChange.change == true)
        {
            spriteOpacity.color = new Color(1f, 1f, 1f, 1f);
        }
        if (DimensionChange.change == false)
        {
            spriteOpacity.color = new Color(1f, 1f, 1f, 0.5f);
        }
    }
}
