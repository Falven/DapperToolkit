/*
 * Copyright (c) Dapper Apps.  All rights reserved.
 * Use of this sample source code is subject to the terms of the Dapper Apps license 
 * agreement under which you licensed this sample source code and is provided AS-IS.
 * If you did not accept the terms of the license agreement, you are not authorized 
 * to use this sample source code.  For the terms of the license, please see the 
 * license agreement between you and Dapper Apps.
 *
 * To see the article about this app, visit http://www.dapper-apps.com/DapperToolkit
 */

using System;
using System.Collections.Generic;

namespace DapperToolkitSamples.Extensions
{
    public static class RandomEx
    {
        /// <summary>
        /// Return a random item from a list.
        /// </summary>
        /// <typeparam name="T">The item type.</typeparam>
        /// <param name="rnd">The Random instance.</param>
        /// <param name="list">The list to choose from.</param>
        /// <returns>A randomly selected item from the list.</returns>
        public static T Next<T>(this Random rnd, IList<T> list)
        {
            return list[rnd.Next(list.Count)];
        }
    }
}