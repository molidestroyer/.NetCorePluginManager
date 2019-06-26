﻿/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 *  .Net Core Plugin Manager is distributed under the GNU General Public License version 3 and  
 *  is also available under alternative licenses negotiated directly with Simon Carter.  
 *  If you obtained Service Manager under the GPL, then the GPL applies to all loadable 
 *  Service Manager modules used on your system as well. The GPL (version 3) is 
 *  available at https://opensource.org/licenses/GPL-3.0
 *
 *  This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 *  without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 *  See the GNU General Public License for more details.
 *
 *  The Original Code was created by Simon Carter (s1cart3r@gmail.com)
 *
 *  Copyright (c) 2018 - 2019 Simon Carter.  All Rights Reserved.
 *
 *  Product:  AspNetCore.PluginManager
 *  
 *  File: FileVersionComparison.cs
 *
 *  Purpose:  
 *
 *  Date        Name                Reason
 *  28/09/2018  Simon Carter        Initially Created
 *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace AspNetCore.PluginManager
{
    internal sealed class FileVersionComparison : Comparer<FileInfo>
    {
        public override int Compare(FileInfo x, FileInfo y)
        {
            FileVersionInfo versionX = FileVersionInfo.GetVersionInfo(x.FullName);
            FileVersionInfo versionY = FileVersionInfo.GetVersionInfo(y.FullName);

            return versionX.FileVersion.CompareTo(versionY.FileVersion);
        }

        public bool Equals(FileInfo x, FileInfo y)
        {
            return Compare(x, y) == 0;
        }

        public bool Newer(FileInfo x, FileInfo y)
        {
            return Compare(x, y) == 1;
        }
    }
}
