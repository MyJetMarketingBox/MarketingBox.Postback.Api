using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace MarketingBox.Postback.Api.Settings
{
    public class SettingsModel
    {
        [YamlProperty("ExternalReferenceProxyApi.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }

        [YamlProperty("ExternalReferenceProxyApi.ZipkinUrl")]
        public string ZipkinUrl { get; set; }

        [YamlProperty("ExternalReferenceProxyApi.ElkLogs")]
        public LogElkSettings ElkLogs { get; set; }

        [YamlProperty("ExternalReferenceProxyApi.PostbackServiceUrl")]
        public string PostbackServiceUrl { get; set; }
    }
}
