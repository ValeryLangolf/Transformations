using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);

        var vector = new Vector3(0.1f, 0.1f, 0.1f);
        var position = vector.normalized;
        Debug.Log(position.x);
    }
}