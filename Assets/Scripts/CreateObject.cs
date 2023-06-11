using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using System;

public class CreateObject : MonoBehaviour
{

    public GameObject[] obj;

    private void Update()
    {

        // Invoke("Create", 2f);
        // Create();
        if (Input.GetKeyUp(KeyCode.U))
            StartCoroutine(Create3DObjects(2f));
    }

    private void Create()
    {
        for (int i = 0; i < 5; i++)
        {
            // GameObject newObject = Instantiate(obj, new Vector3(0, 5, 0), Quaternion.Euler(12f, -13f, 32f)) as GameObject;
            // newObject.GetComponent<Transform>().position = new Vector3(5, 5, 0);
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), RandomNumber(), RandomNumber()));

        }
    }

    private int RandomNumber()
    {
        return UnityEngine.Random.Range(0, 10);
    }

    // Coroutines
    // Куратина, куркума
    private IEnumerator Create3DObjects(float wait)
    {
        // yield return new WaitForSeconds(wait);
        // Create();
        // Debug.Log("Start");
        while (true)
        {
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), RandomNumber(), RandomNumber()));
            yield return new WaitForSeconds(wait);
        }
    }

}