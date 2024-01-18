using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeWalk : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float heading = 0f;
    [SerializeField] float sens = 5f;

    void Update()
    {
        transform.position += Input.GetAxisRaw("Vertical") * transform.forward * speed * Time.deltaTime;
        heading += Input.GetAxisRaw("Horizontal") * sens;
        transform.rotation = Quaternion.Euler(new Vector3(0f, heading, 0f));
    }
}
