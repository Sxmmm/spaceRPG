using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SpriteOrderScript : MonoBehaviour {

    void Update()
    {
        SpriteRenderer[] renderers = FindObjectsOfType<SpriteRenderer>();

        TilemapRenderer[] tilerenderes = FindObjectsOfType<TilemapRenderer>();

     
        foreach(SpriteRenderer renderer in renderers)
        {
            if (renderer.tag != "Under")
            {
                renderer.sortingOrder = (int)(renderer.transform.position.y * -100);
            }
        }
        foreach (TilemapRenderer renderer in tilerenderes)
        {
            if (renderer.tag == "Under")
            {
                renderer.sortingOrder = -5000;
            }
        }
    }

}
