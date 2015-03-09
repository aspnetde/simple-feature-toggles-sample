using UIKit;

namespace SimpleFeatureTogglesForXamarinSample
{
    public class BlueController : UIViewController, IFeature
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.Blue;
            Title = "Blue";
        }
    }
}

