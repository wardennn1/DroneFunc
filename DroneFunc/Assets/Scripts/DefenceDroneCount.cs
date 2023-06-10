using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DefenceDroneCount : MonoBehaviour
{
    public AllySpawner allySpawner;
    // public Dropdown m_Dropdown;


    // void Start()
    // {
    //     m_Dropdown.onValueChanged.AddListener (delegate
    //     {
    //         DropdownValueChanged(m_Dropdown);
    //     });
    // }

    // // Update is called once per frame
    // public void DropdownValueChanged (Dropdown change)
    // {
    //     Debug.Log("1" + change.value);
    //     float count = change.value;
    //     allySpawner.spawn(count);
    // }


    public void DropdownHandler(int index){
        switch (index)
        {
            case 0: allySpawner.spawn (3); break;
            case 1: allySpawner.spawn (4); break;
            case 2: allySpawner.spawn (5); break;
            case 3: allySpawner.spawn (6); break;
            default: break;
        }
    }

}
