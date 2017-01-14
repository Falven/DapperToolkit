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

using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Mvvm.Interfaces;

namespace DapperToolkitSamples.ViewModels
{
    public class ScrollEventSamplePageViewModel : ViewModel
    {
        private ISessionStateService _sessionState;
        private INavigationService _navigationService;

        public ScrollEventSamplePageViewModel(ISessionStateService sessionState, INavigationService navigationService)
        {
            _sessionState = sessionState;
            _navigationService = navigationService;
        }
    }
}
