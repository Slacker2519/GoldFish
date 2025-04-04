using UnityEngine;

[RequireComponent(typeof(Controller))]
public class Player : MonoBehaviour
{
    [SerializeField] private Controller _controller;
    [SerializeField] private PlayerStats _playerStats;

    private void Awake()
    {
        if (_controller == null)
        {
            _controller = GetComponent<Controller>();
        }
    }

    private void Update()
    {
        if (_playerStats)
        {
            _controller.CharacterController(_playerStats.Speed);
        }
    }
}
