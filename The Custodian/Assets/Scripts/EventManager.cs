using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class EventManager : MonoBehaviour
{
    [SerializeField] GameObject[] levels;

    public static event Action MatchFound;
    public static event Action MatchLost;
    public static event Action NewFieldSelected;
    public static event Action NewRuleSelected;
    public static event Action NextForm;
    public static event Action CheckMatch;

    public static void StartMatchFound()
    {
        MatchFound?.Invoke();
    }

    public static void StartMatchLost()
    {
        MatchLost?.Invoke();
    }

    public static void StartNewFieldSelected()
    {
        NewFieldSelected?.Invoke();
    }
    public static void StartNewRuleSelected()
    {
        NewRuleSelected?.Invoke();
    }

    public static void StartCheckMatch()
    {
        CheckMatch?.Invoke();
        Debug.Log("Checking");
    }
}
