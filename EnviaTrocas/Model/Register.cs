using System;
using System.Collections.Generic;

namespace EnviaTrocas.Model
{
    public class Register : BaseModel
    {
        public int ProviderId { get; private set; }
        public string Log { get; private set; }
        public Provider Provider { get; set; }
        public List<RegisterItens> RegisterItens { get; set; } = new List<RegisterItens>();
        public Register(int providerId)
        {
            ProviderId = providerId;
        }

        public void UpdateRegister(string log)
        {
            UpdateAt = DateTime.Now;
            Log = log;
        }
    }
}
