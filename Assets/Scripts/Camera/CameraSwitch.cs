using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;

    Vector3 position = new Vector3(0,0,20);
    Vector3 rotation = new Vector3(0,180,0);
    Vector3 scale = new Vector3(1,1,1);
    
    // Start is called before the first frame update
    void Start()
    {
        cam2.transform.position = position;
        cam2.transform.Rotate (rotation);
        cam2.transform.localScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("key1"))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }

        if (Input.GetButtonDown("key2"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
