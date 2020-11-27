using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public int remain_Life;
    public int Money;
    public Text nickName_Text;
    public Text money_Text;
    public Text life_Text;
    public Text timer_Text;

    float time;
	// Use this for initialization
	void Start ()
    {
        time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        //time += Time.deltaTime;
        SetNameText();
        SetTimerText(((int)time).ToString());
        SetLifeText(remain_Life.ToString());
        SetMoneyText(Money.ToString());
    }
    void SetNameText()
    {
        nickName_Text.text = "Nick Name : FUNKYORANGE";
    }

    void SetTimerText(string text)
    {
        timer_Text.text = "Remain Time : " + text;
    }

    void SetLifeText(string text)
    {
        life_Text.text = "Remain Life : " + text;
    }

    void SetMoneyText(string text)
    {
        money_Text.text = "Money : " + text;
    }
}
