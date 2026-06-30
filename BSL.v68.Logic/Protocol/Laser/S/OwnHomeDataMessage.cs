using BSL.v68.TitanEngine.DataS.HelpsLogic;

namespace BSL.v68.Logic.Protocol.Laser.S;

public class OwnHomeDataMessage : PiranhaMessage
{
    public override void Encode()
    {
        base.Encode();
        
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(-1);
        
        // LogicClientHome start
        // LogicDailyData start
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(100000);
        ByteStream.WriteVInt(100000);
        ByteStream.WriteVInt(100000);
        ByteStream.WriteVInt(454);
        ByteStream.WriteVInt(1488);
        ByteStreamHelper.WriteDataReference(ByteStream, 28, 1318);
        ByteStreamHelper.WriteDataReference(ByteStream, 43, 0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(100000);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(1);
        ByteStream.WriteBoolean(true);
        ByteStream.WriteVInt(19500);
        ByteStream.WriteVInt(111111);
        ByteStream.WriteVInt(1375134);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(1375134);
        
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteBoolean(true);
        ByteStream.WriteVInt(2);
        ByteStream.WriteVInt(2);
        ByteStream.WriteVInt(2);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0); // shop offers
        
        ByteStream.WriteVInt(200);
        ByteStream.WriteVInt(-1);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(-1);
        
        ByteStream.WriteByte(1);
        {
            ByteStreamHelper.WriteDataReference(ByteStream, 16, 107);
        }

        ByteStream.WriteString("RU");
        ByteStream.WriteString("BSL.v68");

        ByteStream.WriteVInt(8);
        {
            ByteStream.WriteVLong(new LogicLong(1, 9));
            ByteStream.WriteVLong(new LogicLong(1, 22));
            ByteStream.WriteVLong(new LogicLong(3, 25));
            ByteStream.WriteVLong(new LogicLong(1, 24));
            ByteStream.WriteVLong(new LogicLong(2, 15));
            ByteStream.WriteVLong(new LogicLong(32447, 28));
            ByteStream.WriteVLong(new LogicLong(100, 46));    
            ByteStream.WriteVLong(new LogicLong(1, 52)); 
        }
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(1);
        {
            ByteStream.WriteVInt(52);
            ByteStream.WriteVInt(0);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteVInt(0);

            ByteStream.WriteBoolean(false);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteBoolean(true);
            ByteStream.WriteInt(0);
            ByteStream.WriteInt(0);
            ByteStream.WriteInt(0);
            ByteStream.WriteInt(0);

            ByteStream.WriteBoolean(true);
            ByteStream.WriteInt(0);
            ByteStream.WriteInt(0);
            ByteStream.WriteInt(0);
            ByteStream.WriteInt(0);

            ByteStream.WriteBoolean(false);
            ByteStream.WriteBoolean(true);
            ByteStream.WriteInt(0);
            ByteStream.WriteInt(0);
            ByteStream.WriteInt(0);
            ByteStream.WriteInt(0);

            ByteStreamHelper.WriteDataReference(ByteStream, 0);

            ByteStream.WriteVInt(0);
        }
        
        if (ByteStream.WriteBoolean(true))
        {
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteString(String.Empty);
        }
        
        if (ByteStream.WriteBoolean(true))
            ByteStream.WriteVInt(0);
        
        ByteStream.WriteBoolean(false);

        ByteStream.WriteInt(0);
        ByteStream.WriteVInt(0);
        ByteStreamHelper.WriteDataReference(ByteStream, 16, 0);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteVInt(-1);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);

        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);

        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);

        ByteStreamHelper.WriteDataReference(ByteStream, 2, 0);
        ByteStreamHelper.WriteDataReference(ByteStream, 2, 0);
        ByteStreamHelper.WriteDataReference(ByteStream, 2, 0);
        ByteStreamHelper.WriteDataReference(ByteStream, 2, 0);
        ByteStream.WriteBoolean(false);
        ByteStreamHelper.WriteDataReference(ByteStream, 2, 0);
        ByteStream.WriteVInt(770);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteBoolean(false);
        
        // LogicDailyData end
        
        // LogicConfData start
        
        var es = ByteStream.WriteVInt(38);
        for (var i = 0; i < es; i++)
            ByteStream.WriteVInt(i + 1);

        ByteStream.WriteVInt(1);
        {
            ByteStream.WriteVInt(-1);
            ByteStream.WriteVInt(1);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(85926);
            ByteStream.WriteVInt(5);
            ByteStreamHelper.WriteDataReference(ByteStream, 15, 13);
            ByteStreamHelper.WriteDataReference(ByteStream, 0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteString(null);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteVInt(0);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteVInt(-1);
            ByteStream.WriteBoolean(false);
            ByteStreamHelper.WriteDataReference(ByteStream, 0);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteVInt(-1);
            ByteStream.WriteVInt(-1);
            ByteStream.WriteVInt(-1);
            ByteStream.WriteVInt(-1);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteBoolean(false);
            ByteStream.WriteBoolean(false); 
            ByteStream.WriteBoolean(false); 
            ByteStream.WriteBoolean(false); 
            ByteStream.WriteBoolean(false); 
            ByteStream.WriteBoolean(false);
        }

        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);

        ByteStream.WriteVInt(10);
        foreach (var i in new []{20, 35, 75, 140, 290, 480, 800, 1250, 1875, 2800})
            ByteStream.WriteVInt(i);
        
        ByteStream.WriteVInt(4);
        foreach (var i in new []{30, 80, 170, 360})
            ByteStream.WriteVInt(i);
        
        ByteStream.WriteVInt(4);
        foreach (var i in new []{300, 880, 2040, 4680})
            ByteStream.WriteVInt(i);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(21);
        {
            ByteStream.WriteVLong(new LogicLong(501, 10008));
            ByteStream.WriteVLong(new LogicLong(0, 10046));
            ByteStream.WriteVLong(new LogicLong(30, 10050));
            ByteStream.WriteVLong(new LogicLong(0, 10051));
            ByteStream.WriteVLong(new LogicLong(5600, 10060));
            ByteStream.WriteVLong(new LogicLong(200, 117));
            ByteStream.WriteVLong(new LogicLong(1, 128));
            ByteStream.WriteVLong(new LogicLong(0, 65));
            ByteStream.WriteVLong(new LogicLong(41000000 + 174, 1));
            ByteStream.WriteVLong(new LogicLong(99999999, 131));
            ByteStream.WriteVLong(new LogicLong(100000, 138));
            ByteStream.WriteVLong(new LogicLong(1, 95));
            ByteStream.WriteVLong(new LogicLong(55598, 47));
            ByteStream.WriteVLong(new LogicLong(1, 123));
            ByteStream.WriteVLong(new LogicLong(200, 124));
            ByteStream.WriteVLong(new LogicLong(55598, 48));
            ByteStream.WriteVLong(new LogicLong(3, 50));
            ByteStream.WriteVLong(new LogicLong(500, 1100));
            ByteStream.WriteVLong(new LogicLong(500, 1101));
            ByteStream.WriteVLong(new LogicLong(1, 1002));
            ByteStream.WriteVLong(new LogicLong(500, 1102));
        }

        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);

        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(6);
        foreach (var i in new []{0, 29, 79, 169, 349, 699})
            ByteStream.WriteVInt(i);
        
        ByteStream.WriteVInt(6);
        foreach (var i in new []{0, 160, 450, 500, 1250, 2500})
            ByteStream.WriteVInt(i);
        
        ByteStream.WriteVInt(5);
        foreach (var i in new []{0, 100, 400, 1000, 3000})
            ByteStream.WriteVInt(i);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(0);
        
        // LogicConfData end

        new LogicLong(0, 1).Encode(ByteStream);
        
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteVInt(-1);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);

        ByteStream.WriteBoolean(false);

        ByteStream.WriteBoolean(false);

        ByteStream.WriteBoolean(false);

        ByteStream.WriteBoolean(false);
        
        ByteStream.WriteVInt(0);

        ByteStream.WriteBoolean(true); 
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(1);
        {
            ByteStreamHelper.WriteDataReference(ByteStream, 16, 108);
            ByteStream.WriteVInt(1900);
            ByteStream.WriteVInt(349);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(0);
        }
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);

        ByteStream.WriteVInt(0);

        ByteStreamHelper.WriteDataReference(ByteStream, 0);
        ByteStreamHelper.WriteDataReference(ByteStream, 0);
        ByteStreamHelper.WriteDataReference(ByteStream, 0);
        ByteStreamHelper.WriteDataReference(ByteStream, 0);
        ByteStreamHelper.WriteDataReference(ByteStream, 0);
        ByteStreamHelper.WriteDataReference(ByteStream, 0);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteBoolean(false);

        ByteStream.WriteVInt(0);

        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteInt(-1488);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(51998);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        
        ByteStream.WriteBoolean(false);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteVInt(2);
        ByteStreamHelper.WriteDataReference(ByteStream, 95, 0);
        ByteStream.WriteVInt(1);
        ByteStreamHelper.WriteDataReference(ByteStream, 95, 1);
        ByteStream.WriteVInt(1);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteBoolean(false);
        ByteStream.WriteBoolean(false);
        
        // LogicClientHome end
        
        // LogicClientAvatar start
        
        ByteStreamHelper.EncodeLogicLong(ByteStream, 1);
        ByteStreamHelper.EncodeLogicLong(ByteStream, 1);
        ByteStreamHelper.EncodeLogicLong(ByteStream, 0);

        ByteStream.WriteStringReference("LkPrtctrd");
        ByteStream.WriteBoolean(true);
        ByteStream.WriteInt(-1);
        
        ByteStream.WriteVInt(35);
        {
            ByteStream.WriteVInt(0);
            ByteStream.WriteVInt(1);
            {
                ByteStreamHelper.WriteDataReference(ByteStream, 23, 0);
                ByteStream.WriteVInt(-1);
                ByteStream.WriteVInt(1);
            }

            for (var x = 0; x < 34; x++)
            {
                ByteStream.WriteVInt(0);
                ByteStream.WriteVInt(0);
            }
        }
        
        ByteStream.WriteVInt(1337);
        ByteStream.WriteVInt(1337);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(100);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(2);
        ByteStream.WriteVInt(1);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteString(null);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(0);
        ByteStream.WriteVInt(2);
        ByteStream.WriteVInt(0);
        ByteStream.WriteBoolean(false);
    }

    public override int GetMessageType()
    {
        return 24101;
    }

    public override int GetServiceNodeType()
    {
        return 9;
    }
}