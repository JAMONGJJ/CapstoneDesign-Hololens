using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class Num4Script : MonoBehaviour, IInputClickHandler
{
    public GameObject main;
    MainMenuCall main_script;
    public GameObject plane4;
    public GameObject weapon;
    public GameObject Num_object;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Instantiate(weapon, plane4.transform.position + Vector3.up * 0.01f, Quaternion.identity);
        plane4.SetActive(false);
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
