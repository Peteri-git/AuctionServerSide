using AuctionServerSide.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionServerSide.Data
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public Category ParentCategory { get; set; }
        public List<Auction> Auctions { get; set; }
    }
    public class Auction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public ApplicationUser Author { get; set; }
        public List<Bid> bids { get; set; }
        public Category category { get; set; }
        public string description { get; set; }
        public int startingPrice { get; set; }
        public byte[] photo { get; set; }
        public string address { get; set; }
        public int publicationPrice { get; set; }
        public int publicationDaysCount { get; set; }
        public DateTime publicationDate { get; set; }
        public DateTime endDate { get; set; }
        public TimeSpan RemainigTime { get; set; }
        public string TypeOfBid { get; set; }
        public int minimalBid { get; set; }
    }
    public class Bid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public Auction auction { get; set; }
        public ApplicationUser user { get; set; }
        public int currentPrice { get; set; }
        public int bidAmount { get; set; }
        public DateTime bidDate { get; set; }

    }
}
