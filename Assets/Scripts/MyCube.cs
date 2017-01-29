using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class MyCube : MonoBehaviour {

    List<Vector3> currentCollisions = new List<Vector3>();
    bool hold = false;

    public SteamVR_TrackedObject leftController;
    public SteamVR_TrackedObject rightController;

    VRTK_InteractableObject myGrab;

    public List<Vector3> getCollisions ()
    {
        return currentCollisions;
    }

    // Use this for initialization
    void Start () {
        myGrab = gameObject.GetComponent<VRTK_InteractableObject>();
	}
	
	// Update is called once per frame
	void Update () {
        // Debug.Log(currentCollisions.Count);
       /* SteamVR_Controller.Device deviceLeft = SteamVR_Controller.Input((int)leftController.index);
        SteamVR_Controller.Device deviceRight = SteamVR_Controller.Input((int)rightController.index);
        if (deviceLeft.GetTouchDown(SteamVR_Controller.ButtonMask.Grip) || deviceRight.GetTouchDown(SteamVR_Controller.ButtonMask.Grip))
        {
            hold = true;
        } else
        {
            hold = false;
        }*/
        //Debug.Log(myGrab.IsGrabbed(this.gameObject));
        if (myGrab.hold)
        {
            Debug.Log("is grabbing");
            gameObject.GetComponent<Rigidbody>().Sleep();
        }
       else
         //   Debug.Log("not grabbing");
        gameObject.GetComponent<Rigidbody>().WakeUp();
    }

    void grab()
    {
        hold = true;
        gameObject.GetComponent<Rigidbody>().Sleep();
    }
 

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Hitting");
        if (!hold)
        {
            Debug.Log("Hit witout hold");
            //    transform.position = col.transform.position;
            if (col.gameObject.tag == "cube")
            {
                float x;
                float y;
                float z;

                Debug.Log(transform.position.x - col.gameObject.transform.position.x);
                Debug.Log(transform.position.y - col.gameObject.transform.position.y);
                Debug.Log(transform.position.z - col.gameObject.transform.position.z);
                Debug.Log("Col position" + col.gameObject.transform.position);

                if (transform.position.x - col.gameObject.transform.position.x > 0.5)
                {
                    x = col.gameObject.transform.position.x + 1;
                }
                else if (transform.position.x - col.gameObject.transform.position.x < 0.5 &&
                          transform.position.x - col.gameObject.transform.position.x > -0.5)
                {
                    x = col.gameObject.transform.position.x;
                }
                else
                {
                    x = col.gameObject.transform.position.x - 1;
                }

                if (transform.position.y - col.gameObject.transform.position.y > 0.5)
                {
                    y = col.gameObject.transform.position.y + 1;
                }
                else if (transform.position.y - col.gameObject.transform.position.y < 0.5 &&
                          transform.position.y - col.gameObject.transform.position.y > -0.5)
                {
                    y = col.gameObject.transform.position.y;
                }
                else
                {
                    y = col.gameObject.transform.position.y - 1;
                }

                if (transform.position.z - col.gameObject.transform.position.z > 0.5)
                {
                    z = col.gameObject.transform.position.z + 1;
                }
                else if (transform.position.z - col.gameObject.transform.position.z < 0.5 &&
                          transform.position.z - col.gameObject.transform.position.z > -0.5)
                {
                    z = col.gameObject.transform.position.z;
                }
                else
                {
                    z = col.gameObject.transform.position.z - 1;
                }

                Vector3 newVector = new Vector3(x, y, z);

                Debug.Log(newVector);

                gameObject.transform.position = newVector;
                gameObject.transform.rotation = col.gameObject.transform.rotation;
              //  gameObject.GetComponent<Rigidbody>().Sleep();
               // hold = false;
            }
        }


        /*/ Add the GameObject collided with to the list.
        
        currentCollisions.Add(col.gameObject);
        GameObject best = col.gameObject;
        float clostest = Vector3.Distance(transform.position, col.transform.position);

        // Print the entire list to the console.
        foreach (GameObject gObject in currentCollisions)
        {
            float distance = Vector3.Distance(transform.position, gObject.transform.position);
            Debug.Log(gObject.transform.position.x + " " + gObject.transform.position.y + " " + gObject.transform.position.z);
            if (distance < clostest)
            {
                best = gObject.gameObject;
                clostest = distance;
            }
        }
        Debug.Log(currentCollisions.Count);
        //Debug.Log(best.transform.position.x + " " + best.transform.position.y + " " + best.transform.position.z);
        //transform.position = best.transform.position;*/
    }

}
