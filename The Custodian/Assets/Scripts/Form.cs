using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Form : MonoBehaviour
{
    [Header("Errors")]
    [SerializeField] GameObject error;
    [SerializeField] GameObject selectedError;

    [Header("Rules")]
    [SerializeField] string ruleStr;
    [SerializeField] GameObject rule;
    [SerializeField] GameObject selectedRule;

    [Header("Matching")]
    // [SerializeField] Found found;
    [SerializeField] bool match = false;
    

void Start()
{
    rule = GameObject.Find(ruleStr);
    EventManager.CheckMatch += CheckMatch;
    // found = FindObjectOfType<Found>().GetComponent<Found>();
}


    // void OnMouseDown()
    // {
    //     Debug.Log($"Clicked {this.gameObject.name}");
    // }

    public void SelectError(GameObject error)
    {
        selectedError = error;
    }
    public void SelectRule(GameObject rule)
    {
        selectedRule = rule;
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
            // found.gameObject.SetActive(match);
            if (match)
            {
                EventManager.StartMatchFound();
            }
            else
            {
                EventManager.StartMatchLost();
            }
        }
    }
}
