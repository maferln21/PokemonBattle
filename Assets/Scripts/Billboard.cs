using UnityEngine;

public class Billboard : MonoBehaviour
{
   private Camera gameCamera;
   private void Awake()
    {
        gameCamera = Camera.main;
    }
    private void LateUpdate() 
    {
        transform.LookAt(transform.position + gameCamera.transform.forward);
    }
}
