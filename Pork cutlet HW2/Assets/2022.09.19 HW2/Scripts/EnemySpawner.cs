using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemy;
    [SerializeField]
    private int _enemyNumber;
    public int EnemyNumber { get; set; }
    [SerializeField]
    private int X;
    [SerializeField]
    private int Y;

    public List<Vector3> enemyList = new List<Vector3>();
    public List<Vector3> EnemyList { get { return enemyList; } }
    
    public List<GameObject> enemyColorList = new List<GameObject>();
    public List<GameObject> EnemyColorList { get { return enemyColorList; } }

    
    private void Start()
    {
        Initialize(_enemyNumber);
    }

    private void Initialize(int Spawnnumber)
    {
        for (int i = 0; i < Spawnnumber; ++i)
        {
            float randomX = Random.Range(-100f, 100f);
            float randomY = Random.Range(-100f, 100f);
            Vector3 position = new Vector3(randomX, 1, randomY);
            EnemyList.Add(position);
            Quaternion rotate = Quaternion.identity;
            EnemyColorList.Add(Instantiate(_enemy, position, rotate));
        }
    }
}
