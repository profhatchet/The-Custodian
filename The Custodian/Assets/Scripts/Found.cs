using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Found : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Image image;

    void Start()
    {
        this.gameObject.SetActive(false);
        // spriteRenderer = GetComponent<SpriteRenderer>();
        image = GetComponent<Image>();
        EventManager.MatchFound += SetFoundSprite;
        EventManager.MatchLost += HideBanner;
        EventManager.CheckMatch += ShowBanner;
    }


    void SetFoundSprite()
    {
        // spriteRenderer.sprite = sprites[1];
        image.sprite = sprites[1];
    }

    void ShowBanner()
    {
        gameObject.SetActive(true);
    }

    void HideBanner()
    {
        gameObject.SetActive(false);
        // spriteRenderer.sprite = sprites[0];
        image.sprite = sprites[0];
    }
}
