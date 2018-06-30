using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StabilityInterface
{
    public class Batch
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CountryId { get; set; }
        public int Type { get; set; }
        public string BatchNo { get; set; }
        public string ProductName { get; set; }
        public string MfgDate { get; set; }
        public string ExpDate { get; set; }
        public string BatchSize { get; set; }
        public string ReleaseDate { get; set; }
        public string IncubationDate { get; set; }
        public string CountryCode { get; set; }
        public string TypeName { get; set; }
        public string OtherInfo { get; set; }

    }
    public class Chamber
    {
        public int Id { get; set; }
        public int ModifiedById { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public string Period { get; set; }
        public string ModifiedBy { get; set; }
    }
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
        public int ModifiedById { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string LabelClaim { get; set; }
        public string APISource { get; set; }
        public string PackingDetails { get; set; }
        public string Pack { get; set; }
        public string ShelfLife { get; set; }
        public string ModifiedBy { get; set; }
    }
    public class TestReport
    {
        public int Id { get; set; }
        public int StabilityCheckId { get; set; }
        public int TestId { get; set; }
        public string Initial { get; set; }
        public string StabilityCheck { get; set; }
        public string TestCode { get; set; }
        public string M1 { get; set; }
        public string M2 { get; set; }
        public string M3 { get; set; }
        public string M6 { get; set; }
        public string M9 { get; set; }
        public string M12 { get; set; }
        public string M18 { get; set; }
        public string M24 { get; set; }
        public string M30 { get; set; }
        public string M36 { get; set; }
        public string M42 { get; set; }
        public string M48 { get; set; }
        public string M60 { get; set; }
        public string M72 { get; set; }
    }
    public class StabilityCheck
    {
        public int Id { get; set; }
        public int BatchId { get; set; }
        public int ChamberId { get; set; }
        public int ProductId { get; set; }
        public string BatchNo { get; set; }
        public string ChamberName { get; set; }
        public string StudyReason { get; set; }
        public string ProtocolNo { get; set; }
        public string Remark { get; set; }
        public string M1 { get; set; }
        public string M2 { get; set; }
        public string M3 { get; set; }
        public string M6 { get; set; }
        public string M9 { get; set; }
        public string M12 { get; set; }
        public string M18 { get; set; }
        public string M24 { get; set; }
        public string M30 { get; set; }
        public string M36 { get; set; }
        public string M42 { get; set; }
        public string M48 { get; set; }
        public string M60 { get; set; }
        public string M72 { get; set; }
    }
    public class Test
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }
    }
    public class StabilityMonthlyPlanner
    {
        public int StabilityCheckId { get; set; }
        public string ProductName { get; set; }
        public string BatchNo { get; set; }
        public string MfgDate { get; set; }
        public string ExpDate { get; set; }
        public string BatchSize { get; set; }
        public string Pack { get; set; }
        public string ShelfLife { get; set; }
        public string ConditionInterval { get; set; }
        public string ItemCode { get; set; }
        public string Country { get; set; }
        public string DueDate { get; set; }
        public string MONTH { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string AddedOn { get; set; }
        public string ModifiedOn { get; set; }
    }
    public class StabilityDueList
    {
        public string DueDate { get; set; }
        public string ProductName { get; set; }
        public string BatchNo { get; set; }
    }
    }
