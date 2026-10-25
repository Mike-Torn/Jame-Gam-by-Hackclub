using System;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

interface IInteractable
{
    void Interact();
}

public class PlayerInteract : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange = 3f;

    private void Start()
    {


    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();

        }
    }
    private void Interact()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }

            }
        }
        Debug.Log("Interact key pressed");
    }


}