using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Material hit;
    public Material noHit;
    private bool _isHit = false;

    // Update is called once per frame
    //This script gets called and performs the functions from the Highlighter script.
    //Cube's color is purple, if the gun hits it. Cube's color is indigo, if the gun is not hitting it.
    void Update()
    {
        if (_isHit)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            Debug.DrawRay(transform.position, forward, Color.red);
            GetComponent<Renderer>().material = hit;
        }
        else
        {
            GetComponent<Renderer>().material = noHit;
        }
        _isHit = false;

    }

    public void BeenHit()
    {
        _isHit = true;
    }
}
