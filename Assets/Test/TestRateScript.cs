using UnityEngine;

public class TestRateScript : MonoBehaviour {
  private void OnGUI() {
    if (GUI.Button(new Rect(100, 100, 100, 100), "Rate App"))
      RateiOSApp.RateApp();
  }
}