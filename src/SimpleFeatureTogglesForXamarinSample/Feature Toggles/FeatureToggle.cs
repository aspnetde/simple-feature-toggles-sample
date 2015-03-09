namespace SimpleFeatureTogglesForXamarinSample
{
    public class FeatureToggle<T> where T : IFeature
    {
        public bool Enabled { get; private set; }

        public FeatureToggle(bool enabled)
        {
            Enabled = enabled;
        }
    }
}

