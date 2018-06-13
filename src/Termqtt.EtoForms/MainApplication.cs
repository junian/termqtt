using System;
using System.Collections.Generic;
using System.Reflection;
using Eto;
using Eto.Forms;
using Juniansoft.MvvmReady;
using Juniansoft.Termqtt.Core;
using Juniansoft.Termqtt.Core.Engines.Networks;
using Juniansoft.Termqtt.Core.Engines.Scripts;
using Juniansoft.Termqtt.Core.Services;
using Juniansoft.Termqtt.Core.ViewModels;
using Juniansoft.Termqtt.EtoForms.Forms;
using Juniansoft.Termqtt.EtoForms.Services;
using Juniansoft.Termqtt.EtoForms.Views;
using Mono.Options;

namespace Juniansoft.Termqtt.EtoForms
{
    public class MainApplication: Application, ITermqttApp
    {
        public static TrayIndicator TrayIndicator { get; internal set; }

        public MainApplication(Platform platform)
            : base(platform)
        {
            RegisterServices();
        }

        public void Run(string[] args)
        {
            // these variables will be set when the command line is parsed
            var verbosity = 0;
            var shouldShowHelp = false;

            // these are the available options, not that they set the variables
            var options = new OptionSet {
                { 
                    "v", "increase debug message verbosity", v => {
                    if (v != null)
                        ++verbosity;
                    } 
                },
                {
                    "h|help", "show this message and exit", h => shouldShowHelp = h != null
                },
                // default
                { "<>", v =>
                    {
                        //shouldShowHelp = true;
                        //Console.WriteLine("Unknown command parameter.");
                    }
                },
            };

            var extra = default(List<string>);
            try
            {
                // parse the command line
                extra = options.Parse(args);
            }
            catch (OptionException e)
            {
                // output some error message
                Console.Write("termqtt: ");
                Console.WriteLine(e.Message);
                Console.WriteLine("Try `termqtt --help' for more information.");
                return;
            }

            if (shouldShowHelp)
            {
                // show some app description message
                Console.WriteLine("Usage: termqtt.exe [OPTIONS]");
                Console.WriteLine("Cross-platform Serial/TCP terminal.");
                Console.WriteLine();

                // output the options
                Console.WriteLine("Options:");
                options.WriteOptionDescriptions(Console.Out);
                return;
            }

            this.Run(new MainForm());
        }

        public void RegisterServices()
        {
            // Register all Services here
            ServiceLocator.Current.Register<ICrossDialog, CrossDialog>();
            if(Platform.Supports<Notification>())
                ServiceLocator.Current.Register<INotificationService, NotificationService>();
            else
                ServiceLocator.Current.Register<INotificationService, CrossDialog>();
            ServiceLocator.Current.Register<IJavaScriptBotEngine, JSJintScriptEngine>();
            ServiceLocator.Current.Register<INetworkEngine, TermSharpEngine>();
            ServiceLocator.Current.Register<ISystemService, EtoSystemService>();
            ServiceLocator.Current.Register<IFileService, FileService>();
            ServiceLocator.Current.Register<IJsonService, LitJsonService>();

            if (Platform.Instance.IsWinForms || Platform.IsWpf)
                ServiceLocator.Current.Register<ICSharpBotEngine, CSharpCodeDomScriptEngine>();

            // Register all ViewModels here.
            ServiceLocator.Current.Register<MainViewModel>();
            ServiceLocator.Current.Register<DeviceBotViewModel>();
            ServiceLocator.Current.Register<PreferencesViewModel>();
            ServiceLocator.Current.Register<HelpViewModel>();

            // Register all Views here
            ServiceLocator.Current.Register<MainView>();
            ServiceLocator.Current.Register<DeviceBotView>();
            ServiceLocator.Current.Register<PreferencesView>();
        }
    }
}
