using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    public static List<GameObject> gameObjects = new List<GameObject>();
    GameObject CreatedObject;
    public static GameObject lastCreatedObject;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObjects.Count);
        if (gameObjects.Count>6)
        {
            Destroyer();
        }
    }


    public void Destroyer()
    {
        for (int i = 0; i < 3; i++)
        {
            CreatedObject = gameObjects[i];
            if (CreatedObject!=lastCreatedObject)
            {
                Destroy(CreatedObject);
                gameObjects.Remove(gameObjects[i]);
            }
            
            Debug.Log("KOD ÇALIŞTI" + i);
        }
        
    }
}
