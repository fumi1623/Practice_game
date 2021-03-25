using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Transform tf = GetComponent<Transform>();

    }

    
    void Update()
    {
        //transform.position += new Vector3(0.1f, 0, 0);
        //transform.Translate(new Vector3(0.1f, 0, 0));
        transform.Rotate(new Vector3(0.1f, 0, 0));
    }
}
