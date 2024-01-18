using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    [SerializeField] float heading = 0f;

    void Update()
    {
        transform.position += Input.GetAxisRaw("Vertical") * transform.forward * Time.deltaTime;
        heading += Input.GetAxisRaw("Horizontal")*0.2f;
        transform.rotation = Quaternion.Euler(new Vector3(0f, heading, 0f));
    }
}