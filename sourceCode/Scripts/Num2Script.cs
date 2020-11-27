using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class Num2Script : MonoBehaviour, IInputClickHandler
{
    public GameObject main;
    MainMenuCall main_script;
    public GameObject plane2;
    public GameObject weapon;
    public GameObject Num_object;

    public void OnInputClicked(InputClickedEventData eventData)
    {   
        Instantiate(weapon, plane2.transform.position + Vector3.up * 0.01f, Quaternion.identity);
        plane2.SetActive(false);
        Num_object.SetActive(false);
        gameObject.SetActive(false);
        main_script.unactive();
    }

    // Use this for initialization
    void Start ()
    {
        gameObject.SetActive(false);
        main_script = main.GetComponent<MainMenuCall>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
