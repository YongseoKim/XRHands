using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    [SerializeField] private float addedForce = 380.0f; // 총알을 밀어내는 힘
    [SerializeField] private GameObject ballPrefab; // 총알 프리팹
    [SerializeField] private float destroyAfter = 10.0f; // 총알이 사라지기까지 걸리는 시간

    public void Shoot()
    {
        var ball = Instantiate(ballPrefab, transform.position, Quaternion.identity); // ballPrefab이라는 게임오브젝트를 생성
        ball.GetComponent<Rigidbody>().AddForce(transform.forward * addedForce); // forward로 addedForce를 줘 ball을 밀어냄
        Destroy(ball,destroyAfter); // destroyAfter 변수에 따라 총 파괴
    }
}