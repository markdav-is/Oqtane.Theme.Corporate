using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Module.Corporate.Countdown
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Corporate Theme - Countdown",
            Description = "Add a Countdown section to your Corporate Theme",
            Version = "10.1.2",
            PackageName = "Oqtane.Theme.Corporate"
        };
    }
}
