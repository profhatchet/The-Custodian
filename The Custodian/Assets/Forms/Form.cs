using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Form : MonoBehaviour
{
    [SerializeField] GameObject error;

    void OnMouseDown()
    {
        Debug.Log("Clicked me");
    }

}
