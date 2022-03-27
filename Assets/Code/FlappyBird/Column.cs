using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public GameObject ColumnDown;
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
        if (posX <= -5.5)
        {
            float posY = Random.Range(3.0f, 5.0f);
            transform.position = new Vector3(7f, posY, transform.position.z);
        }
    }
}
