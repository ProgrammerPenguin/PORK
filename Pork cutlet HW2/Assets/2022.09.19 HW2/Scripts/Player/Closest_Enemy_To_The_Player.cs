using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closest_Enemy_To_The_Player : MonoBehaviour
{
    public EnemySpawner EnemySpawner;

    
    private void Update()
    {
        SearchClosetEnemy();
    }

    private void SearchClosetEnemy()
    {
        for (int i = 0; i < 5000; ++i)
        {
            Debug.Log("Çó¤©·Î");
            Vector3 enemyposition = EnemySpawner.EnemyList[i];
            float distance = Vector3.Distance(transform.position, enemyposition);
            
            Debug.Log($"{distance}");
            if (distance < 5)
            {
                Material color = EnemySpawner.EnemyColorList[i].GetComponent<MeshRenderer>().material;
                Color red = Color.red;
                color.color = red;
                Debug.Log("µé¾î¿È");
            }

        }
    }

    //private void Circle()
    //{
    //    float distance = Vector3.Distance(transform.position,
    //}
}
