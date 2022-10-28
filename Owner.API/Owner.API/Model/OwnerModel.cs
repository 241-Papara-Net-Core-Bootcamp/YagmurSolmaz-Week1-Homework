using System;

namespace Owner.API.Model
{
    public class OwnerModel
    {
        //Owner modeli : id, adı soyadı tarih açıklama ve tür adında propertilerini barındırır.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
    }
}
