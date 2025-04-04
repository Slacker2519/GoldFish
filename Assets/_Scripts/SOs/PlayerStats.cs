using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Scriptable Objects/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    [SerializeField] private float _health;
    [SerializeField] private float _speed;
    [SerializeField] private float _damage;

    public float Health => _health;
    public float Speed => _speed;
    public float Damage => _damage;
}
