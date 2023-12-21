using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class Field : MonoBehaviour
{

    Form form;

    private void Awake()
    {
        form = this.GetComponentInParent<Form>();

    }

    private void OnMouseDown()
    {
        Debug.Log($"Clicked {this.gameObject.name}");
        form.SelectError(this.gameObject);
    }

}
