using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class Field : MonoBehaviour
{
    Form form;
    Vector3 clickedPosition;

    private void Awake()
    {
        form = this.GetComponentInParent<Form>();

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
            form.SelectError(this.gameObject);
        }
    }

}
