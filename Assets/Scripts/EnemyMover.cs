using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    private Vector3 _target;
    private float _deltaMove;
    private readonly float _maxDistanceDelta = 0.01f;


    private void Update()
    {
        _deltaMove = 0.1f;

        if (Vector3.Distance(transform.position, _target) > _deltaMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, _maxDistanceDelta);
        }
    }

    public void SetTarget(Vector3 target)
    {
        _target = target;
    }
}


