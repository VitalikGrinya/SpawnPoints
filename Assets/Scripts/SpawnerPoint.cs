using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    [SerializeField] private Enemies _enemy;
    [SerializeField] private float _degreesRotation;
    
    public void Spawn()
    {
        var enemy = Instantiate(_enemy, transform.position, Quaternion.Euler(0, _degreesRotation, 0));
    }
}
