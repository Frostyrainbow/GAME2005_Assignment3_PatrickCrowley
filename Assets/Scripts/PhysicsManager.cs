using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsManager : MonoBehaviour
{
    public Vector3 gravity = new Vector3(0, -9.81f, 0);
    public List<BasicObjectPhysics> BasicObjectsList = new List<BasicObjectPhysics>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var obj in BasicObjectsList)
        {
            obj.velocity += gravity * obj.gravityScale * Time.deltaTime;

        }
    }
}
