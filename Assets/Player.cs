using UnityEngine;
using UnityEngine.Playables;

public class Player : MonoBehaviour
{
    public PlayableDirector director;
    public Animator anim;
    public float speed = 5f;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (director.state == PlayState.Playing) return;
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction += Camera.main.transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction -= Camera.main.transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Camera.main.transform.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction -= Camera.main.transform.right;
        }

        // Ignore vertical camera tilt for movement
        direction.y = 0;

        if (direction != Vector3.zero)
        {
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
            transform.LookAt(transform.position + direction);
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
    }
}
