using System;
using SmartAnalyzers.CSharpExtensions.Annotations;

namespace ConstructorTestAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var owner1 = new Owner(1, 15, true);

            var owner2 = new Owner(1, 20, true);
        }

        [InitOnly]
        public class Owner
        {
            public int Id { get; }

            public int UserId { get; }

            public int TypeId { get; set; }

            public bool IsSAMS { get; set; }

            public OwnerType Type { get; set; }

            public string Name { get; set; }

            public string CompanyName { get; set; }

            public string Department { get; set; }

            public string JobTitle { get; set; }

            public string EmailAddress { get; set; }

            public string TelephoneNumber { get; set; }

            public bool IsActive { get; set; }

            public int? EngagementId { get; set; }

            public int? ContractId { get; set; }

            public string EngagementStatus { get; set; }

            public Owner(int id, int userId, bool isActive)
            {
                Id = id;
                UserId = userId;
                IsActive = isActive;
            }
        }

        public enum OwnerType
        {
            Business,
            Executive
        }
    }
}