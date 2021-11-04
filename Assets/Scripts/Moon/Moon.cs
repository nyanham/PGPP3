using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    Vector3 position = new Vector3(0,2,4);
    Vector3 rotation = new Vector3(-30,0,40);
    Vector3 scale = new Vector3(0.2f,0.2f,0.2f);
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
