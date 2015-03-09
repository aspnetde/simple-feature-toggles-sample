using System;
using UIKit;

namespace SimpleFeatureTogglesForXamarinSample
{
    public class StartController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;
            Title = "Simple Feature Toggles";

            AddStartButton();
        }

        private void AddStartButton()
        {
            var button = new UIButton(UIButtonType.Custom);

            button.SetTitle("Start", UIControlState.Normal);
            button.SetTitleColor(UIColor.Black, UIControlState.Normal);
            button.SizeToFit();

            CenterButton(button);

            // Don't forget to detach that event in real world scenarios!
            button.TouchDown += (object sender, EventArgs e) => 
            {
                UIViewController startController;

                if (Feature.IsEnabled<BlueController>())
                    startController = new BlueController();
                else
                    startController = new RedController();

                NavigationController.PushViewController(startController, true);
            };

            Add(button);
        }

        private void CenterButton(UIButton button)
        {
            button.Frame = new CoreGraphics.CGRect(
                View.Bounds.Width / 2 - button.Frame.Width / 2,
                View.Bounds.Height / 2 - button.Frame.Height / 2,
                button.Frame.Width,
                button.Frame.Height
            );
        }
    }
}

