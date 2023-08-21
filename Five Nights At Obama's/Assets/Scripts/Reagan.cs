using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reagan : MonoBehaviour
{
    public GameObject reagan;
    public float randomMove;
    public float randomtimetoMove;
    public float rate = 0.001f;
    public GameObject spot;
    public GameObject spot1;
    public GameObject spot2;

    [SerializeField] private Animator animator;
    // use "animator.SetBool("IsMoving", true);" to start walk animation
    // use "animator.SetBool("IsMoving", false);" to stop wallk animation

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
            reagan.transform.position = spot.transform.position;
            reagan.transform.rotation = spot.transform.rotation;
        }

        if (randomMove == 1)
        {
            reagan.transform.position = spot1.transform.position;
            reagan.transform.rotation = spot1.transform.rotation;
        }

        if (randomMove == 2)
        {
            reagan.transform.position = spot2.transform.position;
            reagan.transform.rotation = spot2.transform.rotation;
        }
    }
}
