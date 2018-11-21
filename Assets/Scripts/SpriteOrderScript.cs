using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteOrderScript : MonoBehaviour {

    void Update()
    {
        SpriteRenderer[] renderers = FindObjectsOfType<SpriteRenderer>();

        foreach(SpriteRenderer renderer in renderers)
        {
            if (renderer.tag != "Under")
            {
                renderer.sortingOrder = (int)(renderer.transform.position.y * -100);
            }
        }
    }

}
