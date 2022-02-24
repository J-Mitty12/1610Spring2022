using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    void Start()

    {
        int x = 35;
        int y = 17;
        if (x > y)
        {
            Console.WriteLine("Hello World");
        }

        {
            int x = 78;
            int y = 45;
            if (x < y)
            {
                Console.WriteLine("Julian");
            }
        }
    }
}
