using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class Lincoln : MonoBehaviour
{
    public GameObject Char;
    public float randomMove;
    public int randomtimetoMove;
    public int rate = 1;
    public Transform spot;
    public Transform spot1;
    public Transform spot2;
    public Transform spot3;

    [SerializeField] private Animator animator;
    // use "animator.SetBool("IsMoving", true);" to start walk animation
    // use "animator.SetBool("IsMoving", false);" to stop wallk animation

    public NavMeshAgent agent;


    IEnumerator Start()
    {
        randomtimetoMove = 0;
        
        while (true)
        {
            
            if (randomtimetoMove <= 0)
            {
                randomtimetoMove = Random.Range(5, 30);
                randomGenerate();
            }
            if (randomtimetoMove > 0)
            {
                randomtimetoMove -= rate;
            }
            yield return new WaitForSeconds(1);
        }

    }
    void randomGenerate()
    {
        float oldRandomMove = randomMove;
        randomMove = Random.Range(0, 4);
        if (randomMove == oldRandomMove )
        {
            randomGenerate();
        }
        Debug.Log("Lincolns Generated Pos is " + randomMove);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (randomMove == 0)
        {
            //Char.transform.position = spot.transform.position;
            agent.SetDestination(spot.transform.position);
        }
        else if (randomMove == 1)
        {
            agent.SetDestination(spot1.transform.position);
            
        }
        else if (randomMove == 2)
        {
            agent.SetDestination(spot2.transform.position);
        }
        else if (randomMove == 3)
        {
            agent.SetDestination(spot3.transform.position);
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
