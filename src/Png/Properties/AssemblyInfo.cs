using global::System;
using global::System.Reflection;
using global::System.Resources;
using global::System.Runtime.InteropServices;
using global::NFG.Png.Properties;

[assembly: AssemblyTitle("NFG.Png")]
[assembly: AssemblyDescription("NFG.Png")]
[assembly: AssemblyCompany("Student")]
[assembly: AssemblyProduct("NFG.Png")]
[assembly: AssemblyCopyright("\u00A9 2012 Student. All rights reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyVersion(AssemblyInfo.FullVersion)]
[assembly: AssemblyFileVersion(AssemblyInfo.MainVersion)]
[assembly: AssemblyInformationalVersion(AssemblyInfo.ProductVersion)]
[assembly: Guid("21b52971-0675-40c9-999c-dcf8cea9902d")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

namespace NFG.Png.Properties
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
