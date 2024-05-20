using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    public TextMeshProUGUI text;
    public ParticleSystem particleEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.gameObject.SetActive(true); 
            text.text = "E";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.gameObject.SetActive(false); 
        }
    }
    private void Update()
    {
        if (text.gameObject.activeSelf && Input.GetKeyDown(KeyCode.E)) 
        {
            particleEffect.gameObject.SetActive(true);

        }
    }
}
