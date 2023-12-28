using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topdown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("vertical");

        transform.position += new Vector3(x, y);

    }
}
