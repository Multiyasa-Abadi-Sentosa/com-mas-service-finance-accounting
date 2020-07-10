﻿using System;

namespace Com.Danliris.Service.Finance.Accounting.Lib.BusinessLogic.VbWIthPORequest
{
    public class VbRequestWIthPOList
    {
        public int Id { get; set; }
        public string VBNo { get; set; }
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset DateEstimate { get; set; }
        public string UnitLoad { get; set; }
        public int UnitId { get; set; }
        public string UnitCode { get; set; }
        public decimal Amount { get; set; }
        public string UnitName { get; set; }
        public string CreateBy { get; set; }
        public bool Approve_Status { get; set; }
        public bool Complete_Status { get; set; }
        public string VBRequestCategory { get; set; }
        public object PONo { get; set; }
    }
}