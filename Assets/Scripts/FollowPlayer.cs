using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -10);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //! offset camera by adding to the player's position
        transform.position = player.transform.position + offset;
    }

    }
