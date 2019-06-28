using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public GameObject ModelsManager;
    public Sprite[] SelectedSprites;
    public Sprite[] NormalSprites;
    public Sprite[] CardSprites;
    public Image[] SliderImages;
    public Image InformationCard;
    public GameObject InformationIcon;
    public GameObject InformationPanel;



    // Start is called before the first frame update
    void Start()
    {

        DeselectAll();
        ToggleInformationIcon(false);
        InformationPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectModel(int index)
    {
        ModelsManager.SendMessage("SetModel",index);
        DeselectAll();
        SliderImages[index].sprite = SelectedSprites[index];
       if (index != 3)
        {
            InformationCard.sprite = CardSprites[index];
            ToggleInformationIcon(true);
        } else
        {
            ToggleInformationIcon(false);
        }
   
    }

    public void HideInformation()
    {
        InformationPanel.SetActive(false);
    }

    public void ShowInformation()
    {
        InformationPanel.SetActive(true);
   

    }

    void DeselectAll()
    {
        for ( int i = 0; i < SliderImages.Length; i++)
        {
            SliderImages[i].sprite = NormalSprites[i];
        }
        ToggleInformationIcon(false);

    }

    void ToggleInformationIcon(bool state)
    {
        InformationIcon.SetActive(state);
    }
}
