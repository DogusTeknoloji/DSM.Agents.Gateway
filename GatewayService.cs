using System;

namespace DSM.Agents.Gateway
{
    public class GatewayService : DSMAgent
    {
        public GatewayService() : base("DSMGatewayService", bypassAuth: true) { }

        public override void ActionMain(object authObj)
        {
            try
            {

                GC.TryStartNoGCRegion(1024 ^ 3 * 8);
                GatewayEngine.Gateway gateway = new DSM.GatewayEngine.Gateway();
                GC.EndNoGCRegion();
                GC.KeepAlive(gateway);
                GC.SuppressFinalize(gateway);
                loggingSvc.Write($"Gateway ref -> {gateway?.ToString()}");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                loggingSvc.Write(ex.Message);
            }
        }
    }
}
