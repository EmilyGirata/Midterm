using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{
    private RaycastHit vision;
    public float rayLength;
    private bool isGrabbed;
    private Rigidbody grabbedObject;

    // Start is called before the first frame update
    void Start()
    {
        rayLength = 4.0f;
        isGrabbed = false;
    }

    // Update is called once per frame
    //Fps camera will have a colored ray displayed on the scene view showing which direction the gun's shooting.
    //It will also pick up and drop off objects in sight of the colored ray by right clicking.
    void Update()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rayLength, Color.red, 0.5f);

        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out vision, rayLength))
        {
            if (vision.collider.tag == "Interactive")
            {
                Debug.Log(vision.collider.name);
                if (Input.GetMouseButtonDown(1) && !isGrabbed)
                {
                    grabbedObject = vision.rigidbody;
                    grabbedObject.isKinematic = true;
                    grabbedObject.transform.SetParent(gameObject.transform);
                    isGrabbed = true;
                }

                else if (isGrabbed && Input.GetMouseButtonDown(1))
                {
                    grabbedObject.transform.parent = null;
                    grabbedObject.isKinematic = false;
                    isGrabbed = false;
                }
            }
        }
    }
}
