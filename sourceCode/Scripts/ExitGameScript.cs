using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class ExitGameScript : MonoBehaviour, IInputClickHandler
{
    public bool isActive = true;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Application.Quit();
    }

    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.SetActive(isActive);
    }
}
