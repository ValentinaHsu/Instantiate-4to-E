using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int CloneAmount;
    public Text txtCloneAmount;

    GameObject clon;
    public void MultiInstantiate()
    {
        CloneAmount = int.Parse(txtCloneAmount.text);

        for (int i = 0; i < CloneAmount; i++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon, 1);
        }
            
        
    }
}
