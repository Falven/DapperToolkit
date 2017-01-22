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
using System.Windows.Input;

namespace DapperToolkitSamples.Models
{
    public class Sample
    {
        public Sample(string header, string description, ICommand navigationCommand)
        {
            if(string.IsNullOrWhiteSpace(header))
                throw new ArgumentException(nameof(header));
            if(string.IsNullOrWhiteSpace(description))
                throw new ArgumentException(nameof(description));
            if(null == navigationCommand)
                throw new ArgumentNullException(nameof(navigationCommand));

            Header = header;
            Description = description;
            NavigationCommand = navigationCommand;
        }

        public ICommand NavigationCommand { get; private set; }
        public string Header { get; private set; }
        public string Description { get; private set; }
    }
}