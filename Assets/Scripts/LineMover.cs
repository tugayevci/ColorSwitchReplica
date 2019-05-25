using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMover : MonoBehaviour
{




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * Time.deltaTime);

        if (transform.position.x > 11.25 && transform.tag =="Cyan")
        {
            transform.position = new Vector3(-8.75f, transform.position.y, 0);
            //Debug.Log(transform.position.x);
        }

        if (transform.position.x > 11.25 && transform.tag == "Yellow")
        {
            transform.position = new Vector3(-8.75f, transform.position.y, 0);
        }

        if (transform.position.x > 11.25 && transform.tag == "Pink")
        {
            transform.position = new Vector3(-8.75f, transform.position.y, 0);
        }

        if (transform.position.x > 11.25 && transform.tag == "Magenta")
        {
            transform.position = new Vector3(-8.75f, transform.position.y, 0);
        }
    }
}
