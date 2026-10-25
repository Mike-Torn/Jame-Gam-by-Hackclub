using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
public class NoteSys : MonoBehaviour, IInteractable

{

    public TextMeshProUGUI noteText;
    public bool isNoteOpen = false;
    public void Interact()
    {

        if (isNoteOpen == false)
        {
            noteText.gameObject.SetActive(true);
            isNoteOpen = true;
            PlayerMovement.Instance.speed = 0f;
            PlayerController.Instance.mouseSensitivity = 0f;
            HeadBobSys.Instance.Frequency = 0f;
            HeadBobSys.Instance.Amount = 0f;
        }
        else
        {
            noteText.gameObject.SetActive(false);
            isNoteOpen = false;
            PlayerMovement.Instance.speed = 8f;
            PlayerController.Instance.mouseSensitivity = 100f;
            HeadBobSys.Instance.Frequency = 10f;
            HeadBobSys.Instance.Amount = 0.002f;
        }

        

    }

    
}





