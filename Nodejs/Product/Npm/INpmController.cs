﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.NodejsTools.Npm
{
    public interface INpmController : INpmLogSource
    {
        event EventHandler StartingRefresh;
        void Refresh();
        event EventHandler FinishedRefresh;
        IRootPackage RootPackage { get; }
        IEnumerable< IPackage > GlobalPackages { get; } 
        Task<bool> InstallPackageByVersionAsync(string packageName, string versionRange, DependencyType type);
        Task<bool> UninstallPackageAsync(string packageName);
        Task<bool> UninstallGlobalPackageAsync(string packageName);
        Task< IEnumerable< IPackage > > SearchAsync( string searchText );
        Task< bool > UpdatePackagesAsync();
        Task<bool> UpdatePackagesAsync(IEnumerable<IPackage> packages);
    }
}