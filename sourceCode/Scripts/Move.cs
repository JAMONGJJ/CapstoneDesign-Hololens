using UnityEngine;

public class Move : MonoBehaviour
{
    public bool flag = false;       // true : 몹이 움직임 / false : 몹이 멈춤
    float time;                     // 몹이 움직이기 시작한 후 경과한 시간
    public float speed;             // 몹 속도

    float Time1to2;
    float Time2to3;
    float Time3to4;
    float Time4to1;
    public Vector3 Base1;
    public Vector3 Base2;
    public Vector3 Base3;
    public Vector3 Base4;

    void Start()
    {
        time = 0.0f;
        transform.Translate(Base1);
        Time1to2 = Vector3.Distance(Base1, Base2) / speed;
        Time2to3 = Vector3.Distance(Base2, Base3) / speed;
        Time3to4 = Vector3.Distance(Base3, Base4) / speed;
        Time4to1 = Vector3.Distance(Base4, Base1) / speed;
    }

    // Update is called once per frame
    public void Update () {
        time += Time.deltaTime;
        if (flag && time <= Time1to2)
            transform.position += Vector3.Normalize(Base2 - Base1) * Time.deltaTime * speed;
        else if (flag && time <= Time1to2 + Time2to3)
            transform.position += Vector3.Normalize(Base3 - Base2) * Time.deltaTime * speed;
        else if (flag && time <= Time1to2 + Time2to3 + Time3to4)
            transform.position += Vector3.Normalize(Base4 - Base3) * Time.deltaTime * speed;
        else
            transform.position += Vector3.Normalize(Base1 - Base4) * Time.deltaTime * speed;

        if (time >= Time1to2 + Time2to3 + Time3to4 + Time4to1)
            time = 0.0f;
    }
}
