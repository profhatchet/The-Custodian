using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickandDrag : MonoBehaviour
{

    public GameObject selectedObject;
    Vector3 offset;
    [SerializeField] Collider2D[] results;

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) && Physics2D.OverlapPoint(mousePosition))
        {
            results = Physics2D.OverlapPointAll(mousePosition);
            Collider2D highestCollider = GetHighestObject(results);
            selectedObject = highestCollider.transform.gameObject;
            offset = selectedObject.transform.position - mousePosition;
        }
        if (selectedObject)
        {
            selectedObject.transform.position = mousePosition + offset;
        }
        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            selectedObject = null;
        }
    }

    Collider2D GetHighestObject(Collider2D[] results)  //currently just checks all colliders for movable tag
    {
        int highestValue = 0;
        Collider2D highestObject = results[0];
        foreach (Collider2D col in results)
        {
            Renderer ren = col.gameObject.GetComponent<Renderer>();
            if (col.gameObject.tag == "moveable")
            {
                Debug.Log(col.gameObject.tag);
                highestValue = ren.sortingOrder;
                highestObject = col;
            }
        }
        return highestObject;
    }
}