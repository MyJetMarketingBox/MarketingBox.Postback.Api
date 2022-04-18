using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace MarketingBox.Postback.Api.Settings
{
    public class SettingsModel
    {
        [YamlProperty("PostbackApi.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }

        [YamlProperty("PostbackApi.ZipkinUrl")]
        public string ZipkinUrl { get; set; }

        [YamlProperty("PostbackApi.ElkLogs")]
        public LogElkSettings ElkLogs { get; set; }

        [YamlProperty("PostbackApi.PostbackServiceUrl")]
        public string PostbackServiceUrl { get; set; }
    }
}
