using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_1 : MonoBehaviour
{
    public GameObject[] obj = new GameObject[3];
    public Transform target;
    public BoxCollider box;
    public Light _light;
    public Transform[] transforms = new Transform[3];
    public float speed = 5.0f, ratateSpeed = 10f;
    private void Start()
    {
        // obj.SetActive(false);
        // obj.GetComponent<Transform>().position = new Vector3(10, 0, 5);
        // target.position = new Vector3(10, 0, 5);
        // _light.intensity = 0.5f;
        // for (int i = 0; i < obj.Length; i++)
        //     obj[i].SetActive(false);
    }
    private void Update()
    {
        for (int i = 0; i < transforms.Length; i++)
        {
            if (transforms[i] == null)
                continue;

            transforms[i].Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            transforms[i].Rotate(new Vector3(-1, 0, 0) * ratateSpeed * Time.deltaTime);

            float posX = transforms[i].position.x;
            if (posX < -10f && transforms[i].gameObject.name == "Cube")
                Destroy(transforms[i].gameObject);
        }
    }

}
