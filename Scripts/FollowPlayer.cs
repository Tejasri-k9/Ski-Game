using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 2, -4);

    void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
