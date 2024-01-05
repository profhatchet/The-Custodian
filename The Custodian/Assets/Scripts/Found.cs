using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Found : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        EventManager.MatchFound += ShowBanner;
        EventManager.MatchLost += HideBanner;
    }

    void ShowBanner()
    {
        gameObject.SetActive(true);
    }

    void HideBanner()
    {
        gameObject.SetActive(false);
    }
}
