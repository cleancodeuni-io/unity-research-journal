using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We will move the behicle forward
        transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime *20);
    }
}
