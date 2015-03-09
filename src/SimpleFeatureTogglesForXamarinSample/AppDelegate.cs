using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace SimpleFeatureTogglesForXamarinSample
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow _window;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            _window = new UIWindow(UIScreen.MainScreen.Bounds);
            _window.RootViewController = new UINavigationController(new StartController());
            _window.MakeKeyAndVisible();

            RegisterFeatures();
			
            return true;
        }

        private void RegisterFeatures()
        {
            FeatureToggleRegistry.Add<BlueController>(enabled: false);
        }
    }
}

