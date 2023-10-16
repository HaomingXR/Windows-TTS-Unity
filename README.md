# Windows TTS in Unity
A repo that hosts the necessary `.dll` file to implement the Windows built-in Text-to-Speech function, 
with sample scripts provided.

**Note:** `Interop.SpeechLib.dll` alone is enough to run the TTS in the Editor; 
but if the live build crashes, you will also need to include `CustomMarshalers.dll`
