using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting3 : MonoBehaviour
{
    public GameObject shootPrefab;
    public float initialDelay = 1f; // Initial delay before the first shot
    public float shootInterval = 12f; // Interval between each shot in seconds

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShootRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     IEnumerator ShootRoutine()
    {
        // Wait for the initial delay before starting to shoot
        yield return new WaitForSeconds(initialDelay);

        // Shoot continuously
        while (true)
        {
            // Instantiate the shootPrefab
            Instantiate(shootPrefab, transform.position, Quaternion.identity);
            
            // Wait for the specified interval before shooting again
            yield return new WaitForSeconds(shootInterval);
        }
    }
}
