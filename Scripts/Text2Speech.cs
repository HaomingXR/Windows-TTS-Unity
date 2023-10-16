using SpeechLib;

public static class Text2Speech
{
	private static SpVoice voice = null;
	public static void Speech(string content)
	{
		if (voice == null)
			voice = new SpVoice();

		voice.Speak(content);
	}
}
