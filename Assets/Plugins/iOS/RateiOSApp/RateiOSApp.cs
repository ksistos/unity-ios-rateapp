using System.Runtime.InteropServices;

public static class RateiOSApp {
  [DllImport("__Internal")]
  private static extern void dich_rateapp_request();

  public static void RateApp() {
    dich_rateapp_request();
  }
}