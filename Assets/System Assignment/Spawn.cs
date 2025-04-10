using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Dog; // reference of the dog prefab
    GameObject newDog;    // standing for all new create dog
    public GameObject Cat;// reference of the cat prefab
    GameObject newCat;// standing for all new create cat

    public float t; // set a variable for time 

    GameScore gameScore;
    // Start is called before the first frame update
    void Start()
    {
        //When the game just start, spawn these two prefabs
        newDog = Instantiate(Dog, new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity); // the prefab for dog, location and do not rotate
        newCat = Instantiate(Cat, new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);// the prefab for cat, location and do not rotate

        // start continuing coroutine
        StartCoroutine(keepSpawn());

        gameScore = GetComponent<GameScore>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckDog();
            CheckCat();
        }
    }

    public void CheckDog()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float checkSpriteDistance = Vector2.Distance(mousePos, newDog.transform.position);
        if(checkSpriteDistance < 1.5)
        {
            Destroy(newDog);
            gameScore.AddScore();
        }
    }
    public void CheckCat()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float checkSpriteDistance = Vector2.Distance(mousePos, newCat.transform.position);
        if (checkSpriteDistance < 1.5)
        {
            Destroy(newCat);
            gameScore.AddScore();
        }
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
        while (t < 5)//time from 0 to 5
        {
            t += Time.deltaTime; // add the time everytime
            yield return null; // stop 1 frame
        }
        int randomAnimal = Random.Range(0, 2);//create the dog or cat randomly between 0 and 1
        if (randomAnimal == 0) //when it is 0, creat dog
        {
            newDog = Instantiate(Dog, new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);
        }
        else if (randomAnimal == 1) // when it is 1 create cat
        {
            newCat = Instantiate(Cat, new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);
        }
    }
}
