using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicObjectPhysics : MonoBehaviour
{

    public float mass = 1.0f;
    public Vector3 velocity = Vector3.zero;

    public PhysicsManager physicManager;
    public float gravityScale = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World from " + gameObject.name + "!");
        physicManager = FindObjectOfType<PhysicsManager>(); // return the first found component in the scene which has the type
        physicManager.BasicObjectsList.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + velocity * Time.deltaTime;

        // Reverse Gravity - Delete Later
        if (transform.position.y <= 0.5)
        {
            velocity.y = (physicManager.gravity.y * -1);
        }
        if (transform.position.y >= 2)
        {
            velocity.y = physicManager.gravity.y;
        }
    }
}
