using AuctionServerSide.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionServerSide.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Auction> Auctions{ get; set; }
        public List<Bid> Bids { get; set; }
        public int AccountBalance { get; set; }
    }
}
