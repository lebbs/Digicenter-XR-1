using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VarjoExample;

public class CalculateAngle : MonoBehaviour
{

    public Transform target;
    Controller controller;
    Vector3 originalPosition;
    private bool triggerDown;

    // Start is called before the first frame update
        //SET POSITION OF AN OBJECT  
    void SetOriginalPosition()
    {
        originalPosition = new Vector3(gameObject.transform.position.y, gameObject.transform.position.x);

    }

    void CalculateDistance()
    {
        float dist = Vector3.Distance(originalPosition, transform.position);
        Debug.Log(dist);
    }

    void Start()
    {
       // controller = GetComponent<Controller>();
       // originalPosition = new Vector3(gameObject.transform.position.y, gameObject.transform.position.x);
    }

    void Update()
    {
        //if (controller.primaryButton)
        //{
        //    if (!triggerDown)
        //    {
        //        SetOriginalPosition();
        //        //CalculateDistance();
        //        Debug.Log("nappi toimii");
        //        Debug.Log(originalPosition);
        //    }
        //}
        //CALCULATES ANGLE BETWEEN POINT A AND Ba



        Vector3 targetDir = target.position - transform.position;
        float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;
        //float angle = Vector3.Angle(targetDir, transform.forward);
        Debug.DrawRay(transform.position, targetDir, Color.green);
        Debug.Log(angle);

        //Quaternion angleAxis = Quaternion.AngleAxis(angle, Vector3.forward);
        //transform.rotation = Quaternion.Slerp(transform.rotation, angleAxis, Time.deltaTime * 50);

        if(angle < 5.0f)
        {
            print("close");
        }
    }
}
