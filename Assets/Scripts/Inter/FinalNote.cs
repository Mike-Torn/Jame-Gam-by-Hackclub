using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalNote : MonoBehaviour, IInteractable
{
    public TextMeshProUGUI noteText;
    public bool isNoteOpen = false;

    public GameObject Carcosa;
    public GameObject King;
    public AudioSource RevealSound;

    public GameObject _05_8;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
            Rev();
           
        }



    }

    private IEnumerator Rev1()
    {
        yield return new WaitForSeconds(26f);
        Carcosa.SetActive(true);
    }

    private IEnumerator Rev2()
    {
        yield return new WaitForSeconds(34f);
        King.SetActive(true);
    }

    private void Rev()
    {
        
        
        StartCoroutine(Rev1());
        StartCoroutine(Rev2());
        StartCoroutine(rev3());
        RevealSound.Play();
        
    }

    private IEnumerator rev3()
    {
        yield return new WaitForSeconds(58f);
        _05_8.SetActive(true);
    }

}
