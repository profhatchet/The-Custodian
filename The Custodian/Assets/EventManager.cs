using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{

    public static event Action MatchFound;
    public static event Action MatchLost;
    public static event Action NewFieldSelected;
    public static event Action NewRuleSelected;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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
}
