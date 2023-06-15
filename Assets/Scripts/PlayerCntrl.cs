using UnityEngine;
using UnityEngine.UI;
public class PlayerCntrl : MonoBehaviour
{
    public float speed = 5f;//, hSpeed = 10f, _trust = 500f;

    private Rigidbody _rb;

    public Text scoreText;

    private int _score = 0;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // _rb.velocity = transform.TransformDirection(new Vector3(h, _rb.velocity.y, v)) * speed * Time.fixedDeltaTime;

        _rb.AddForce(new Vector3(h, _rb.velocity.y, v) * speed * Time.fixedDeltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collective Cube")
        {
            _score++;
            Destroy(other.gameObject);
            if (_score != 5)
                scoreText.text = "Score: " + _score;
            else
                scoreText.text = "You Win!";
        }
    }


}
