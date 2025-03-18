using System;

namespace GakuMute {
  enum SettingOwner {
    Foreground,
    Background
  }

  class GMVolumeSettingsEventArgs: EventArgs {
    public SettingOwner SettingOwner;

    /// <summary>
    /// -1 means Use Current volume
    /// </summary>
    public short Volume;
  }
}
