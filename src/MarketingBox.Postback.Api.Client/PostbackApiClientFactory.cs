using JetBrains.Annotations;
using MyJetWallet.Sdk.Grpc;

namespace MarketingBox.Postback.Api.Client
{
    [UsedImplicitly]
    public class PostbackApiClientFactory: MyGrpcClientFactory
    {
        public PostbackApiClientFactory(string grpcServiceUrl) : base(grpcServiceUrl)
        {
        }
    }
}
