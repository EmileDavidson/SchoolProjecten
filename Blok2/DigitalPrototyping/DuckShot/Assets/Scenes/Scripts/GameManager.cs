using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text ronde;
    public int r;
    public Text score;
    public int s;

    public GameObject birdPrefab;
    public int removedChickens;
    public int clickedRemovedChickens;
    public int EscapedRemovedChickens;

    private int i;
    private int rCounter;

    public GameObject Dog;

    public Boolean waiting = false;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(instantiate());
    }

    public IEnumerator instantiate()
    {
        i++;
        yield return new WaitForSeconds(1);
        GameObject birdobj = Instantiate(birdPrefab);
        birdobj.transform.position = new Vector3(-90 + UnityEngine.Random.Range(0, 100), -65, 0);

        if (i == 3)
        {
            i = 0;
        }
        else
        {
            StartCoroutine(instantiate());
        }
    }

    private IEnumerator end()
    {
        yield return new WaitForSeconds(10);
        waiting = false;
    }

    private IEnumerator dogWaiting()
    {
        removedChickens = 0;
        clickedRemovedChickens = 0;
        EscapedRemovedChickens = 0;
        rCounter++;
        if (clickedRemovedChickens == 3)
        {
            s += 10000;
            updatescore();
        }
        yield return new WaitForSeconds(3.2f);
        StartCoroutine(instantiate());
    }

    // Update is called once per frame
    private void Update()
    {
        if (waiting == true) { return; }
        removedChickens = clickedRemovedChickens + EscapedRemovedChickens;
        if (removedChickens == 3)
        {
            GameObject dogObj = Instantiate(Dog);
            dogObj.transform.position = new Vector3(-50 + UnityEngine.Random.Range(0, 195), 20, 0);
            Destroy(dogObj, 3.2f);
            StartCoroutine(dogWaiting());
        }

        if (rCounter == 2)
        {
            r++;
            rCounter = 0;
            updatescore();
        }
    }

    public void addScore(int value)
    {
        s += value;
        updatescore();
    }

    public void updatescore()
    {
        ronde.text = r.ToString("0");
        score.text = s.ToString("0");
    }
}