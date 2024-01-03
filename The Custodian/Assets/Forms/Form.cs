using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Form : MonoBehaviour
{
    [SerializeField] GameObject error;
    [SerializeField] GameObject selectedError;
    [SerializeField] GameObject rule;
    [SerializeField] GameObject selectedRule;
    [SerializeField] Found found;

    bool match = false;

    // void OnMouseDown()
    // {
    //     Debug.Log($"Clicked {this.gameObject.name}");
    // }

    public void SelectError(GameObject error)
    {
        selectedError = error;
        CheckMatch();
    }
    public void SelectRule(GameObject rule)
    {
        selectedRule = rule;
        CheckMatch();
    }

    private void CheckMatch()
    {
        if (error == selectedError && rule == selectedRule)
        {
            match = true;
        }
        else
        {
            match = false;
        }
        if (selectedRule != null && selectedError != null)
        {
            Debug.Log($"{match} match");
            found.gameObject.SetActive(match);
        }
    }
}
