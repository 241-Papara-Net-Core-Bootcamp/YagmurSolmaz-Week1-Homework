using Owner.API.Model;
using System;
using System.Collections.Generic;

namespace Owner.API.Data
{
    public class OwnerData
    {
        public List<OwnerModel> GetAllOwner()
        {
            return new List<OwnerModel>
            {
                new OwnerModel
                {
                Id = 1,
                Name = "Phoebe",
                Surname = "Buffey",
                Date = new DateTime(2000, 12, 12),
                Description = "ITSpecialist",
                Type = 1
                },

                new OwnerModel
                {
                Id = 2,
                Name = "Monica",
                Surname = "Geller",
                Date = new DateTime(2005, 7, 5),
                Description = "HRSpecialist",
                Type = 2
                },

                new OwnerModel
                {
                Id = 1,
                Name = "Chandler",
                Surname = "Bing",
                Date = new DateTime(1999, 10, 12),
                Description = "ITSpecialist",
                Type = 1
                },

            };
        }
    }
}
