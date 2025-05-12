using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawnPositions;
    public float shootForce = 500;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bulletClone = Instantiate(bullet, 
                bulletSpawnPositions.position, Quaternion.identity);
            bulletClone.GetComponent<MeshRenderer>().material.color = Color.red;
            bulletClone.GetComponent<Rigidbody>()
                .AddForce(transform.forward * shootForce);
        }
    }
}
