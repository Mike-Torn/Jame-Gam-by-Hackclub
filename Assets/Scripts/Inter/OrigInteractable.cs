using UnityEngine;

public class Interactable : MonoBehaviour, IInteractable
{
    public void Interact()
    {


        Debug.Log("Im trying here");

        Destroy(gameObject);

    }





}
