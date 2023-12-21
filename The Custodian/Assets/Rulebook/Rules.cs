using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    Form form;

    private void Awake()
    {
        form = FindObjectOfType<Form>().GetComponent<Form>();

    }

    private void OnMouseDown()
    {
        Debug.Log($"Clicked {this.gameObject.name}");
        form.SelectRule(this.gameObject);
    }


}
