using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lincoln : MonoBehaviour
{
    public GameObject Char;
    public float randomMove;
    public float randomtimetoMove;
    public float rate = 0.001f;
    public GameObject spot;
    public GameObject spot1;
    public GameObject spot2;
    void Start()
    {
        randomtimetoMove = 0;
        
    }
    void randomGenerate()
    {
        randomMove = Random.Range(0, 3);
        Debug.Log("GeneratedRandomPos");
    }
    // Update is called once per frame
    void Update()
    {
        if(randomtimetoMove <= 0)
        {
            randomtimetoMove = Random.Range(120, 320);
            randomGenerate();
        }
        if(randomtimetoMove > 0)
        {
            randomtimetoMove -= rate;
        }

        if(randomMove == 0)
        {
            //Char.transform.position = spot.transform.position;
            Char.transform.SetParent = spot;
        }

        if (randomMove == 1)
        {
            //Char.transform.position = spot1.transform.position;
            Char.transform.SetParent = spot1;
        }

        if (randomMove == 2)
        {
            //Char.transform.position = spot2.transform.position;
            Char.transform.SetParent = spot2;
        }
    }
}
