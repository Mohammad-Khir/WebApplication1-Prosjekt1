using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1_Prosjekt1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1_Prosjekt1.Model;

namespace WebApplication1_Prosjekt1.Controllers
{
    [Route("[controller]/[action]")]
    public class PasientController 
    {
        private readonly PasientContext _db;

        public PasientController(PasientContext db)
        {
            _db = db;
        }

        public bool Lagre(Pasient innPasient)
        {
            try
            {
                _db.Pasienter.Add(innPasient);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<Pasient> HentAlle()
        {
            try
            {
                List<Pasient> allePasientene = _db.Pasienter.ToList(); // hent hele tabellen
                return allePasientene;
            }
            catch
            {
                return null;
            }
        }

        public bool Slett(int id)
        {
            try
            {
                Pasient enPasient = _db.Pasienter.Find(id);
                _db.Pasienter.Remove(enPasient);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Pasient HentEn(int id)
        {
            try
            {
                Pasient enPasient = _db.Pasienter.Find(id);
                return enPasient;
            }
            catch
            {
                return null;
            }
        }

        public bool Endre(Pasient endrePasient)
        {
            try
            {
                Pasient enKunde = _db.Pasienter.Find(endrePasient.id);
                enKunde.navn = endrePasient.navn;
                enKunde.adresse = endrePasient.adresse;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool sjekk()
        {
            return false;
        }
    }
}
