using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonkeyKongController : MonoBehaviour
{
    // Start is called before the first frame update
    public float spawnRate = 1f;
    public GameObject barrel1, barrel2, barrel3;
    bool isDead;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn()
    {
        while(!isDead)
        {
            yield return new WaitForSeconds(spawnRate);
            int rd = Random.Range(0, 100);
            if(rd<40)
            {
                GameObject barrel = Instantiate(barrel1, transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
            }
            else if(rd>40 && rd<80)
            {
                GameObject barre2 = Instantiate(barrel2, transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
            }
            else
            {
                GameObject barrel = Instantiate(barrel2, transform.position, Quaternion.identity);
            }
            
        }
    }
}
