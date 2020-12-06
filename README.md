# CapstoneDesign-Hololens
> ## 홀로렌즈를 이용한 Interactive Game 구현
> ## 정해진 위치에 원하는 포탑을 배치해 몰려오는 몬스터들을 처치하는 게임

#### 사용언어 및 툴 : C#, Unity, MixedRealityToolkit(https://github.com/microsoft/MixedRealityToolkit-Unity)
#### 작업 인원 : 1인 프로젝트

#### < 주제 선정 이유 >
> ###### AR 기기인 홀로렌즈를 이용한 목적을 뚜렷하게 하기 위해서 사용자가 주변 지형지물과 Interactive하게 게임에 참여할 수 있는 콘텐츠 제작

#### < 작업 내용 >
> ###### * 홀로렌즈의 Spatial Mapping을 이용해 주변 지형지물을 스캔해 obj파일로 렌더링 후 유니티로 import (스캔한 공간에서 벗어나면 지형지물과 상호작용할 수 없음)
![MyRoom캡처](https://user-images.githubusercontent.com/75113789/101274386-f9517800-37e0-11eb-89a4-5036d1058379.PNG)

> ###### * 지형지물 중 평평한 물체 위에 게임을 진행할 필드를 배치하고 그에 맞춰 주변 오브젝트들을 배치
![게임필드](https://user-images.githubusercontent.com/75113789/101274385-f787b480-37e0-11eb-8d0c-849027255842.PNG)

> ###### * 플레이어가 상호작용 할 수 있는 구 형태의 메뉴 아이콘을 만들고 해당 아이콘을 통해 원하는 포탑을 원하는 위치에 배치해 몬스터를 처치
![게임메뉴](https://user-images.githubusercontent.com/75113789/101274387-f9517800-37e0-11eb-912b-d2e907d66dc8.PNG)

> ###### * ShootScript.cs
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
