using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _destroyHigh = -2;

    private void Update()
    {
        transform.Translate(0,0, _speed * Time.deltaTime);

        if (gameObject.transform.position.y < _destroyHigh)
            Destroy(gameObject);
    }
}
