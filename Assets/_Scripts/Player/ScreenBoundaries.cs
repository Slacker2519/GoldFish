using UnityEngine;

public class ScreenBoundaries : MonoBehaviour
{
    private Vector2 _screenBounds;
    [SerializeField] private float _objectWidth;
    [SerializeField] private float _objectHeight;


    private void Start()
    {
        _screenBounds= Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    private void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, _screenBounds.x + _objectWidth, _screenBounds.x * -1 - _objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, _screenBounds.y + _objectHeight, _screenBounds.y * -1 - _objectHeight);
        transform.position = viewPos;
    }
}
