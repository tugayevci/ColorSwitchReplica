using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByDrag : MonoBehaviour
{
    //public float speed = 100f;   

    public Transform rotateTransform;
    public GameObject player;
    public GameObject circleOrSquare;


    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButton(0))
        //{
        //    Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //    Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //    transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
        //}

        //if (Input.GetMouseButton(0))
        //{
        //    float rotationX = Input.GetAxis("Mouse X") * 200f * Mathf.Deg2Rad;
        //    transform.Rotate(Vector3.forward, rotationX);
        //}


        


    }

    private float baseAngle = 0.0f;

    void OnMouseDown()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(circleOrSquare.transform.position);
        pos = Input.mousePosition - pos;
        baseAngle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
        baseAngle -= Mathf.Atan2(circleOrSquare.transform.right.y, circleOrSquare.transform.right.x) * Mathf.Rad2Deg;
    }

    void OnMouseDrag()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(circleOrSquare.transform.position);
        pos = Input.mousePosition - pos;
        float ang = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle;
        circleOrSquare.transform.rotation = Quaternion.AngleAxis(ang, Vector3.forward);
    }


}
