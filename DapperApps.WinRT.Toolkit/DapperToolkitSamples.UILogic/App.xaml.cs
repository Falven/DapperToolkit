﻿/*
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
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Microsoft.Practices.Unity;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=391641
namespace DapperToolkitSamples
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App
    {
        private readonly IUnityContainer _container;

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();

            _container = new UnityContainer();
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate("Main", null);
            return Task.FromResult<object>(null);
        }

        protected override Task OnInitializeAsync(IActivatedEventArgs args)
        {
            // Register MvvmAppBase services
            _container.RegisterInstance(SessionStateService);
            _container.RegisterInstance(NavigationService);

            // Register app-specific services

            // Set a factory for the ViewModelLocator to use the container to construct view models so their 
            // dependencies get injected by the container
            ViewModelLocationProvider.SetDefaultViewModelFactory(
                viewModelType => _container.Resolve(viewModelType));
            return Task.FromResult<object>(null);
        }
    }
}