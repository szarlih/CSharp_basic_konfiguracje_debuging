

namespace _1_konfiguracje_debuging
{
    using _1_konfiguracje_debuging.Interfaces;
    using System;

    public class OtherFlow : StandardFlow, ISelfIntroduction, IDisposable
    {
        public OtherFlow()
        {
            _name = "Other";
        }

        public int Grade => 1;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
