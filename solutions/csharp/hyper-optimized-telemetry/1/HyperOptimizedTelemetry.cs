public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading) {
        byte[] temp = new byte[9];

        // Get prefix value
        byte prefixValue;
        switch(reading) {
            // UShort
            case >= 0 and <= ushort.MaxValue:
                prefixValue = 2;
                temp = BitConverter.GetBytes((ushort)reading);
                break;
                
            // Short
            case >= short.MinValue and <= short.MaxValue:
                prefixValue = 256 - 2;
                temp = BitConverter.GetBytes((short)reading);
                break;

            // Int
            case >= int.MinValue and <= int.MaxValue:
                prefixValue = 256 - 4;
                temp = BitConverter.GetBytes((int)reading);
                break;

            // UInt
            case >= 0 and <= uint.MaxValue:
                prefixValue = 4;
                temp = BitConverter.GetBytes((uint)reading);
                break;

            default: 
                prefixValue = 256 - 8;
                temp = BitConverter.GetBytes(reading);
                break;
        }

        byte[] buffer = new byte[9];

        // Set prefix value
        buffer[0] = prefixValue;
        temp.CopyTo(buffer, 1);

        return buffer;
    }
    
    public static long FromBuffer(byte[] buffer) {
        // Check prefix value
        switch(buffer[0]) {
            // ushort
            case 2:
                return BitConverter.ToUInt16(buffer, 1);

            // uint
            case 4:
                return BitConverter.ToUInt32(buffer, 1);

            // short
            case 256 - 2:
                return BitConverter.ToInt16(buffer, 1);

            // int
            case 256 - 4:
                return BitConverter.ToInt32(buffer, 1);

            // long
            case 256 - 8:
                return BitConverter.ToInt64(buffer, 1);

            // invalid
            default:
                return 0;
        }
    }
}
