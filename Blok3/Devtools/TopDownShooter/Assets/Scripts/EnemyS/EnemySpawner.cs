using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemyParent;
    public Transform[] spawnPoints;

    // Update is called once per frame
    private void Start()
    {
        spawnPoints = new Transform[this.transform.childCount];
        for (int i = 0; i < this.transform.childCount; i++)
        {
            spawnPoints[i] = this.transform.GetChild(i);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            spawn();
        }
    }

    public void spawn()
    {
        GameObject enemyObj = Instantiate(enemy);
        //enemyObj.transform.position = this.transform.position;
        int number = Random.Range(0, this.transform.childCount);
        Debug.Log(number);
        enemyObj.transform.position = spawnPoints[number].transform.position;
        enemyObj.transform.parent = enemyParent.parent;
    }
}