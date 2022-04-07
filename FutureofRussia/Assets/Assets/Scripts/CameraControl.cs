using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 positio;
    private void Update()
    {
        positio = player.position;
        positio.z = -10f;
        transform.position = Vector3.Lerp(transform.position, positio, Time.deltaTime);
    }
}
