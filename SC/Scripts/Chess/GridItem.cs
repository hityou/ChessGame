using UnityEngine;
using System.Collections;

public class GridItem : MonoBehaviour {

    public int[] position;

    void Awake()
    {
        position = new int[2];

        string name = gameObject.name;
        position[0] = int.Parse(name[1].ToString());
        position[1] = int.Parse(name[0].ToString());
        //Debug.Log(position[0]+","+position[1]);
        //HideFoot();
    }
    public void HideFoot()
    {
        gameObject.GetComponent<UISprite>().spriteName = "none";
    }
    public void ShowFoot()
    {
        gameObject.GetComponent<UISprite>().spriteName = "foot";
    }
}
