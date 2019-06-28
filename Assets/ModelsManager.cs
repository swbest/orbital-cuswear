using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsManager : MonoBehaviour
{
    public GameObject[] Models;

    // Start is called before the first frame update
    void Start()
    {
        //Disable All models at start
        DisableAll();
        
    }

    void DisableAll()
    {
        foreach (var item in Models)
        {
            item.SetActive(false);
        }
    }

    void SetModel(int index)
    {
        //Disable all other models before enabling a model
        DisableAll();
        Models[index].SetActive(true);
    }
  
  
}
