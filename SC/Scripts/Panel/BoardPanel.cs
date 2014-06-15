using UnityEngine;
using System.Collections;

public class BoardPanel : MonoBehaviour
{
    public Transform[] Row;

    private GameObject m_chess;
    void SelectChess(GameObject a_chess)
    {
        m_chess = a_chess;
    }

    private GameObject m_grid;
    void SelectGrid(GameObject a_grid)
    {
        m_grid = a_grid;

        MoveChess();
    }

    public bool MoveChess()
    {
        bool empty = m_grid.transform.FindChild("Chess") == null;
        if (empty)
        {
            m_chess.transform.parent = m_grid.transform;
            m_chess.transform.localPosition = new Vector3(0, 0, 0);
            m_chess.transform.localScale = new Vector3(1, 1, 1);
        }
        return empty;
    }
}
