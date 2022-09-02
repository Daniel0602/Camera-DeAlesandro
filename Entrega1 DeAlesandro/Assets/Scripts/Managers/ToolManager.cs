using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolManager : MonoBehaviour
{
    //-----Array-----
    [SerializeField] GameObject[] Tools;
    [SerializeField] RawImage[] ToolIcons;

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            disalbeTools();
            Tools[0].SetActive(true);
            EnableIcon(0);
        }
        if (Input.GetKeyDown("2"))
        {
            disalbeTools();
            Tools[1].SetActive(true);
            EnableIcon(1);
        }
        if (Input.GetKeyDown("3"))
        {
            disalbeTools();
            Tools[2].SetActive(true);
            EnableIcon(2);
        }
    }

    void disalbeTools()
    {
        for (int i = 0; i < Tools.Length; i++)
        {
            Tools[i].SetActive(false);
            ToolIcons[i].color = Color.black;
        }
    }

    void EnableIcon(int Icon)
    {
        ToolIcons[Icon].color = Color.white;
    }










    //-----List-----
    [SerializeField] List<GameObject> ToolList;

    public List<GameObject> ToolList1 { get => ToolList; set => ToolList = value; }

    void enableAllTools()
    {
        foreach (GameObject Tool in ToolList)
        {
            Tool.SetActive(true);
        }
    }

    //-----Dictionary-----
    [SerializeField] private Dictionary<string, GameObject> ToolDirectory;
    public Dictionary<string, GameObject> ToolDirectory1 { get => ToolDirectory; set => ToolDirectory = value; }

    void Start()
    {ToolDirectory = new Dictionary<string,GameObject>();}
}
