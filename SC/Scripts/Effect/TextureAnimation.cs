using UnityEngine;
using System.Collections;

public class TextureAnimation : MonoBehaviour {

	Texture[] m_texs;
	int frame = 0;
	// Use this for initialization
	void Start () {
		m_texs = Resources.LoadAll<Texture>("Effect/Top");
		Debug.Log(m_texs.Length);
		NextTexture();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void NextTexture()
	{
		frame++;
		if (frame >= m_texs.Length)
		{
			frame = 0;
		}
		gameObject.GetComponent<UITexture>().mainTexture = m_texs[frame];

		Invoke("NextTexture", 0.5F);
	}
}
