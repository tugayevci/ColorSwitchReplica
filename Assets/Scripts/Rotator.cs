using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    

    float randomSpeed;
    private void Start()
    {
        randomSpeed = Random.Range(50, 100);
        int negativeOrPositive = Random.Range(0, 2);

        if (negativeOrPositive==0)
        {
            randomSpeed *= -1;
        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, randomSpeed * Time.deltaTime);        
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -1 * (Camera.main.transform.position.z));
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }


}
