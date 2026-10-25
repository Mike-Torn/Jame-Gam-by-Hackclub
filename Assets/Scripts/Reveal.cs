using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Reveal : MonoBehaviour
{
    public GameObject Carcosa;
    public GameObject King;

    public AudioSource RevealSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rev();
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
        if(Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(Rev1());
            StartCoroutine(Rev2());
            RevealSound.Play();
        }
    }
} 




