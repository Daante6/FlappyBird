using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER_FallZone : MonoBehaviour
{
    public GameObject player;
    public float fallTransformY = 0;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, fallTransformY, transform.position.z);
    }
}
