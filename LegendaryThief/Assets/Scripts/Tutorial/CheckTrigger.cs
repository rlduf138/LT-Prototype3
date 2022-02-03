﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
      public Tutorial tutorial;

      public void OnTriggerEnter2D(Collider2D collision)
      {
            if (collision.tag == "Player")
            {
                  tutorial.NextScene();
            }
      }
}
