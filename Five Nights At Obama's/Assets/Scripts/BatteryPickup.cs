using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject Hands;
    [SerializeField] private GameObject Battery;
    public void Interact()
    {
        Hands.SetActive(true);
        Battery.SetActive(false);
    }

}
