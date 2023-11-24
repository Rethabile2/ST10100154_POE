using System;
using System.Collections.Generic;

#nullable disable

namespace ST1010015_POE.Models
{
    public partial class AllocationOfGood
    {
        public Guid AllocationId { get; set; }
        public DateTime DateOfAllocation { get; set; }
        public int NumberOfItemsAllocated { get; set; }
        public Guid DonationOfGoodsCategoryId { get; set; }
        public Guid DisasterId { get; set; }

        public virtual ActiveDisaster Disaster { get; set; }
        public virtual DonationOfGoodsCategory DonationOfGoodsCategory { get; set; }
    }
}
