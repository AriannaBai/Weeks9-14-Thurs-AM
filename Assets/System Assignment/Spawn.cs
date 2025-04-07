using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Dog; // reference of the dog prefab
    GameObject newDog;    // standing for all new create dog
    List<GameObject> SpawnDog;// List for saving all the new spawn dog 
    public GameObject Cat;// reference of the cat prefab
    GameObject newCat;// standing for all new create cat
    List<GameObject> SpawnCat;// List for saving all the new spawn cat

    public float t; // set a variable for time 
    // Start is called before the first frame update
    void Start()
    {
        SpawnDog = new List<GameObject>(); //initialize all lists
        SpawnCat = new List<GameObject>();

        //When the game just start, spawn these two prefabs
        newDog = Instantiate(Dog, new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity); // the prefab for dog, location and do not rotate
        newCat = Instantiate(Cat, new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);// the prefab for cat, location and do not rotate

        // start continuing coroutine
        StartCoroutine(keepSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator keepSpawn()
    {
        while (true)  // always run 
        {
            yield return StartCoroutine(TimeToSpawn());// the prefab for dog and cat restart 
        }
    }
    IEnumerator TimeToSpawn()
    {
        t = 0;//time start
        while(t < 5)//time from 0 to 5
        {
            t += Time.deltaTime; // add the time everytime
            yield return null; // stop 1 frame
        }
        int randomAnimal = Random.Range(0, 2);//create the dog or cat randomly between 0 and 1
        if(randomAnimal == 0) //when it is 0, creat dog
        {
            newDog = Instantiate(Dog, new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);
        }else if (randomAnimal == 1) // when it is 1 create cat
        {
            newCat = Instantiate(Cat, new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);
        }
    }
}
