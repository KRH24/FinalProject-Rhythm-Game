using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject Arrows;
    public Transform SpawnPoint;
    
    // Update is called once per frame
    void Update()
    {

            Spawner();
            
    }

    void Spawner()
    {
        
        GameObject newplayer = Instantiate(Arrows, SpawnPoint.position, Quaternion.identity);

    }
}
