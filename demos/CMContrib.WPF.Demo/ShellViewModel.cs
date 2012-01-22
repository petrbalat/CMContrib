using System;
using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro;
using Caliburn.Micro.Contrib.Demo;
using Caliburn.Micro.Contrib.Demo.ViewModels;

namespace Caliburn.Micro.Contrib.Demo
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Screen, IShell
    {
        public ShellView View { get { return GetView() as ShellView; } }
        public IObservableCollection<string> LogItems { get; private set; }
        public IObservableCollection<IDemo> Demos { get; set; }

        public void Log(string message)
        {
            LogItems.Insert(0, string.Format("{0}: \t{1}", DateTime.Now.ToLongTimeString(), message));
        }

        public void ClearLog()
        {
            LogItems.Clear();
        }

        public ShellViewModel()
        {
            DisplayName = "CMContrib WPF Demo";
            Demos = new BindableCollection<IDemo>(IoC.GetAllInstances(typeof(IDemo)).Cast<IDemo>());

            LogItems = new BindableCollection<string>();
        }
    }
}