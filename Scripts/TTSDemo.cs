using UnityEngine;

public class TTSDemo : MonoBehaviour
{
    [SerializeField]
    [TextArea]
    private string content;

    void Start()
    {
        Text2Speech.Speech(content);
    }
}
