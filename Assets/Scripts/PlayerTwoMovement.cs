using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        var x = Input.GetAxis("Horizontal") * 2f * Time.deltaTime;
        var y = Input.GetAxis("Vertical") * 2f * Time.deltaTime;
        transform.position += new Vector3(x, y, 0f);
    }
}
