using System.ServiceProcess;

namespace DSM.Agents.Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (GatewayService service = new GatewayService())
            {
                ServiceBase.Run(service);
            }
        }
    }
}
