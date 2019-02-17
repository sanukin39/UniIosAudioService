using System.Runtime.InteropServices;

public class UniIosAudioService
{
    [DllImport("__Internal")]
    private static extern void audioServicePlaySystemSound(int soundId);
    
    public static void PlaySystemSound(int soundId)
    {
#if !UNITY_EDITOR && UNITY_IOS
        audioServicePlaySystemSound(soundId);
#endif
    } 
}
