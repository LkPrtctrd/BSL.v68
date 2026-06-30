using BSL.v68.TitanEngine.NaCl;

namespace BSL.v68.TitanEngine.Pepp.Crypto;

public static class PepperKey
{
    static PepperKey()
    {
        ClientSecretKey = Convert.FromHexString("36abd74b2db5faa4d5a7977a1bc8be137ad7330efc934dfba36600ecd6871476");

        ServerPublicKey = Convert.FromHexString("46cb575cd747a84045647b8f59473ffafbcd302093c73fd5f8233d779bea886b");
    }

    public static byte[] ClientSecretKey { get; }
    public static byte[] ServerPublicKey { get; }
}