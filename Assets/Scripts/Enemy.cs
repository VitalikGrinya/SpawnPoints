using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector2 _direction;

    private float _destroyPoint = -2;

    private void Update()
    {
        Init();
        transform.Translate(0,0, _speed * Time.deltaTime);

        if(gameObject.transform.position.y < _destroyPoint)
            Destroy(gameObject);
    }

    private void Init()
    {
        _direction = Vector2.left;

        transform.forward = _direction * Time.deltaTime;
    }
}
