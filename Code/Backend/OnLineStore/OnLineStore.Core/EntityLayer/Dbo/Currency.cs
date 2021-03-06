﻿using System;

namespace OnLineStore.Core.EntityLayer.Dbo
{
    public class Currency : IAuditableEntity
    {
        public Currency()
        {
        }

        public short? CurrencyID { get; set; }

        public string CurrencyName { get; set; }

        public string CurrencySymbol { get; set; }

        public string CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public string LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public byte[] Timestamp { get; set; }
    }
}
