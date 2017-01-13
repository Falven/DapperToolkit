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

using System.Collections.ObjectModel;
using DapperToolkitSamples.Models;
using DapperToolkitSamples.ViewModels.Contracts;
using Microsoft.Practices.Prism.Mvvm;

namespace DapperToolkitSamples.ViewModels.Mock
{
    public class MainPageMockViewModel : ViewModel, IMainPageViewModel
    {
        #region Services
        #endregion

        public MainPageMockViewModel()
        {
            Samples = new ObservableCollection<Sample>
            {
                new Sample("Lorem ipsum dolor sit amet", "consectetur adipiscing elit. Vestibulum non aliquam nisi."),
                new Sample("Lorem ipsum dolor sit amet", "consectetur adipiscing elit. Vestibulum non aliquam nisi."),
                new Sample("Lorem ipsum dolor sit amet", "consectetur adipiscing elit. Vestibulum non aliquam nisi."),
                new Sample("Lorem ipsum dolor sit amet", "consectetur adipiscing elit. Vestibulum non aliquam nisi."),
                new Sample("Lorem ipsum dolor sit amet", "consectetur adipiscing elit. Vestibulum non aliquam nisi."),
                new Sample("Lorem ipsum dolor sit amet", "consectetur adipiscing elit. Vestibulum non aliquam nisi."),
                new Sample("Lorem ipsum dolor sit amet", "consectetur adipiscing elit. Vestibulum non aliquam nisi."),
                new Sample("Lorem ipsum dolor sit amet", "consectetur adipiscing elit. Vestibulum non aliquam nisi."),
                new Sample("Lorem ipsum dolor sit amet", "consectetur adipiscing elit. Vestibulum non aliquam nisi."),
                new Sample("Lorem ipsum dolor sit amet", "consectetur adipiscing elit. Vestibulum non aliquam nisi."),
                new Sample("Lorem ipsum dolor sit amet", "consectetur adipiscing elit. Vestibulum non aliquam nisi.")
            };
        }

        #region Properties
        public ObservableCollection<Sample> Samples { get; }
        #endregion
    }
}
