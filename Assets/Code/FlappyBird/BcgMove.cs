using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BcgMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posX = transform.position.x;
        transform.position = new Vector3(posX - speed * Time.deltaTime, transform.position.y, transform.position.z);
        if(posX <= -9.5)
        {
            transform.position = new Vector3( 9.5f, transform.position.y, transform.position.z);
        }
    }
}
