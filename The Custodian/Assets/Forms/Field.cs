using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

[RequireComponent(typeof(SpriteRenderer))]

public class Field : MonoBehaviour
{
    Form form;
    Vector3 clickedPosition;
    SpriteRenderer sprite;

    private void Awake()
    {
        form = this.GetComponentInParent<Form>();
        sprite = GetComponent<SpriteRenderer>();
        sprite.enabled = false;
        EventManager.NewFieldSelected += HideSelector;
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
            EventManager.StartNewFieldSelected();
            form.SelectError(this.gameObject);
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    void HideSelector()
    {
        sprite.enabled = false;
    }

}
