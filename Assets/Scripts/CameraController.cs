using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    PlayerController player;

    bool isFollowing;

    public float xOffset;
    public float yOffset;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        isFollowing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
            transform.position = new Vector3(player.transform.position.x + xOffset,
                                              yOffset,
                                              player.transform.position.z - 1);
    }
}
