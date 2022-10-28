using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Owner.API.Model;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Owner.API.Data;
using System.Reflection;

namespace Owner.API.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        
        [Route("PostOwner")]
        [HttpPost]
        public IActionResult PostOwner(OwnerModel model)
        {
            //Eğer Post işleminde açıklama kısmında hack içeren yazı varsa hata dönüş yapar yoksa başarılı dönüş yapar.

            var ownerModel = new List<OwnerModel>();

            ownerModel.Add(model);

            if (ownerModel.Any(x => x.Description.Contains("hack")))
            {
                return NotFound();
            }
            else
            {
                return Ok(ownerModel);
                
            }

        }   


        [Route("PutOwner")]
        [HttpPut]
        public IActionResult PutOwner(OwnerModel model)
        {
            //Put işleminde gelen modeli günceller başarılı şekilde dönüş yapar
            var ownerModel = new List<OwnerModel>();
            ownerModel.Add(model);
            return Ok(ownerModel);
        }


        [Route("DeleteOwner{id:int}")]
        [HttpDelete]
        public IActionResult DeleteOwner(int id)
        {
            // Delete işleminde id göre liste içersindeki ownerları bulur ve siler 

            var owners = new OwnerData().GetAllOwner();
            var owner = owners.FirstOrDefault(x => x.Id == id);

            if (owner == null)
                return NotFound($"Owner with id = {id} not found");

            owners.Remove(owner);

            return Ok(owners);
        }


        [Route("GetAllOwners")]
        [HttpGet]
        public IActionResult GetAllOwners()
        {
            //Get işleminde tüm ownerları listeler

            var owners = new OwnerData().GetAllOwner();            
            return Ok(owners);           
            
        }

    }
}
