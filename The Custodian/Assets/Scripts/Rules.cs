using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class Rules : MonoBehaviour
{
    Form form;
    Vector3 clickedPosition;
    SpriteRenderer sprite;

    private void Awake()
    {
        form = FindObjectOfType<Form>().GetComponent<Form>();
        sprite = GetComponent<SpriteRenderer>();
        sprite.enabled = false;
        EventManager.NewRuleSelected += HideSelector;
    }

    void OnMouseDown()
    {
        clickedPosition = gameObject.transform.position;
    }

    void OnMouseUp()
    {
        if (gameObject.transform.position == clickedPosition)
        {
            Debug.Log($"Clicked {this.gameObject.name}");
            EventManager.StartNewRuleSelected();
            form.SelectRule(this.gameObject);
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    void HideSelector()
    {
        sprite.enabled = false;
    }


}
