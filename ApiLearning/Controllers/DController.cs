using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiLearning.Models;

namespace ApiLearning.Controllers
{
    public class DController : ApiController
    {
        private DContext db = new DContext();

        // GET: api/D
        public IQueryable<D> GetD()
        {
            return db.D;
        }

        // GET: api/D/5
        [ResponseType(typeof(D))]
        public IHttpActionResult GetD(int id)
        {
            D d = db.D.Find(id);
            if (d == null)
            {
                return NotFound();
            }

            return Ok(d);
        }

        // PUT: api/D/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutD(int id, D d)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != d.Id)
            {
                return BadRequest();
            }

            db.Entry(d).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/D
        [ResponseType(typeof(D))]
        public IHttpActionResult PostD(D d)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.D.Add(d);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = d.Id }, d);
        }

        // DELETE: api/D/5
        [ResponseType(typeof(D))]
        public IHttpActionResult DeleteD(int id)
        {
            D d = db.D.Find(id);
            if (d == null)
            {
                return NotFound();
            }

            db.D.Remove(d);
            db.SaveChanges();

            return Ok(d);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DExists(int id)
        {
            return db.D.Count(e => e.Id == id) > 0;
        }
    }
}