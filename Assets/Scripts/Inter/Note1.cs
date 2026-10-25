using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class Note1 : MonoBehaviour
{
    public TextMeshProUGUI noteText;
    public bool isNoteOpen = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void FixedUpdate()
    {
        Note();
    }

    private void Note()
    {
        if(Input.GetKeyDown(KeyCode.V))
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
}
