using Autofac;
using MarketingBox.Affiliate.Service.Client;
using MarketingBox.Postback.Service.Client;
using MyJetWallet.Sdk.NoSql;

namespace MarketingBox.Postback.Api.Modules
{
    public class ClientModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterPostbackServiceClient(Program.Settings.PostbackServiceUrl);
            var noSqlClient = builder.CreateNoSqlClient(
                Program.ReloadedSettings(e => e.MyNoSqlReaderHostPort).Invoke(),
                Program.LogFactory);
            builder.RegisterAffiliateClient(Program.Settings.AffiliateServiceUrl, noSqlClient);
        }
    }
}
