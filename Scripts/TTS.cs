using UnityEngine;
using SpeechLib;

public class TTS : MonoBehaviour
{
	[SerializeField]
	[TextArea]
	private string content;

	void Start()
	{
		SpVoice voice = new SpVoice();
		voice.Speak(content);
	}
}