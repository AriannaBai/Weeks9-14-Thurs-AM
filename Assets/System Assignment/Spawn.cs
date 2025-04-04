using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Dog;
    GameObject newDog;
    List<GameObject> SpawnDog;
    public GameObject Cat;
    GameObject newCat;
    List<GameObject> SpawnCat;

    public float t;
    // Start is called before the first frame update
    void Start()
    {
        SpawnDog = new List<GameObject>();
        SpawnCat = new List<GameObject>();

        newDog = Instantiate(Dog, new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);
        newCat = Instantiate(Cat, new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);

        StartCoroutine(keepSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator keepSpawn()
    {
        while (true)
        {
            yield return StartCoroutine(TimeToSpawn());
        }
    }
    IEnumerator TimeToSpawn()
    {
        t = 0;
        while(t < 5)
        {
            t += Time.deltaTime;
            yield return null;
        }
        int randomAnimal = Random.Range(0, 2);
        if(randomAnimal == 0)
        {
            newDog = Instantiate(Dog, new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);
        }else if (randomAnimal == 1)
        {
            newCat = Instantiate(Cat, new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);
        }
    }
}
