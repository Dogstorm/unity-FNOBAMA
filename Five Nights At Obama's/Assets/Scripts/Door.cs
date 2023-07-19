using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField]
    private Battery battery;
    public void Interact()
    {
        PlayAnimation();
        
    }
    [SerializeField] private Animator doorAnim;

    public bool doorOpen = false;

    [SerializeField] private string openAnimationName = "DoorOpen";
    [SerializeField] private string closeAnimationName = "DoorClose";
    [SerializeField] GameObject buttonHitBox;
    
    

    [SerializeField] int waitTimer;
    private bool pauseInteraction = false;

   

    private IEnumerator PauseDoorInteraction()
    {
        pauseInteraction = true;
        yield return new WaitForSeconds(waitTimer);
        pauseInteraction = false;
    }

    public void PlayAnimation()
    {
        if (!doorOpen && !pauseInteraction)
        {
            doorAnim.Play(openAnimationName, 0, 0.0f);
            doorOpen = true;
            StartCoroutine(PauseDoorInteraction());
            buttonHitBox.GetComponent<DoorPrompt>().promptMessage = "Open Door";
            battery.drainOverTime = true;

        }

        else if (doorOpen && !pauseInteraction)
        {
            doorAnim.Play(closeAnimationName, 0, 0.0f);
            doorOpen = false;
            StartCoroutine(PauseDoorInteraction());
            buttonHitBox.GetComponent<DoorPrompt>().promptMessage = "Close Door";
            battery.drainOverTime = false;

        }
    }
}