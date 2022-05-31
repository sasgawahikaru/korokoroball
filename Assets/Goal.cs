using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;
    public GameObject nextButton2;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ÉSÅ[ÉãÅI");

        clearText.SetActive(true);
        nextButton.SetActive(true);
        nextButton2.SetActive(true);
        audioSource.Play();
    }
}
