using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneratorPiano : MonoBehaviour
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
                SingleSquareGenerator(rb);
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
        spawnPosition.y = rb.position.y + 5f;
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
        singleCircle.transform.localScale = new Vector3(1, 1, 1); // change its local scale in x y z format
        int randomAngle = RandomAngleGenerator();
        singleCircle.transform.rotation = Quaternion.Euler(0, 0, randomAngle);

        DestroyerScript.gameObjects.Add(singleCircle);
        DestroyerScript.lastCreatedObject = singleCircle;
    }


    public void DoubleCircleGenerator(Rigidbody2D rb)
    {

        Vector3 spawnPosition = new Vector3();
        spawnPosition.y = rb.position.y + 7f;
        spawnPosition.x = 0f;
        GameObject doubleCircleInside = Instantiate(circlePrefab, spawnPosition, Quaternion.identity);
        doubleCircleInside.transform.localScale = new Vector3(0.6f, 0.6f, 1); // change its local scale in x y z format
        int randomAngle = RandomAngleGenerator();
        doubleCircleInside.transform.rotation = Quaternion.Euler(0, 0, randomAngle);
        GameObject doubleCircleOutside = Instantiate(circlePrefab, spawnPosition, Quaternion.identity);
        doubleCircleOutside.transform.localScale = new Vector3(1.5f, 1.5f, 1); // change its local scale in x y z format
        int randomAngle2 = RandomAngleGenerator();
        doubleCircleOutside.transform.rotation = Quaternion.Euler(0, 0, randomAngle2);
        DestroyerScript.gameObjects.Add(doubleCircleInside);
        DestroyerScript.gameObjects.Add(doubleCircleOutside);

        DestroyerScript.lastCreatedObject = doubleCircleOutside;

    }

    public void SingleSquareGenerator(Rigidbody2D rb)
    {
        // New square creator
        Vector3 spawnPosition = new Vector3();
        spawnPosition.y = rb.position.y + 5f;
        spawnPosition.x = 0f;
        GameObject square = Instantiate(squarePrefab, spawnPosition, Quaternion.identity);
        float randomScale = RandomScaleGenerator(); // gives random scale
        square.transform.localScale = new Vector3(0.7f, 0.7f, 1); // change its local scale in x y z format
        int randomAngle = RandomAngleGenerator();
        square.transform.rotation = Quaternion.Euler(0, 0, randomAngle);
        DestroyerScript.gameObjects.Add(square);

        DestroyerScript.lastCreatedObject = square;

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
        int randomAngle = RandomAngleGenerator();
        line.transform.rotation = Quaternion.Euler(0, 0, randomAngle);
        DestroyerScript.gameObjects.Add(line);
        DestroyerScript.lastCreatedObject = line;


    }

    int RandomAngleGenerator()
    {
        int randomScale = Random.Range(0, 4);
        int returnAngle = 45;
        switch (randomScale)
        {
            case 0:
                returnAngle = 45;
                break;
            case 1:
                returnAngle = 135;
                break;
            case 2:
                returnAngle = 225;
                break;
            case 3:
                returnAngle = 315;
                break;
        }
        return returnAngle;
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
