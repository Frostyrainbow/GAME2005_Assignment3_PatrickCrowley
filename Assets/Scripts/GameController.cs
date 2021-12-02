using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<GameObject> spherePrefabs;
    public float frameDelay;
    public float Offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("Fire1") > 0) && (Time.frameCount % frameDelay == 0))
        {
            var randomSphereIndex = Random.Range(0, spherePrefabs.Count);
            var bullet = Instantiate(spherePrefabs[randomSphereIndex], Camera.main.transform.position + Camera.main.transform.forward * Offset, Quaternion.identity);
            bullet.GetComponent<SphereBehaviour>().direction = Camera.main.transform.forward;
        }
    }
}
