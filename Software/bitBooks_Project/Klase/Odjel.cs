using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class Odjel
    {
        public int OdjelID { get; set; }
        public int KnjižnicaID { get; set; }
        public int PoštanskiBroj { get; set; }
        public string Ime { get; set; }
        public string Adresa { get; set; }
        public int BrojOdjela { get; set; }

        public List<Odjel> DohvatiSveOdjele()
        {
            List<Odjel> sviOdjeli = new List<Odjel>();

            using (var context = new Entities_db1())
            {
                var query = from d in context.Departments
                            select new Odjel
                            {
                                OdjelID = d.DepartmentID,
                                KnjižnicaID = d.LibraryID,
                                PoštanskiBroj = d.PostalCode,
                                Ime = d.Name,
                                Adresa = d.Adress,
                                BrojOdjela = d.DepartmentNum
                            };
                sviOdjeli = query.ToList();
            }

            return sviOdjeli;
        }

        public Odjel DohvatiOdredeniOdjel(int odjelID)
        {
            Odjel odjel;

            using (var context = new Entities_db1())
            {
                var query = from d in context.Departments
                            where d.DepartmentID == odjelID
                            select new Odjel
                            {
                                OdjelID = d.DepartmentID,
                                KnjižnicaID = d.LibraryID,
                                PoštanskiBroj = d.PostalCode,
                                Ime = d.Name,
                                Adresa = d.Adress,
                                BrojOdjela = d.DepartmentNum
                            };
                odjel = query.Single();
            }

            return odjel;
        }

        public static List<Odjel> DohvatiOdjeleKnjiznice(int? knjiznicaID)
        {
            List<Odjel> odjeliKnjiznice = new List<Odjel>();

            using (var context = new Entities_db1())
            {
                var query = from d in context.Departments
                            where d.LibraryID == knjiznicaID
                            select new Odjel
                            {
                                OdjelID = d.DepartmentID,
                                KnjižnicaID = d.LibraryID,
                                PoštanskiBroj = d.PostalCode,
                                Ime = d.Name,
                                Adresa = d.Adress,
                                BrojOdjela = d.DepartmentNum
                            };
                odjeliKnjiznice = query.ToList();
            }

            return odjeliKnjiznice;
        }

        public static List<Odjel> DohvatiOdjeleKnjiznice(int knjiznicaID)
        {
            List<Odjel> odjeliKnjiznice = new List<Odjel>();

            using (var context = new Entities_db1())
            {
                var query = from d in context.Departments
                            where d.LibraryID == knjiznicaID
                            select new Odjel
                            {
                                OdjelID = d.DepartmentID,
                                KnjižnicaID = d.LibraryID,
                                PoštanskiBroj = d.PostalCode,
                                Ime = d.Name,
                                Adresa = d.Adress,
                                BrojOdjela = d.DepartmentNum
                            };
                odjeliKnjiznice = query.ToList();
            }

            return odjeliKnjiznice;
        }

        public static void NoviOdjel(Odjel odjel)
        {
            using (var context = new Entities_db1())
            {
                Department department= new Department
                {
                    LibraryID = odjel.KnjižnicaID,
                    PostalCode = odjel.PoštanskiBroj,
                    Adress = odjel.Adresa,
                    Name = odjel.Ime,
                    DepartmentNum = odjel.BrojOdjela

                };

                context.Departments.Add(department);
                context.SaveChanges();
            }
        }

        public static void AžurirajOdjel(Odjel proslijeđenOdjel)
        {
            using (var context = new Entities_db1())
            {
                Department department = context.Departments.First(x => x.DepartmentID == proslijeđenOdjel.OdjelID);
                department.PostalCode = proslijeđenOdjel.PoštanskiBroj;
                department.Name = proslijeđenOdjel.Ime;
                department.Adress = proslijeđenOdjel.Adresa;
                department.DepartmentNum = proslijeđenOdjel.BrojOdjela;


                context.SaveChanges();
            }
        }

        public void ObrisiOdjel()
        {
            using (var context = new Entities_db1())
            {
                var query = (from d in context.Departments
                             where d.LibraryID == KnjižnicaID
                             select d).FirstOrDefault();
                context.Departments.Remove(query);
                context.SaveChanges();

            }
        }
    }
}
