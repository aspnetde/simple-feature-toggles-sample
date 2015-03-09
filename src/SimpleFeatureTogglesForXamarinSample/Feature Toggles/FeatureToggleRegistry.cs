using System.Collections.Generic;
using System.Linq;

namespace SimpleFeatureTogglesForXamarinSample
{
    public static class FeatureToggleRegistry
    {
        public static List<object> Features { get; private set; }

        static FeatureToggleRegistry()
        {
            Features = new List<object>();
        }

        public static void Add<T>(bool enabled) where T : IFeature
        {
            Features.Add(new FeatureToggle<T>(enabled));
        }

        public static bool ContainsEnabled<T>() where T : IFeature
        {
            var feature = Features
                .FirstOrDefault(f => f.GetType() == typeof(FeatureToggle<T>)) 
                as FeatureToggle<T>;

            return feature != null && feature.Enabled;
        }
    }
}

