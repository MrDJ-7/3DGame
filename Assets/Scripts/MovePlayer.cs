using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5f, hSpeed = 10f, _trust = 500f;
    // void Update()
    // {
    //V1
    // if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
    //     transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed);
    // if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
    //     transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * -speed);

    //V2
    // gameObject.SetActive(false);
    // float v = Input.GetAxis("Vertical");
    // transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * -speed * v);
    // float c = Input.GetAxis("Horizontal");
    // transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * -speed * c);
    // if (Input.GetKey(KeyCode.Q))
    //     transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
    // if (Input.GetKey(KeyCode.E))
    //     transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
    // }

    //Move with fisic v3

    private Rigidbody _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * hSpeed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;

        _rb.velocity = transform.TransformDirection(new Vector3(v, _rb.velocity.y, -h));

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Block")
        {
            _rb.AddForce(new Vector3(0, 1, 0) * _trust);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        // Debug.Log("Col");
    }
    private void OnCollisionExit(Collision other)
    {
        Debug.Log("Col");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TriggerMain")
            Debug.Log("Trigger Corect");
    }
    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "TriggerMain")
            Debug.Log("Stay Corect");

    }
}
