using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public Vector3 playerPosition;

    void Start()
    {
        playerPosition = transform.position + new Vector3 (0,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.1f, 0, 0);
    }
}
