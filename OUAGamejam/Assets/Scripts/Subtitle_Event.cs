using System.Collections;
using UnityEngine;

public class Subtitle_Event : MonoBehaviour
{
    public Subtitle subtitleManager;
    public GameObject canvas;
    public string yazilacakYazi;

    public void CallSubtitle()
    {
        canvas.SetActive(true);

        subtitleManager.ShowSubtitle(yazilacakYazi, 5f);

        StartCoroutine(HideCanvasAfterDuration(5f));
    }

    private IEnumerator HideCanvasAfterDuration(float duration)
    {
        yield return new WaitForSeconds(duration);
        canvas.SetActive(false);
    }
}
