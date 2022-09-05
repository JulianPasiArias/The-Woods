
using UnityEngine;

public class ParallaxEfect : MonoBehaviour
{
    [SerializeField] private float parallaxMultiplier;
    
    private Transform cameraTransform;
    private Vector3 previousCameraPosition;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        previousCameraPosition = cameraTransform.position;
    }

    
    void LateUpdate()
    {
        float deltaX = (cameraTransform.position.x - previousCameraPosition.x) * parallaxMultiplier;
        transform.Translate(new Vector3(deltaX, 0,0));
        previousCameraPosition = cameraTransform.position;
    }
}
