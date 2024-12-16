using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Spot_Light_ZAxis : MonoBehaviour
{
    public float movementSpeed = 12f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalMov = Input.GetAxisRaw("Horizontal");

        if (horizontalMov == 0)
        {
            rb.Sleep();
        }
        else
        {
            rb.WakeUp();
        }

        Vector3 movement = new Vector3(0, 0, horizontalMov) * movementSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }
}
