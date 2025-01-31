// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/*============================================================
**
**
**
**
**
** Purpose: Specifies which version of a satellite assembly
**          the ResourceManager should ask for.
**
**
===========================================================*/

namespace System.Resources
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed class SatelliteContractVersionAttribute : Attribute
    {
        public SatelliteContractVersionAttribute(string version!!)
        {
            Version = version;
        }

        public string Version { get; }
    }
}
