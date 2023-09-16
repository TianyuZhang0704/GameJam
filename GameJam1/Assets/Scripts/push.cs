using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{

    public float forceMag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidBody = hit.collider.attachedRigidbody;

        if (rigidBody != null)
        {
            Vector3 forceDir = hit.gameObject.transform.position - transform.position;
            //forceDir.y = 0;
            forceDir.Normalize();
            rigidBody.AddForceAtPosition(forceDir * forceMag, transform.position, ForceMode.Force);
            //GameObject hitObj = GameObject.Find(hit.gameObject.name);
            //hitObj.transform.position = new Vector3(hitObj.transform.position.x, 0, hitObj.transform.position.z);
        }
    }
}
