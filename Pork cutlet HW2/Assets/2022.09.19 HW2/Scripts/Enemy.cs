using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Material _material;

    private bool isindex;
    // Start is called before the first frame update
    void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        ClosePlayer();
    }

    private void ClosePlayer()
    {
        float distance = Vector3.Distance(GameManager.Instance.PlayerPosition.position, transform.position);



        if (distance <= 5.0f && isindex == false)
        {
            Debug.Log("asdsa");
            isindex = true;
            //GameManager.Instance.EnemyIndex.Add(gameObject, distance);
            StartCoroutine(Routine(distance));
        }
        else if (distance <= 5.0f && isindex == true)
        {
            GameManager.Instance.EnemyIndex[gameObject] = distance;
        }
        else if (distance > 5.0f)
        {
            _material.color = Color.white;
            isindex = false;
            //GameManager.Instance.CloseEnemy.Remove(gameObject);
            GameManager.Instance.EnemyIndex.Remove(gameObject);
        }
    }

    IEnumerator Routine(float distance)
    {
        GameManager.Instance.EnemyIndex.Add(gameObject, distance);
        yield return new WaitForEndOfFrame();
        GameManager.Instance.EnemyIndex.Remove(gameObject);
    }
}
