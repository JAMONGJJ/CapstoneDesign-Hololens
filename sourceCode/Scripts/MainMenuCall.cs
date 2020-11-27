using HoloToolkit.Unity.InputModule;
using UnityEngine;
using System.Collections;

public class MainMenuCall : MonoBehaviour, IInputClickHandler
{
    bool pressed = false;

    public GameObject createWeapon;
    CreateWeaponScript createWeapon_script;

    public GameObject exitGame;

    // Use this for initialization
    void Start()
    {
        createWeapon_script = createWeapon.GetComponent<CreateWeaponScript>();
    }

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

    public void active()
    {
        createWeapon.SetActive(true);
        exitGame.SetActive(true);
    }

    public void unactive()
    {
        createWeapon_script.unactive();
        createWeapon.SetActive(false);
        exitGame.SetActive(false);
    }
}
