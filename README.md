# Latest Release

[10.1.2](https://github.com/oqtane/oqtane.theme.corporate/releases/tag/v10.1.2) was released on Mar 25, 2026.

# Oqtane.Theme.Corporate

A clean and modern responsive theme based on Bootstrap 5.3.8. This theme supports both static and interactive render modes and can help you create a professional looking website for your business in no time. It also includes professionally styled content so you can include sections for Clients, About Us, Why Us, Skills, Services, Call To Action, Portfolio, Team, Pricing, Testimonials, and FAQs.

![Oqtane Theme Corporate](https://github.com/user-attachments/assets/dcb08657-43a5-4caa-932e-f8590ebeab6a)

This theme can be installed directly from the [Oqtane Marketplace](https://www.oqtane.net/) into your Oqtane installation by navigating to Theme Management in the Admin Dashboard and selecting Install Theme.

This theme includes Theme Settings which can be accessed in the Edit Page UI. The Theme Settings allow you to include a hero banner, footer section, etc...

![image](https://github.com/user-attachments/assets/0f86e427-3c88-407d-93d3-866110733e75)

This theme also includes Content Modules which can be injected into a page to provide a variety of professionally styled sections such as Clients, About Us, Why Us, Skills, Services, Call To Action, Portfolio, Team, Pricing, Testimonials, and FAQs.

![image](https://github.com/user-attachments/assets/a7f1f61a-f049-4e99-ad5d-f8a9aec8daf6)

## NuGet Package / Application Template Support

This theme can also be consumed as a NuGet package reference (e.g. from an Oqtane application template or custom host project) without going through the Oqtane admin installer. The following changes were made to support this scenario:

- **Static assets embedded & delivered via MSBuild targets** — `wwwroot/` assets are included in the `.nupkg` under `wwwroot/`. A `build/Oqtane.Theme.Corporate.targets` file is included in the package and auto-imported by NuGet, which copies `wwwroot/Themes/Oqtane.Theme.Corporate/**` into the consuming project's `wwwroot/` at build time. No changes are required in the consuming project.

- **Static web asset manifest suppressed** — `<StaticWebAssetsEnabled>false</StaticWebAssetsEnabled>` is set in the Client project so the Razor SDK does not embed a static web asset manifest in the DLL. This prevents conflicts between the SDK's asset pipeline and the `.targets` copy mechanism when the package is consumed.

- **SDK-style project cleanup** — The `Package\release.cmd` script and `Oqtane.Theme.Corporate.nuspec` were updated to correctly resolve `nuget.exe` and produce a clean package containing only the DLL, PDB, `wwwroot/` assets, the MSBuild `.targets` file, and the package icon.




