using System.Collections;
using UnityEngine;
using TMPro;

public class Subtitle : MonoBehaviour
{
    public TextMeshProUGUI subtitleText; 
    public float displayDuration = 5f; 
    public float typingSpeed = 0.05f; 

    void Start()
    {
        subtitleText.gameObject.SetActive(false);
    }

    public void ShowSubtitle(string subtitle, float duration)
    {
        StartCoroutine(ShowSubtitleCoroutine(subtitle, duration));
    }

    private IEnumerator ShowSubtitleCoroutine(string subtitle, float duration)
    {
        subtitleText.gameObject.SetActive(true);
        yield return StartCoroutine(TypeSubtitle(subtitle));

        yield return new WaitForSeconds(duration);

        subtitleText.gameObject.SetActive(false);
    }

    private IEnumerator TypeSubtitle(string subtitle)
    {
        subtitleText.text = "";
        foreach (char letter in subtitle.ToCharArray())
        {
            subtitleText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
