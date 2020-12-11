using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{

    public Transform movableObject;

    public float moveSpeed = 10f;
    public float turnSpeed = 200f;
    public float scale = 1f;

    public bool moveOnXZPlane = true;
    
    

    void Update()
    {
        //Turn object
        float turnLeft = Input.GetKey(KeyCode.Z) ? -1.0f : 0.0f;
        float turnRight = Input.GetKey(KeyCode.X) ? 1.0f : 0.0f;

        //Move forward and backward
        float forward = Input.GetKey(KeyCode.W) ? 1.0f : 0.0f;
        float backward = Input.GetKey(KeyCode.S) ? 1.0f : 0.0f;

        //Move object left and right
        float left = Input.GetKey(KeyCode.A) ? 1.0f : 0.0f;
        float right = Input.GetKey(KeyCode.D) ? 1.0f : 0.0f;

        //Move object up or down
        float up = Input.GetKey(KeyCode.E) ? 1.0f : 0.0f;
        float down = Input.GetKey(KeyCode.Q) ? 1.0f : 0.0f;

        transform.RotateAround(movableObject.position, Vector3.up, turnSpeed * turnLeft * Time.deltaTime);
        transform.RotateAround(movableObject.position, Vector3.up, turnSpeed * turnRight * Time.deltaTime);

        transform.Translate(movableObject.up * moveSpeed * up * Time.deltaTime, Space.World);
        transform.Translate(-movableObject.up * moveSpeed * down * Time.deltaTime, Space.World);

        if (moveOnXZPlane)
        {
            transform.Translate(VectorYToZero(movableObject.forward) * moveSpeed * forward * Time.deltaTime, Space.World);
            transform.Translate(VectorYToZero(-movableObject.forward) * moveSpeed * backward * Time.deltaTime, Space.World);

            transform.Translate(VectorYToZero(movableObject.right) * moveSpeed * right * Time.deltaTime, Space.World);
            transform.Translate(VectorYToZero(-movableObject.right) * moveSpeed * left * Time.deltaTime, Space.World);
        }
        else
        {
            transform.Translate(movableObject.forward * moveSpeed * forward * Time.deltaTime, Space.World);
            transform.Translate(-movableObject.forward * moveSpeed * backward * Time.deltaTime, Space.World);

            transform.Translate(movableObject.right * moveSpeed * right * Time.deltaTime, Space.World);
            transform.Translate(-movableObject.right * moveSpeed * left * Time.deltaTime, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.PageUp))

        {
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }

        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }


        Vector3 VectorYToZero(Vector3 vector)
        {
            return new Vector3(vector.x, 0.0f, vector.z);
        }
    }
}
