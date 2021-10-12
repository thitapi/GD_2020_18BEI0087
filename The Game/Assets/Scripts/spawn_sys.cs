
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawn_sys : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public float max_spawn_time;
    public float max_destroy_time;
    private float current_spawn;
    private float current_destroy;
    Vector3 pos;
    Queue<GameObject> pool;
    void Start()
    {
        pos = new Vector3(0,0,0);
        Spawn(prefab,pos);
        pool.Enqueue(prefab);
        current_spawn = max_spawn_time;
        current_destroy = max_destroy_time;
    }
    GameObject Spawn(GameObject obj, Vector3 position)
    {
        GameObject a = Instantiate(obj) as GameObject;
        return a;
    }

    private void Update() {
        
//      Spawning from pool
        if (current_spawn > 0)
        {
            current_spawn -= Time.deltaTime;
        }
        else
        {
            pos = RandomIsed(pool.Peek().transform.position);
            pool.Enqueue(Spawn(prefab,pos));
            current_spawn = max_spawn_time;
        }

//      despawning from pool
        if (current_destroy > 0)
        {
            current_destroy -= Time.deltaTime;
        }
        else
        {
            Destroy(pool.Dequeue());
            current_destroy = max_destroy_time;
        }
    }

    Vector3 RandomIsed(Vector3 pos)
    {
        int rand = (int)Random.Range(1,4);

        if (rand == 1)
            pos.x += 9;
        else if(rand  == 2)
            pos.x -= 9;
        else if (rand == 3)
            pos.z += 9;
        else
            pos.z -= 9;
        
        return pos;
    }

}
