using System.IO;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

#if UNITY_IOS
using UnityEditor.iOS.Xcode;
#endif

public class PostProcessBuild : MonoBehaviour {
#if UNITY_IOS
  [PostProcessBuild]
  public static void OnPostprocessBuild_SetupiOSProject(BuildTarget buildTarget, string path) {
    var projPath = path + "/Unity-iPhone.xcodeproj/project.pbxproj";

    var proj = new PBXProject();
    proj.ReadFromString(File.ReadAllText(projPath));

    var target = proj.TargetGuidByName("Unity-iPhone");

    proj.AddFrameworkToProject(target, "StoreKit.framework", true);

    File.WriteAllText(projPath, proj.WriteToString());
  }
#endif
}