﻿using System.Reflection;
using XamlAnimatedGif.Properties;

[assembly: AssemblyVersion(VersionInfo.Version)]
[assembly: AssemblyFileVersion(VersionInfo.Version)]
[assembly: AssemblyInformationalVersion(VersionInfo.Version + VersionInfo.PreRelease)]

namespace XamlAnimatedGif.Properties
{
    class VersionInfo
    {
        public const string Version = "1.1.1.0";
        public const string PreRelease = "";
    }
}
