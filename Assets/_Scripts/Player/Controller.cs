using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private FloatingJoystick _joystick;

    public void CharacterController(float speed)
    {
        transform.position += new Vector3(_joystick.Horizontal, _joystick.Vertical, 0f) * speed * Time.deltaTime;
    }
}
