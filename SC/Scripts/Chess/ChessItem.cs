using UnityEngine;
using System.Collections;

public class ChessItem : MonoBehaviour {

    public Transform[] m_arrow;
    public int[] dirs;
    public int[] step;

    public string start;
    public int[] position;

    int[] XMover;
    int[] YMover;

    void Awake()
    {
        position = new int[2];
        position[0] = int.Parse(start[1].ToString());
        position[1] = int.Parse(start[0].ToString());

        XMover = new int[] { -1,0,1,-1,0,1,-1,0,1};
        YMover = new int[] { -1,-1,-1,0,0,0,1,1,1};

        foreach (Transform t in m_arrow)
        {
            t.gameObject.SetActive(false);
        }

        LoadArrow(dirs);
    }

    void LoadArrow(int[] a_dirs)
    {
        int element = 0;
        foreach (int i in a_dirs)
        {
            element = i;
            if (m_arrow[element])
            {
                m_arrow[element].gameObject.SetActive(true);
            }
        }
    }

    public bool ExistGoal(int[] a_position)
    {
        foreach (int i in dirs)
        {
            foreach (int speed in step)
            {
                if (a_position[0] == XMover[i] * speed + position[0] &&
                a_position[1] == YMover[i] * speed + position[1])
                {
                    return true;
                }    
            }
        }
        return false;
    }
}
