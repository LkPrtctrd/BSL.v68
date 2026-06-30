using BSL.v68.Core;
namespace BSL.v68;

public static class Program
{
    public static void Main(string[] args)
    {
        new LaserTcpCentralGateway(9339).Start();

        for (;;) ;
    }
}