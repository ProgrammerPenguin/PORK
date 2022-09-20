using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;
            }
            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }

        else if (_instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public Transform PlayerPosition;

    public Dictionary<GameObject, float> EnemyIndex = new Dictionary<GameObject, float>();

    public List<float> CloseEnemy = new List<float>();

    private float closeEnemy = 10f;

    private GameObject Closeene;

    private GameObject EXCloseene;

    private GameObject EEXCloseene;

    public float time;

    public bool isMoving;

    private void Update()
    {
        //FindCloseEnemy();
        time += Time.deltaTime;
        if (time > 1f)
        {
            FindCloseEnemy();
        }

        //Invoke("asdas", 3f);
        //StartCoroutine(abc());
    }
    private void FindCloseEnemy()
    {
        foreach (KeyValuePair<GameObject, float> item in EnemyIndex)
        {
            if (item.Value < closeEnemy)
            {
                closeEnemy = item.Value;
                Closeene = item.Key;
                Debug.Log($"qweqw");
            }
        }
        Debug.Log($"{closeEnemy}");
        closeEnemy = 10f;
        Material color = Closeene.GetComponent<MeshRenderer>().material;
        color.color = Color.red;


        foreach (KeyValuePair<GameObject, float> item in EnemyIndex)
        {
            EEXCloseene = item.Key;
            if (Closeene == EXCloseene)
            {
                color.color = Color.red;
            }
            else
            {
                Material material = EEXCloseene.GetComponent<MeshRenderer>().material;
                material.color = Color.white;
            }
        }

        EXCloseene = Closeene;
    }

    //void asdas()
    //{
    //    Debug.Log($"{CloseEnemy[0]}");
    //}
    //IEnumerator abc()
    //{
    //    while(true)
    //    {
    //        foreach (float Value in EnemyIndex.Values)
    //        {
    //            CloseEnemy.Add(Value);
    //        }
    //        CloseEnemy.Sort();
    //        //yield return new WaitForEndOfFrame();
    //        yield return new WaitForSeconds(1f);
    //        CloseEnemy.Clear();
    //    }

    //}
}
