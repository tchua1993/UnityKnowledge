﻿using UnityEngine;
using System.Collections;

public class InputDetector : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, 10);
            KnapsackManager.Instance.StoreItem(index);
        }
    }
}
