namespace test_webapi.DTOs
{
    public class PlantHoldingReadDto
    {
        public int HoldingID { get; set; }
        public int? CustID { get; set; }
        public int? PlantNameID { get; set; }
        public string? SerialNumber { get; set; }
        public int? StatusID { get; set; }
        public string? SWL { get; set; }
        public string? PlantDescription { get; set; }
        public string? StatusDescription { get; set; }
        // Customer fields for certificate
        public string? CustomerCompanyName { get; set; }
        public string? CustomerContactTitle { get; set; }
        public string? CustomerContactFirstNames { get; set; }
        public string? CustomerContactSurname { get; set; }
        public string? CustomerLine1 { get; set; }
        public string? CustomerLine2 { get; set; }
        public string? CustomerLine3 { get; set; }
        public string? CustomerLine4 { get; set; }
        public string? CustomerPostcode { get; set; }
        public string? CustomerTelephone { get; set; }
        public string? CustomerEmail { get; set; }
    }
}