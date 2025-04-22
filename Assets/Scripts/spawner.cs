using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
   public GameObject prefab;
   public float spwanSpeed = 1f;
   public float minHeight = -1f;
   public float maxHeight = 1f;
   private float timer = 0f;

//    private void onEnable(){
//         InvokeRepeating(nameof(Spawn),spwanSpeed,spwanSpeed);
//    }

//     private void onDisable(){
//         CancelInvoke(nameof(Spawn));
//     }
    private void Update()
        {
            timer += Time.deltaTime;
            if (timer >= spwanSpeed)
            {
                Spawn();
                timer = 0f;  
            }
        }
    

    private void Spawn(){
        GameObject pipes = Instantiate(prefab,transform.position,Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight,maxHeight);
   }

    
}

