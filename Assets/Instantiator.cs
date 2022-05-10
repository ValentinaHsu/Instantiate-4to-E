using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int CloneAmount;

    public void MultiInstantiate()
    {
        int counter = 0;
        while (counter < CloneAmount)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
