using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public bool found;
    public GameObject present;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCubeCO());
    }


    private void OnTriggerStay(Collider other)
    {
        found = true;
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
    IEnumerator SpawnCubeCO()
    {
        yield return new WaitForSeconds(1f);
        if (!found)
        {
            Instantiate(present, transform.position, transform.rotation);
        }
    }
}
