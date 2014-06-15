using UnityEngine;

public class HeadItem : MonoBehaviour
{
	public Transform m_spell;

	void Awake()
	{
		CastSpelled();

		UIEventListener.Get(gameObject).onClick = CastSpell;	
	}	

    void CastSpell(GameObject a_g)
    {
    	m_spell.gameObject.SetActive(true);
    	m_spell.GetComponent<TweenPosition>().PlayForward();
    }

    public void CastSpelled()
    {
    	m_spell.gameObject.SetActive(false);
    	m_spell.GetComponent<TweenPosition>().ResetToBeginning();
    }
}