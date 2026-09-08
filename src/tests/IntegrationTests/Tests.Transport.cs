namespace Instill.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void TransportGuard_RecognizesConnectionReset()
    {
        var exception = new HttpRequestException(
            "The SSL connection could not be established.",
            new IOException(
                "Unable to read data from the transport connection.",
                new System.Net.Sockets.SocketException(
                    (int)System.Net.Sockets.SocketError.ConnectionReset)));

        Assert.IsTrue(IsInstillTransportUnavailable(exception));
    }
}
