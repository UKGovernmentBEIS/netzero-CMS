using OrchardCore.ResourceManagement;

namespace GDSTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineStyle("GDSTheme")
                .SetUrl("~/GDSTheme/css/govuk-frontend-3.11.0.min.css", "~/GDSTheme/css/main.css")
                .SetVersion("1.0.0");
				
        }
    }
}
