using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject originalGameobject;
    public Transform spawnPosition;
    public Transform parentTransform;
    void Start()
    {
        GameObject cloneGameobject = Instantiate(
            originalGameobject, 
            spawnPosition.position, 
            Quaternion.identity);
    }

    

    
}
