using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetQualityMenu : MonoBehaviour
{
    public Dropdown DropdownMenu;

    void Start()
    {
        AddQualityOptionsToMenu();
        SelectCurrentQuality();
    }

    void Update()
    {
        
    }

    void AddQualityOptionsToMenu() 
    {
        List<string> names = new List<string>();
        int i = 0;
        while (i< QualitySettings.names.Length) 
        {
            names.Add(QualitySettings.names[i]);
            i++;
        }
        DropdownMenu.AddOptions(names);
    }

    void SelectCurrentQuality() 
    {
        DropdownMenu.value = QualitySettings.GetQualityLevel();
    }

    //OnClick method for button
    public void ButtonApplyChanges() 
    {
        QualitySettings.SetQualityLevel(DropdownMenu.value);
    }
}
