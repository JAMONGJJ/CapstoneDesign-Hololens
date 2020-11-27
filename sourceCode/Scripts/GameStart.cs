using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class GameStart : MonoBehaviour, IInputClickHandler
{
    public int flag;                    // GAMESTART가 여러번 눌리는것을 방지하고, 스테이지를 성공했는지 실패했는지 나타내는 변수
    Vector3 GenPoint;
    public GameObject mob;
    Move mob_script;
    public GameObject Timer;

    public List<GameObject> mobs;
    // Use this for initialization
    void Start () {
        Timer.SetActive(false);
        flag = 0;
        mobs = new List<GameObject>();
        mob_script = mob.GetComponent<Move>();
        GenPoint = new Vector3(0.0f, 0.0f, 0.0f);
    }
    
    void Generate()
    {
        if(flag == 1)
            StartCoroutine(respawn());
    }
    IEnumerator respawn()
    {
        for (int i = 0; i < 10; i++)    //  총 20개의 몹 만들어냄
        {
            Instantiate(mob, GenPoint, Quaternion.identity);
            mobs.Add(mob);
            mob_script.flag = true;
            yield return new WaitForSeconds(1.5f);  // 1.5초 시간지연
        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (flag == 0)
        {
            Timer.SetActive(true);
            flag = 1;
            Generate();
        }
    }

    void Update()
    {
        if(flag == -1)
        {
            Application.Quit();
        }
        else if(flag == 2)
        {
            Application.Quit();
        }
    }
}



