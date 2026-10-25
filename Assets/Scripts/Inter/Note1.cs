using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Collections;
public class Note1 : MonoBehaviour
{
    public GameObject noteText;
    public bool isNoteOpen = false;
    public GameObject tut;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tut.gameObject.SetActive(true);
        StartCoroutine(tuto());

    }
    private void Update()
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
                PlayerMovement.Instance.speed = 5f;
                PlayerController.Instance.mouseSensitivity = 100f;
                HeadBobSys.Instance.Frequency = 10f;
                HeadBobSys.Instance.Amount = 0.002f;
            }
        }
    }

    private IEnumerator tuto()
    {
        yield return new WaitForSeconds(60f);
        tut.gameObject.SetActive(false);
    }
}
