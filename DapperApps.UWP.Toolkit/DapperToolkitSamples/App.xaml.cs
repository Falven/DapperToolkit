using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Prism.Mvvm;
using Microsoft.Practices.Unity;

namespace DapperToolkitSamples
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Override this method with logic that will be performed after the application is initialized. For example, navigating to the application's home page.
        /// Note: This is called whenever the app is launched normally (start menu, taskbar, etc.) but not when resuming.
        /// </summary>
        /// <param name="args">The <see cref="T:Windows.ApplicationModel.Activation.LaunchActivatedEventArgs" /> instance containing the event data.</param>
        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            // Navigate to the initial page
            NavigationService.Navigate("Main", null);

            return Task.CompletedTask;
        }

        /// <summary>
        /// Override this method with the initialization logic of your application. Here you can initialize services, repositories, and so on.
        /// </summary>
        /// <param name="args">The <see cref="T:Windows.ApplicationModel.Activation.IActivatedEventArgs" /> instance containing the event data.</param>
        protected override Task OnInitializeAsync(IActivatedEventArgs args)
        {
            // Register MvvmAppBase services
            Container.RegisterInstance(NavigationService);
            Container.RegisterInstance(SessionStateService);

            // Register app-specific services

            // Set a factory for the ViewModelLocator to use the container to construct view models so their 
            // dependencies get injected by the container
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(
                viewType =>
                {
                    var viewModelTypeName =
                        $"DapperToolkitSamples.ViewModels.{viewType.Name}ViewModel, DapperToolkitSamples.UILogic, Version=1.0.0.0, Culture=neutral";
                    var viewModelTypeNameType = Type.GetType(viewModelTypeName);
                    return viewModelTypeNameType;
                });
            return base.OnInitializeAsync(args);
        }
    }
}
