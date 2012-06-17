using global::System;
using global::System.Reflection;
using global::System.Resources;
using global::System.Runtime.InteropServices;
using global::NFG.RGB_HSL_Gamma_Worker.Properties;

[assembly: AssemblyTitle("RGB-HSL-Gamma Worker")]
[assembly: AssemblyDescription("RGB-HSL-Gamma Worker")]
[assembly: AssemblyCompany("Student")]
[assembly: AssemblyProduct("RGB-HSL-Gamma Worker")]
[assembly: AssemblyCopyright("\u00A9 2012 Student. All rights reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyVersion(AssemblyInfo.FullVersion)]
[assembly: AssemblyFileVersion(AssemblyInfo.MainVersion)]
[assembly: AssemblyInformationalVersion(AssemblyInfo.ProductVersion)]
[assembly: Guid("71a924fe-4db5-4ce5-8011-d7a1bb102292")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

namespace NFG.RGB_HSL_Gamma_Worker.Properties
{
  internal static partial class AssemblyInfo
  {
    internal const string Major = "1";
    internal const string Minor = "0";
    internal const string Build = "0";
    internal const string Revision = "0";

    internal const string ProductMajor = Major;
    internal const string ProductMinor = Minor;

    internal const string MainVersion = Major + "." + Minor;
    internal const string FullVersion = MainVersion + "." + Build + "." + Revision;
    internal const string ProductVersion = ProductMajor + "." + ProductMinor;
  }
}
