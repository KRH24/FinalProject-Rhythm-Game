using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour
{
    public GameObject Arrow;
    public Transform SpawnPoint;
    public float minWaitTime = 1f;
    public float maxWaitTime = 4f;
    //private int totalArrow = 4;
    private float timer;
    // Update is called once per frame
    void Start()
    {

        StartCoroutine(Spawner());

   }

    IEnumerator Spawner()
    {
        while (true)
        {
            float respawnTime = Random.Range(minWaitTime, maxWaitTime);
            yield return new WaitForSeconds(respawnTime);

            Instantiate(Arrow, SpawnPoint.position, Quaternion.identity);
        }

    }



}
