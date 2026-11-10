using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    private Transform _playerTransform;

    public void EnableChase()
    {
        enabled = true;
    }

    public
    private void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position, 
            _playerTransform.position, 
            _speed);
    }
}
