namespace Rainmeter
{
    public class Version
    {
#if X64
        public const string Informational = "4.3.1.3321 (64-bit)";
#else
        public const string Informational = "4.3.1.3321 (32-bit)";
#endif
    }
}
