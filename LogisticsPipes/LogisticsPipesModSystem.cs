using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

[assembly: ModInfo("LogisticsPipes", "logistics_pipes",
                    Authors = new string[] { "ThermalCube" },
                    Description = "LogisticsPipes is a mod for Vintage Story that adds structured item logistics and transport mechanics.",
                    Version = "0.1.0")]

namespace LogisticsPipes
{
    public class LogisticsPipesModSystem : ModSystem
    {
        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            Mod.Logger.Notification("Hello from logistics_pipes: " + api.Side);
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            Mod.Logger.Notification("Hello from logistics_pipes server side: " + Lang.Get("logistics_pipes:hello"));
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            Mod.Logger.Notification("Hello from logistics_pipes client side: " + Lang.Get("logistics_pipes:hello"));
        }
    }
}
