using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleBook : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log($"Clicked {this.gameObject.name}");
    }
}
