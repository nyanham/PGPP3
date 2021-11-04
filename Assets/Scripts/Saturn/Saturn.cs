using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saturn : MonoBehaviour
{
    Vector3 position = new Vector3(1,0,5);
    Vector3 rotation = new Vector3(-20,0,10);
    Vector3 scale = new Vector3(2,2,2);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = position;
        transform.Rotate (rotation);
        transform.localScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
