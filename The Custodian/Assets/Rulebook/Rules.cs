using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    Form form;
    Vector3 clickedPosition;

    private void Awake()
    {
        form = FindObjectOfType<Form>().GetComponent<Form>();

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
            form.SelectRule(this.gameObject);
        }
    }


}
