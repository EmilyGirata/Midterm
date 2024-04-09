using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    // Update is called once per frame
    //The raycast assigns the gun to change the cube's color based on if its hiting the cube or not.
    void Update()
    {
        RaycastHit hit;

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);

        if (Physics.Raycast(transform.position, forward, out hit))
            hit.collider.gameObject.GetComponent<CubeScript>().BeenHit();
        Debug.Log("I've hit something!");
    }
}
