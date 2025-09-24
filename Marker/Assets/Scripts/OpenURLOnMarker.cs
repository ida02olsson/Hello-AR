using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class OpenURLOnMarker : MonoBehaviour
{
    private bool hasOpenedURL = false;
    public string urlToOpen = "https://www.youtube.com/watch?v=MtN1YnoL46Q"; 


    void OnEnable()
    {
    if (!hasOpenedURL)
    {
        Application.OpenURL(urlToOpen);
        hasOpenedURL = true;
    }
    }
}
