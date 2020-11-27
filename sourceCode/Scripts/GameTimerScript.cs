using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimerScript : MonoBehaviour
{
    List<GameObject> Mobs = new List<GameObject>();

    float time_tick;                    // 게임 시작하고 경과한 시간
    int remain_time;                    // 게임 제한시간
    public GameObject[] first_Digits;   // 몹의 수를 표현할 숫자들(1의 자리)
    public GameObject[] second_Digits;  // 몹의 수를 표현할 숫자들(10의 자리)
    public GameObject Base3;            // 숫자가 표현될 Base

    public GameObject gameStart;
    GameStart gameStart_script;
	// Use this for initialization
	void Start ()
    {
        time_tick = 0.0f;
        remain_time = 0;
        gameStart_script = gameStart.GetComponent<GameStart>();
        unactiveAll();
    }
	
	// Update is called once per frame
	void Update ()
    {
        time_tick += Time.deltaTime;
        Mobs = gameStart_script.mobs;
        Timer();
    }

    void Timer()
    {
        remain_time = (int)(30 - time_tick);
        DisplayRemainTime(remain_time);
        if(time_tick >= 30.0f)
        {
            unactiveAll();
            time_tick = 0.0f;
            if (Mobs.Count != 0) // -1 : 스테이지 실패
                gameStart_script.flag = -1;
            else // 2 : 스테이지 성공
                gameStart_script.flag = 2;
            unactiveAll();
            gameObject.SetActive(false);
        }
    }

    void DisplayRemainTime(int time)
    {
        int firstDigit = time % 10;
        int secondDigit = time / 10 % 10;
        for(int i = 0; i < first_Digits.Length; i++)
        {
            if (i == firstDigit)
                first_Digits[i].SetActive(true);
            else
                first_Digits[i].SetActive(false);
        }
        for (int i = 0; i < second_Digits.Length; i++)
        {
            if (i == secondDigit)
                second_Digits[i].SetActive(true);
            else
                second_Digits[i].SetActive(false);
        }
    }

    void unactiveAll()
    {
        foreach (GameObject obj in first_Digits)
            obj.SetActive(false);

        foreach (GameObject obj in second_Digits)
            obj.SetActive(false);
    }
}
