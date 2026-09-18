using Soenneker.LinkedIn.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.LinkedIn.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class LinkedInOpenApiHttpClientTests : HostedUnitTest
{
    private readonly ILinkedInOpenApiHttpClient _httpclient;

    public LinkedInOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<ILinkedInOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
