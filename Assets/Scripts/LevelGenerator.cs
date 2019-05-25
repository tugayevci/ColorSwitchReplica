using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject circlePrefab;
    public GameObject squarePrefab;
    public GameObject linePrefab;

    public GameObject colorChanger;
        
    public void LevelGeneratorMethod(Rigidbody2D rb)
    {
        int randomLevel = RandomLevelGeneratorIndex();

        switch (randomLevel)
        {
            case 0:
                SingleCircleGenerator(rb);
                break;
            case 1:
                DoubleCircleGenerator(rb);
                break;
            case 2:
                SingleCircleGenerator(rb);
                break;
            case 3:
                SingleSquareGenerator(rb);
                break;
            case 4:
                SingleLineGenerator(rb);
                break;
        }

        ColorChangerSpawner(rb);
    }

    public void ColorChangerSpawner(Rigidbody2D rb)
    {
        // New colorChanger creator
        Vector3 spawnPosition = new Vector3();
        spawnPosition.x = 0f;
        spawnPosition.y = rb.position.y + 10f;
        Instantiate(colorChanger, spawnPosition, Quaternion.identity);
    }

    public void SingleCircleGenerator(Rigidbody2D rb)
    {
        // New circle creator
        Vector3 spawnPosition = new Vector3();
        spawnPosition.y = rb.position.y + 5f;
        spawnPosition.x = 0f;
        GameObject singleCircle = Instantiate(circlePrefab, spawnPosition, Quaternion.identity);
        float randomScale = RandomScaleGenerator(); // gives random scale
        singleCircle.transform.localScale = new Vector3(randomScale, randomScale, 1); // change its local scale in x y z format
        DestroyerScript.gameObjects.Add(singleCircle);
    }
    

    public void DoubleCircleGenerator(Rigidbody2D rb)
    {
        Vector3 spawnPosition = new Vector3();
        spawnPosition.y = rb.position.y + 5f;
        spawnPosition.x = 0f;
        GameObject doubleCircleInside = Instantiate(circlePrefab, spawnPosition, Quaternion.identity);
        doubleCircleInside.transform.localScale = new Vector3(1, 1, 1); // change its local scale in x y z format

        GameObject doubleCircleOutside = Instantiate(circlePrefab, spawnPosition, Quaternion.identity);
        doubleCircleOutside.transform.localScale = new Vector3(1.5f, 1.5f, 1); // change its local scale in x y z format
        DestroyerScript.gameObjects.Add(doubleCircleInside);
        DestroyerScript.gameObjects.Add(doubleCircleOutside);


    }

    public void SingleSquareGenerator(Rigidbody2D rb)
    {
        // New square creator
        Vector3 spawnPosition = new Vector3();
        spawnPosition.y = rb.position.y + 5f;
        spawnPosition.x = 0f;
        GameObject square = Instantiate(squarePrefab, spawnPosition, Quaternion.identity);
        float randomScale = RandomScaleGenerator(); // gives random scale
        square.transform.localScale = new Vector3(randomScale, randomScale, 1); // change its local scale in x y z format
        DestroyerScript.gameObjects.Add(square);


    }

    public void SingleLineGenerator(Rigidbody2D rb)
    {
        // New line creator
        Vector3 spawnPosition = new Vector3();
        spawnPosition.y = rb.position.y + 5f;
        spawnPosition.x = 0f;
        GameObject line = Instantiate(linePrefab, spawnPosition, Quaternion.identity);
        float randomScale = RandomScaleGenerator(); // gives random scale
        line.transform.localScale = new Vector3(1, 1, 1); // change its local scale in x y z format
        DestroyerScript.gameObjects.Add(line);


    }


    public int RandomLevelGeneratorIndex()
    {
        int randomScale = Random.Range(0, 5);
        return randomScale;
    }

    public float RandomScaleGenerator()
    {
        float randomScale = Random.Range(0.8f, 1.4f);
        return randomScale;
    }

    
}
