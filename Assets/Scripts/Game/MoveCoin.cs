using UnityEngine;

public class MoveCoin : MonoBehaviour
{
    public float CoinMoveSpeed;

    private void Update()
    {
        transform.position += Vector3.left * CoinMoveSpeed * Time.deltaTime;
    }
}
