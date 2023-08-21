using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

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

    public NavMeshAgent agent;

    void Start()
    {
        randomtimetoMove = 0;
        
    }
    void randomGenerate()
    {
        float oldRandomMove = randomMove;
        randomMove = Random.Range(0, 3);
        if (randomMove == oldRandomMove)
        {
            randomGenerate();
        }
        Debug.Log("Reagans Generated Pos is " + randomMove);
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
            //reagan.transform.position = spot.transform.position;
            //reagan.transform.rotation = spot.transform.rotation;
            agent.SetDestination(spot.transform.position);
        }

        if (randomMove == 1)
        {
            agent.SetDestination(spot1.transform.position);
        }

        if (randomMove == 2)
        {
            agent.SetDestination(spot2.transform.position);
        }

        if (agent.remainingDistance <= 0)
        {
            animator.SetBool("IsMoving", false);
        }
        else
        {
            animator.SetBool("IsMoving", true);
        }

    }
}
