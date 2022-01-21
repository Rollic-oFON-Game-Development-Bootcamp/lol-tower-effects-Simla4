using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMovement : MonoBehaviour
{
    [SerializeField] private GameObject explosion;
    [SerializeField] private LolTower lolTower;
    
    private Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        lolTower.enemyPos += destination;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoveFireball()
    {
        var fireballPos = transform.position;
        transform.position = Vector3.Lerp(fireballPos, destination, 3f);
    }
}
