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

using DapperToolkitSamples.Models;
using DapperToolkitSamples.ViewModels.Contracts;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Mvvm.Interfaces;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DapperToolkitSamples.ViewModels
{
    public class MainPageViewModel : ViewModel, IMainPageViewModel
    {
        #region Services
        private readonly ISessionStateService _sessionStateService;
        private INavigationService _navigationService;
        #endregion

        public MainPageViewModel(ISessionStateService sessionStateService, INavigationService navigationService)
        {
            _sessionStateService = sessionStateService;
            _navigationService = navigationService;
            _samples = new ObservableCollection<Sample>
            {
                new Sample("Scroll Events", "Scroll Events", new DelegateCommand(() =>
                {
                    try
                    {
                        _navigationService.Navigate("ScrollEventSample", null);
                    }
                    catch (System.Exception e)
                    {
		                throw;
                    }
                }))
            };
        }

        #region Properties
        private ObservableCollection<Sample> _samples;
        public ObservableCollection<Sample> Samples
        {
            get { return _samples; }
            set { SetProperty(ref _samples, value); }
        }
        #endregion

        #region Commands
        #endregion
    }
}
