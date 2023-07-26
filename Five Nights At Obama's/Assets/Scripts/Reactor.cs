using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactor : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject Battery;
    [SerializeField] private GameObject Hands;
    public void Interact()
    {
        Battery.SetActive(true);
        Hands.SetActive(false);

    }

}
