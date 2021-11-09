using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleMessages : MonoBehaviour
{
    private EventMaster em;
    private void Awake()
    {
        // Get reference to the event master
        em = GetComponent<EventMaster>();
    }

    private void OnEnable()
    {
        em.KeyPress += ShowConsoleMessage;
    }

    private void OnDisable()
    {
        em.KeyPress -= ShowConsoleMessage;
    }

    private void ShowConsoleMessage(char c)
    {
        Debug.Log(c.ToString());
    }
}
