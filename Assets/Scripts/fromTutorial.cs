using UnityEngine;

public class fromTutorial : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void Start()
    {
        Debug.Log("Start");
    }
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    private void Update()
    {
        Debug.Log("Update");
    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
    private void OnDestroy()
    {

    }

}
