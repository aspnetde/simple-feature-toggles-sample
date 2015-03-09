using UIKit;

namespace SimpleFeatureTogglesForXamarinSample
{
    public class RedController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Red;
            Title = "Red is the new Blue";
        }
    }
}

