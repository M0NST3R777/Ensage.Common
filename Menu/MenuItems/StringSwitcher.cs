﻿// <copyright file="StringSwitcher.cs" company="EnsageSharp">
//    Copyright (c) 2017 EnsageSharp.
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see http://www.gnu.org/licenses/
// </copyright>
namespace Ensage.Common.Menu.MenuItems
{
    /// <summary>The string switcher.</summary>
    public class StringSwitcher : MenuItem
    {
        #region Constructors and Destructors

        /// <summary>Initializes a new instance of the <see cref="StringSwitcher" /> class.</summary>
        /// <param name="name">The name.</param>
        /// <param name="displayName">The display name.</param>
        /// <param name="list">The list.</param>
        /// <param name="defaultSelectedIndex">The default selected index.</param>
        /// <param name="makeChampionUniq">The make champion unique.</param>
        public StringSwitcher(
            string name,
            string displayName,
            string[] list,
            int defaultSelectedIndex = 0,
            bool makeChampionUniq = false)
            : base(name, displayName, makeChampionUniq)
        {
            this.SetValue(new StringList(list, defaultSelectedIndex));
        }

        #endregion
    }
}