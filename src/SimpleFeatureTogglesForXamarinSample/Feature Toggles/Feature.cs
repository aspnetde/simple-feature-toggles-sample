namespace SimpleFeatureTogglesForXamarinSample
{
    public static class Feature
    {
        public static bool IsEnabled<T>() where T : IFeature
        {
            return FeatureToggleRegistry.ContainsEnabled<T>();
        }
    }
}

