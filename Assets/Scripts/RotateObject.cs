using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Vector3 rotation_direction;
    [SerializeField] float rotationLimit;
    Vector3 startingLocation; 

    // Start is called before the first frame update
    void Start()
    {
        startingLocation = gameObject.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.rotation.z < 0)
        {
            FlipRotationDirection();
        }

        gameObject.transform.Rotate(rotation_direction * moveSpeed);
    }

    void FlipRotationDirection()
    {
        rotation_direction = -rotation_direction;
    }
}