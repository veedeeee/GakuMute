using System.Windows.Forms;

namespace GakuMute.Model {
  class GMRegistoryManager {
    private static GMRegistoryManager _singletonInstance = new GMRegistoryManager();
    public static GMRegistoryManager SharedManager() {
      return _singletonInstance;
    }

    public bool isEnableAutoLaunch {
      get {
        return Properties.Settings.Default.IsLaunchGakuMuteWhenWindowsHasBooted;
      }
      set {
        Properties.Settings.Default.IsLaunchGakuMuteWhenWindowsHasBooted = value;
        Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
        if(value) {
          regkey.SetValue(Application.ProductName, Application.ExecutablePath);
        } else {
          regkey.DeleteValue(Application.ProductName, false);
        }
        regkey.Close();
      }
    }

    /// <summary>
    /// Turn off the auto-launch once, then Turn it on again.
    /// This method will repair executable path if user has moved GakuMute to other directory.
    /// </summary>
    public void RefreshRegistoryValueForAutoLaunch() {
      if(!Properties.Settings.Default.IsLaunchGakuMuteWhenWindowsHasBooted) { return; }
      this.isEnableAutoLaunch = false;
      this.isEnableAutoLaunch = true;
    }
  }
}
