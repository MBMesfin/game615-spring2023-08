using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GunController selectedUnit;
    public Animator uiPanel;
    public TMP_Text theName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
        
                if (selectedUnit != null)
                {
                    selectedUnit.selected = false;
                   // selectedUnit.bodyRend.material.color = selectedUnit.defaultColor;

                    selectedUnit = null;

                    uiPanel.SetTrigger("uiPanelOff");
                }
            
        }

    }
}
