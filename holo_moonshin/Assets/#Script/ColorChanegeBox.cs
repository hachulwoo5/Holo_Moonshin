using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanegeBox : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer squareColor;
    void Start()
    {
        squareColor = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag=="Sphere")
        {
            squareColor.material.color = Color.red;
        }
        if (other.transform.tag == "Sphere2")
        {
            squareColor.material.color = Color.blue;
        }
    }
}
