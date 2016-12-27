// Guids.cs
// MUST match guids.h
using System;

namespace Eski.AboutBoxPackage
{
    static class GuidList
    {
        public const string guidAboutBoxPackagePkgString = "8048ef35-f084-499a-9cb5-d125b8be3176";
        public const string guidAboutBoxPackageCmdSetString = "2f979de4-2e0c-4f83-b9d3-c5243eea4907";

        public static readonly Guid guidAboutBoxPackageCmdSet = new Guid(guidAboutBoxPackageCmdSetString);
    };
}