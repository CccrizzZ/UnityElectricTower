﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableDetection : MonoBehaviour
{

    [SerializeField] Tower TowerController;




    void Start()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 2);
        foreach (var item in hitColliders)
        {
            print(item.name);

            //  add all item with tag cable to tower controller's cable array
            if (item.tag == "Cable")
            {
                TowerController.AllCablesArr.Add(item.GetComponent<CableController>());
            }

        }


    }

}
