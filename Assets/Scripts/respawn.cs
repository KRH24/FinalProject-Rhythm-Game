using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject Arrows;
    public Transform SpawnPoint;

    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer >= 5f)
        {
            Spawner();
            timer = 0f;
            
        }

    }

    void Spawner()
    {

        GameObject newplayer = Instantiate(Arrows, SpawnPoint.position, Quaternion.identity);

    }

   
}
