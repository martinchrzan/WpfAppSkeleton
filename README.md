# WpfAppSkeleton
Ready made skeleton of a WPF app with everything you need to start developing with no external dependencies.

This skeleton app is build by using MVVM pattern - Model - View - ViewModel, read more about it [here](https://docs.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern).

This skeleton app is using dependency injection (MEF) that helps you to keep your code organized, simplify testing and it follows SOLID principles. To learn more about MEF, please check out this excelent [introduction article](https://www.codeproject.com/articles/188054/an-introduction-to-managed-extensibility-framework). 
Please note, there are many other dependency injection frameworks such as [Windsor](http://www.castleproject.org/projects/windsor/), [Autofac](https://autofac.org/) and others. I choose MEF, because it is already build into .NET framework and therefore it does not require any additional dependencies. However, this usually comes down to people's preferences as they all provide similar features.

### Structure of the project

* **Behaviors** - contains all behaviors - this can be logic that you need to add into your view, but it is easier to define it by a code behind rather than defining it in view's XAML. Each behavior targets some type of control, that you can attach it to. It manipulates that control's properties directly, without polluting view's code behind. This keeps all controls' behavior separated and can be reused.

* **Common** - contains all classes, that are used throughout the project.

* **Helpers** - contains any useful classes, that does not really belong anywhere else :)

* **Resources** - contains ResourceDictionaries to define colors, styles, etc. Home of any images, icons or any binary files.

* **ViewModelContracts** - contains interfaces which define functionality of view models.

* **ViewModels** - contains implementation of view models.

* **Views** - contains views.

### Points of interest
*Resources/ViewModelViewMappings.xaml* - contains relationship between view and view models - it defines which view model is displayed as what view when using a binding.

*App.xaml* file defines global resources - it tells the app to use ViewModelViewMappings defined above in the whole application. It can also define to use styles from provided resource dictionary to be applied globally.

*MainWindow.xaml.cs* - This is the only view with a code-behind, as it serves as an entry point, for compositing classes (resolving needed dependencies and creating classes using MEF).

*Helpers/Logger.cs* - **Remember to update your application name here, before using it!**


