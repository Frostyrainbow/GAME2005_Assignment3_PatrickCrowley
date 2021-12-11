using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<BasicObjectPhysics> spherePrefabs;
    public float frameDelay;
    public float Offset;
    public int selectedBall;
    public bool noFire = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!noFire)
        {
            //spawn ball when mouse 1 is pressed
            if ((Input.GetAxis("Fire1") > 0) && (Time.frameCount % frameDelay == 0))
            {
                var bullet = Instantiate(spherePrefabs[selectedBall], Camera.main.transform.position + Camera.main.transform.forward * Offset, Quaternion.identity);
                bullet.GetComponent<BasicObjectPhysics>().velocity = Camera.main.transform.forward * 10;
            }
        }
        
    }
}
