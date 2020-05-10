using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPIValidateException.Models;

namespace WebAPIValidateException.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ProductController : ApiController
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public IHttpActionResult Get() // IHttpActionResult geri dönüş tipi olup return anında bir status code methodu ister. 
        {
            return Ok(db.Products.ToList());
        }

        public IHttpActionResult Get(int id)
        {
            Product secilenUrun = db.Products.Find(id);
            if (secilenUrun != null)
            {
                return Ok(secilenUrun);
            }
            return NotFound();
        }
      
        public IHttpActionResult PutGuncelle(Urun model)
        {
            
            Product bulunanUrun = db.Products.Find(model.UrunID);
            if (bulunanUrun != null)
            {
                if (ModelState.IsValid)
                {
                    // bulunanUrun.ProductName = model.Adi;
                    // bulunanUrun.UnitPrice = model.Fiyati;
                    // bulunanUrun.UnitsInStock = model.StokMiktari;
                    // bulunanUrun.QuantityPerUnit = model.Agirlik + " kg";
                    return Ok(bulunanUrun);
                }
                return BadRequest(ModelState);
            }
            return NotFound();
        }
    }
}