using System.Collections;
using UnityEngine;

public class Draik_Controller : MonoBehaviour {

    private Rigidbody2D myRigidBody;
    public float draikJumpforce = 500f;
    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            myRigidBody.AddForce(transform.up * draikJumpforce);
        }
    }
}
