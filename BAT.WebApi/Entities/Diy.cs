using System;
namespace BAT.WebApi.Entities
{
    public class Diy
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsMale { get; set; }
        public bool IsOnWhatsApp { get; set; }
        public bool IsOnTelegram { get; set; }
        public DateTime Dob { get; set; }
        public string Location { get; set; }
        public string PreferredBrand { get; set; }
        public string AlternativeBrand { get; set; }
        public string BrandSampled { get; set; }
        public string BrandPurchased { get; set; }
        public string Comment { get; set; }
        public string GameName { get; set; }
        public string Score { get; set; }
        public string PriceWon { get; set; }
    }

    public class GameInfo
    {
        public string Name { get; set; }
        public string Score { get; set; }   
        public string PriceWon { get; set; }
    }
}
