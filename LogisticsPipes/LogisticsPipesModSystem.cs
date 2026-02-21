using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

[assembly: ModInfo("LogisticsPipes", "logisticspipes")]
namespace LogisticsPipes
{
    public class LogisticsPipesModSystem : ModSystem
    {
        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            Mod.Logger.Notification("Hello from logisticspipes: " + api.Side);
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            Mod.Logger.Notification("Hello from logisticspipes server side: " + Lang.Get("logisticspipes:hello"));
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            Mod.Logger.Notification("Hello from logisticspipes client side: " + Lang.Get("logisticspipes:hello"));
        }
    }
}
