using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private EnemyMover _monster;
    [SerializeField] private Transform _spawner;
    [SerializeField] private Transform _endPoint;

    private float _coolDown = 2.0f;
    private bool _isSpawnerWork = true;

    private void Start()
    {
        StartCoroutine(SpawnDalayRoutine());
    }

    private void OnDisable()
    {
        _isSpawnerWork = false;
        StopCoroutine(SpawnDalayRoutine());
    }

    private IEnumerator SpawnDalayRoutine()
    {
        while (_isSpawnerWork)
        {
            EnemyMover temporaryMonster = Instantiate(_monster, _spawner.position, Quaternion.identity);
            temporaryMonster.SetTarget(_endPoint.position);

            yield return new WaitForSeconds(_coolDown);
        }
    }
}
