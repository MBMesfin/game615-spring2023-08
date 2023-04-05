using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public NameScript selectedUnitGun;
    public Animator uiPanel;
    public TMP_Text theNameText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray) == false)
            {
                if (selectedUnitGun != null)
                {
                    selectedUnitGun.selected = false;
                    selectedUnitGun.bodyRend.material.color = selectedUnitGun.defaultColor;

                    selectedUnitGun = null;

                    uiPanel.SetTrigger("gun selected");
                }
            }
        }

    }
}
