using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class Weapons : MonoBehaviour, IInputClickHandler
{
    public bool pressed = false;
    public bool isActive = true;
    public GameObject Num1;
    //public GameObject Num1_object;
    public GameObject Num2;
    //public GameObject Num2_object;
    public GameObject Num3;
    //public GameObject Num3_object;
    public GameObject Num4;
    //public GameObject Num4_object;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (!pressed)
        {
            active();
            pressed = true;
        }
        else
        {
            unactive();
            pressed = false;
        }
    }

    // Use this for initialization
    void Start ()
    {
        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void active()
    {
        Num1.SetActive(true);
        //Num1_object.SetActive(true);
        Num2.SetActive(true);
        //Num2_object.SetActive(true);
        Num3.SetActive(true);
        //Num3_object.SetActive(true);
        Num4.SetActive(true);
        //Num4_object.SetActive(true);
    }

    public void unactive()
    {
        Num1.SetActive(false);
        //Num1_object.SetActive(false);
        Num2.SetActive(false);
        //Num2_object.SetActive(false);
        Num3.SetActive(false);
        //Num3_object.SetActive(false);
        Num4.SetActive(false);
        //Num4_object.SetActive(false);
    }
}
