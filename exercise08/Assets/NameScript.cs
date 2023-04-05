using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameScript : MonoBehaviour
{
    public string Name;

    public Renderer bodyRend;
    public Color hoverColor;
    public Color selectedColor;
    public Color defaultColor;

    public bool selected = false;

    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        defaultColor = bodyRend.material.color;

        GameObject gmObj = GameObject.Find("GameManagerObject");
        gm = gmObj.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //private void OnMouseEnter()
    //{
    //    if (selected == false)
    //    {
    //        bodyRend.material.color = hoverColor;
    //    }
    //}

    //private void OnMouseExit()
    //{
    //    if (selected == false)
    //    {
    //        bodyRend.material.color = defaultColor;
    //    }
    //}

    private void OnMouseDown()
    {
        if (gm.selectedUnitGun != null)
        {
            // if we're here, something was already selected!
            // 1. Deselect it
           gm.selectedUnitGun.selected = false;
           gm.selectedUnitGun.bodyRend.material.color = gm.selectedUnitGun.defaultColor;
        }
        // 2. Select me!
        selected = true;
        bodyRend.material.color = selectedColor;

        if (gm.selectedUnitGun == null)
        {
            gm.uiPanel.SetTrigger("gun selected");
        }

        gm.selectedUnitGun = this;
        gm.theNameText.text = Name;
    }
}
