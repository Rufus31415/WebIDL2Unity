using System.Runtime.InteropServices;

public static class NativeJS
{
    [DllImport("__Internal")]
    private static extern int GetNavigatorID();

    public static Navigator Navigator
    {
        get
        {
            return new Navigator(GetNavigatorID());
        }
    }

}
