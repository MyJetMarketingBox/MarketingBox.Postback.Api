using Autofac;
using MarketingBox.Postback.Service.Client;

namespace MarketingBox.Postback.Api.Modules
{
    public class ClientModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterPostbackServiceClient(Program.Settings.PostbackServiceUrl);
        }
    }
}
