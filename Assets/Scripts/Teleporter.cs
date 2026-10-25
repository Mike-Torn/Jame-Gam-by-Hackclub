using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public Transform teleportDes;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController controller = other.GetComponent<CharacterController>();
            if (controller != null)
            {
                controller.enabled = false; 
                other.transform.position = teleportDes.position; 
                controller.enabled = true; 
            }
        }
    }

}