using UnityEngine;

public class cameraControl : MonoBehaviour
{

    [SerializeField] private GameObject player;
    Vector3 distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        distance = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + distance;
        Debug.Log("Player: " + player.transform.position);
        Debug.Log("Camera: " + transform.position);

    }
}
