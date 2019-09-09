using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ApiLearning.Controllers
{
    public class ProductsController : ApiController
    {
        private LearningDataContext db = new LearningDataContext();
        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            var products = db.Products;
            return products;
        }

        // GET: api/Products/5
        public IHttpActionResult Get(int id)
        {
            var product = db.Products.SingleOrDefault(x => x.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/Products
        public IHttpActionResult Post([FromBody] Product ProductId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = db.Products.SingleOrDefault(x => x.ProductId == ProductId.ProductId);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
