using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AutoResizeGridElements : MonoBehaviour
{
        
    Canvas canvas;
    GridLayoutGroup gridLayout;

    // Start is called before the first frame update
    void Start()
    {
        canvas = this.GetComponentInParent<Canvas>();
        gridLayout = this.GetComponent<GridLayoutGroup>();
         
    }

    // Update is called once per frame
    void Update()
    {
        float cellX = canvas.pixelRect.width * 0.25f;
        float cellY = canvas.pixelRect.height * 0.65271f / 2;
        gridLayout.cellSize = new Vector2(cellX, cellY);
         
    }
}
