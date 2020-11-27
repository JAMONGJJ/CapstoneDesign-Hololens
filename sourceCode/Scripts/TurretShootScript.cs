using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShootScript : MonoBehaviour
{
    public GameObject explosion;
    public float radius;        // 무기 사정거리
    public float CS_speed;      // 무기 연사속도(값이 클수록 느려짐)
    public float price;         // 무기 생성 가격

    float time;
    int count;                  // 무기가 발사할 수 있는 갯수
    Transform target;
    float distance;

    // Use this for initialization
    void Start()
    {
        time = 0.0f;
        count = 1;
        distance = radius;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius, 1 << 8);
        if (colliders.Length > 0)
        {
            foreach (Collider col in colliders)
            {
                if (Vector3.Distance(col.gameObject.transform.position, transform.position) <= distance)
                {
                    distance = Vector3.Distance(col.transform.position, transform.position);
                    target = col.transform;
                }
            }
        }
        transform.LookAt(target);
        if (time >= CS_speed)
        {
            count = 1;
            time = 0.0f;
        }
        if (count > 0)
        {
            Instantiate(explosion, target.position, Quaternion.identity);
            Destroy(target.gameObject);
            count = 0;
        }
        distance = radius;
    }
}
