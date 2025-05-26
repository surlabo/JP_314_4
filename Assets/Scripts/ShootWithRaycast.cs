using UnityEngine;

public class ShootWithRaycast : MonoBehaviour
{
    [SerializeField] private float raycastLength;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, raycastLength))
            {
                
            }
        }
        Debug.DrawRay(transform.position, transform.forward * raycastLength, Color.red);
    }
}


public class Human
{
    public int age;
}