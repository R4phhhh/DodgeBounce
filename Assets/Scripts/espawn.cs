using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject bigenemy;
    public float spawnRate;
    private float timer = 0;
    private float timer2 = 0;
    public bool gameStart = false;
    public float num = 1;
    void Start()
    {
        if (gameStart == true)
        {
            Instantiate(enemy, new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), 0), transform.rotation);
            timer = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 2)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            gameStart = true;
        }

        if (timer2 < 10)
        {
            timer = timer + Time.deltaTime;
            if (gameStart == true)
            {
                if (timer < spawnRate)
                {
                    timer = timer + Time.deltaTime;
                }
                else
                {
                    Instantiate(enemy, new Vector3(Random.Range(-10f, 10f), Random.Range(-4.5f, 4.5f), 0), transform.rotation);
                    timer = 0;
                }
            }
            timer2 = timer2 + Time.deltaTime;
        }
        else
        {
            if (gameStart == true)
            {
                if (timer < spawnRate)
                {
                    timer = timer + Time.deltaTime;
                }
                else
                {
                    if (num == 0)
                    {
                        Instantiate(enemy, new Vector3(Random.Range(-10f, 10f), Random.Range(-4.5f, 4.5f), 0), transform.rotation);
                        timer = 0;
                        num = 1;
                    }
                    else if (num == 1)
                    {
                        Instantiate(bigenemy, new Vector3(Random.Range(-10f, 10f), Random.Range(-4.5f, 4.5f), 0), transform.rotation);
                        timer = 0;
                        num = 0;
                    }
                }
            }
        }
    }

}
