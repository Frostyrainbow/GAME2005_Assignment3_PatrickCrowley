using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BasicObjectPhysics : MonoBehaviour
{

    public float mass = 1.0f;
    public Vector3 velocity = Vector3.zero;
    public string ballName;
    public PhysicsManager physicManager;
    public float gravityScale = 1.0f;
    [Range(0, 1)]
    public float bounciness = 0.6f;
    [Range(0, 1)]
    public float frictioniness = 0.5f;
    public PhysiczColliderBase shape = null;

    private float time = 0.0f;
    // should this object be able to be controlled by collision response physics?
    public bool lockPosition = false;


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
        time += Time.deltaTime;
        float small = 0.1f;
        //check every 3 seconds if the objects velocity is smaller than 0.1f
        //to stop the object from infinitely moving in small amounts
        if (time >= 3.0f && (velocity.x <= small || velocity.x >= -small))
        {
            velocity.x = 0.0f;
            time = 0.0f;
        }
        if (time >= 3.0f && (velocity.y <= small || velocity.y >= -small))
        {
            velocity.y = 0.0f;
            time = 0.0f;
        }
        if (time >= 3.0f && (velocity.z <= small || velocity.z >= -small))
        {
            velocity.z = 0.0f;
            time = 0.0f;
        }

    }
}
