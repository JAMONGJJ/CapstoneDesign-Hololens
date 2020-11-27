using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class CreateWeaponScript : MonoBehaviour, IInputClickHandler
{
    bool pressed = false;    // 마우스 클릭이 됐는지 안됐는지 저장하는 변수
    public GameObject weapon1;
    public GameObject weapon2;
    Weapons weapon1_script;
    Weapons weapon2_script;
    //public GameObject weapon_object;

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
        weapon1_script = weapon1.GetComponent<Weapons>();
        weapon2_script = weapon2.GetComponent<Weapons>();
        //weapon_object.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void active()
    {
        weapon1.SetActive(true);
        weapon2.SetActive(true);
        //weapon_object.SetActive(true);
    }

    public void unactive()
    {
        weapon1_script.unactive();
        weapon1.SetActive(false);
        weapon2.SetActive(false);
        //weapon_object.SetActive(false);
    }
}
