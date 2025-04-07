namespace test_webapi.DTOs
{
    public class InspectionReadDto
    {
        public int UniqueRef { get; set; }
        public int? HoldingID { get; set; }
        public DateTime? InspectionDate { get; set; }
        public string? Location { get; set; }
        public string? RecentCheck { get; set; }
        public string? PreviousCheck { get; set; }
        public string? SafeWorking { get; set; }
        public string? Defects { get; set; }
        public string? Rectified { get; set; }
        public DateTime? LatestDate { get; set; }
        public string? TestDetails { get; set; }
        public string? MiscNotes { get; set; }
        
        // Additional properties from related entities
        public string? PlantDescription { get; set; }
        public string? CategoryDescription { get; set; }        public string? SerialNumber { get; set; }
        
        // Inspector properties
        public int? InspectorID { get; set; }
        public string? InspectorsName { get; set; }
        
        // Customer properties
        public int? CustID { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactTitle { get; set; }
        public string? ContactFirstNames { get; set; }
        public string? ContactSurname { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        public string? Line4 { get; set; }
        public string? Postcode { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }
    }
}