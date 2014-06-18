using UnityEngine;
using System.Collections;

public class GateItem : MonoBehaviour {

    public Transform[] m_map;
	public Texture[] texs;

    Transform m_activeChess;
    Transform m_targetGrid;

    void Awake()
    {
        HideFoot();    
    }

    void HideFoot()
    {
        
    }

    void SelectChess(GameObject a_chess)
    {
        //Debug.Log(a_chess.name);
        m_activeChess = a_chess.transform;
        ChessItem ci = m_activeChess.GetComponent<ChessItem>();
        //int grid = ci.grid;

        ArrayList foots = new ArrayList();
        //foreach (int dir in ci.dirs)
        {
            //foots.Add(GridItem.NEAR[grid, dir]);
        }

        foreach (int i in foots)
        {
            if (i != -1)
            {
                m_map[i].GetComponent<GridItem>().ShowFoot();    
            }
        }
    }

    void SelectGrid(GameObject a_grid)
    {
        //Debug.Log(a_grid.name);
        m_targetGrid = a_grid.transform;

        MoveChess();

        HideFoot();
    }

    void MoveChess()
    {
        if (m_targetGrid && m_activeChess)
        {
            ChessItem ci = m_activeChess.GetComponent<ChessItem>();
            GridItem gi = m_targetGrid.GetComponent<GridItem>();
            
            if (ci.ExistGoal(gi.position))
            {
                m_activeChess.localPosition = m_targetGrid.localPosition;
                m_activeChess.localScale = m_targetGrid.localScale;

                ci.position = gi.position;
            }
        }
    }
}
