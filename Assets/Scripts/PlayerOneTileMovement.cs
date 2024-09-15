using UnityEngine;

public class PlayerOneTileMovement : MonoBehaviour
{
    private void Movement()
    {
        var x = Input.GetAxis("Horizontal") * 2f * Time.deltaTime;
        transform.position += new Vector3(x, 0f, 0f);
    }

    private void Jump()
    {
        transform.Translate(transform.up * 1.5f * 2f, Space.World);
    }

    void Update()
    {
        Movement();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
}
