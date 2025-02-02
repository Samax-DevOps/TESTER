﻿namespace ErgotronChatbotApi.Model
{
    public class ChargerDetails
    {
        public string ChargerId { get; set; }
        public string Asset { get; set; }
        public string Department { get; set; }
        public string Floor { get; set; }
        public string Wing { get; set; }
        public string Type { get; set; }
        public string Bay1 { get; set; }
        public int? Charge1 { get; set; }
        public string Bay2 { get; set; }
        public int? Charge2 { get; set; }
        public string Bay3 { get; set; }
        public int? Charge3 { get; set; }
        public string Bay4 { get; set; }
        public int? Charge4 { get; set; }
        public string LastReported { get; set; }
        public DateTime? LastPostDateUTC { get; set; }
        public int SiteID { get; set; }
        public int? IDAsset { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
    }
}
