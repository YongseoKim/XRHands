using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    [SerializeField] private float addedForce = 380.0f; // �Ѿ��� �о�� ��
    [SerializeField] private GameObject ballPrefab; // �Ѿ� ������
    [SerializeField] private float destroyAfter = 10.0f; // �Ѿ��� ���������� �ɸ��� �ð�

    public void Shoot()
    {
        var ball = Instantiate(ballPrefab, transform.position, Quaternion.identity); // ballPrefab�̶�� ���ӿ�����Ʈ�� ����
        ball.GetComponent<Rigidbody>().AddForce(transform.forward * addedForce); // forward�� addedForce�� �� ball�� �о
        Destroy(ball,destroyAfter); // destroyAfter ������ ���� �� �ı�
    }
}