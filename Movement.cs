using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int healt = 5;

    public int level = 1;
     
    public float speed = 1.5f;
    Vector3 newPosition = new Vector3(0, 0.5f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.y += speed * Time.deltaTime;
        newPosition.x += speed * Time.deltaTime;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
