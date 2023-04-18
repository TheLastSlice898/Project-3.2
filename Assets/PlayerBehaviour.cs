using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(EventBus.current.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            EventBus.current.LightGoOffTrigger();
        }

        if (Input.GetKeyUp("space")){
            EventBus.current.LightGoOnTrigger();
        }
    }
}
