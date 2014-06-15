using UnityEngine;
using System.Collections;
public class Network : MonoBehaviour
{
	string url = "http://localhost/php/protocol.php";
	void Start()
	{
		
	}

	Queue m_packet = new Queue();
	void SendRequest()
	{
		m_packet.Enqueue(transform.FindChild("Send").GetComponent<UILabel>().text);

		StartCoroutine(ProcessProtocol());
	}

	IEnumerator ProcessProtocol()
	{
		if (m_packet.Count > 0)
		{
			string money = m_packet.Dequeue() as string;

			WWWForm form = new WWWForm();
			form.AddField("money", money);
			WWW www = new WWW(url, form);

			yield return www;

			if (www.error != null)
			{
				Debug.Log(www.error);
			}

			transform.FindChild("Recv").GetComponent<UILabel>().text = www.text;
		}
	}
}