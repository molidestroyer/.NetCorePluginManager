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
 *  Product:  UserAccount.Plugin
 *  
 *  File: CreateLicenceViewModel.cs
 *
 *  Purpose:  Create licence view model
 *
 *  Date        Name                Reason
 *  06/01/2019  Simon Carter        Initially Created
 *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using SharedPluginFeatures;

namespace UserAccount.Plugin.Models
{
    public sealed class CreateLicenceViewModel : BaseModel
    {
        #region Constructors

        public CreateLicenceViewModel()
        {

        }

        public CreateLicenceViewModel(in List<BreadcrumbItem> breadcrumbs, in ShoppingCartSummary cartSummary)
            : base (breadcrumbs, cartSummary)
        {

        }

        #endregion Constructors

        #region Properties

        [Display(Name = nameof(Languages.LanguageStrings.LicenceType))]
        public int LicenceType { get; set; }

        #endregion Properties
    }
}
