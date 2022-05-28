using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectBackEndDemo.Areas.Diseases.Models;
using ProjectBackEndDemo.DAL.DataBase;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Diseases.Rep
{
    public class DiseaseRep : IDiseaseRep
    {
        #region ctor 
        private readonly DbContainer db;
        private readonly IMapper mapper;

        public DiseaseRep(DbContainer db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        #endregion


        #region Diseases 
       
        public List<DieseaseVM> GetAllDiseases(int AnimalId)
        {
            try
            {
                var myList = new List<DieseaseVM>();
                foreach (var item in db.Diseases.Where(w => w.AnimalId == AnimalId).Include(i => i.Animal).ToList())
                {
                    DieseaseVM m = mapper.Map<DieseaseVM>(item);
                    m.MedicineNames = new List<string>();
                    m.SymptomNames = new List<string>();
                    m.AnimalName = item.Animal.Name;

                    m.MedicineIds = db.DiseaseMedicines.Where(w => w.DiseaseId == item.Id).Select(a => a.MedicineId).ToList();
                    foreach (var i in m.MedicineIds) { m.MedicineNames.Add(db.Medicines.Where(w => w.Id == i).Select(s => s.Name).FirstOrDefault()); }

                    m.SymptomIds = db.DiseaseSymptoms.Where(w => w.DiseaseId == item.Id).Select(a => a.symptomId).ToList();
                    foreach (var i in m.SymptomIds) { m.SymptomNames.Add(db.Symptoms.Where(w => w.Id == i).Select(n => n.Name).FirstOrDefault()); }
                    myList.Add(m);
                }

                return (myList);
            }
            catch
            {
                var myList = new List<DieseaseVM>();
                foreach (var item in db.Diseases.Include(i => i.Animal).ToList())
                {
                    DieseaseVM m = mapper.Map<DieseaseVM>(item);
                    m.MedicineNames = new List<string>();
                    m.SymptomNames = new List<string>();
                    m.AnimalName = item.Animal.Name;

                    m.MedicineIds = db.DiseaseMedicines.Where(w => w.DiseaseId == item.Id).Select(a => a.MedicineId).ToList();
                    foreach (var i in m.MedicineIds) { m.MedicineNames.Add(db.Medicines.Where(w => w.Id == i).Select(s => s.Name).FirstOrDefault()); }

                    m.SymptomIds = db.DiseaseSymptoms.Where(w => w.DiseaseId == item.Id).Select(a => a.symptomId).ToList();
                    foreach (var i in m.SymptomIds) { m.SymptomNames.Add(db.Symptoms.Where(w => w.Id == i).Select(n => n.Name).FirstOrDefault()); }
                    myList.Add(m);
                }

                return (myList);
            }

            
            
        }

        public List<DieseaseVM> GetAllDiseases(int AnimalId, string search)
        {
                    
                var myList = new List<DieseaseVM>();
                foreach (var item in db.Diseases.Include(i => i.Animal).Where(w=> w.Name.Contains(search) || w.KeyWords.Contains(search)).ToList())
                {
                    
                        DieseaseVM m = mapper.Map<DieseaseVM>(item);
                        m.MedicineNames = new List<string>();
                        m.SymptomNames = new List<string>();
                        m.AnimalName = item.Animal.Name;

                        m.MedicineIds = db.DiseaseMedicines.Where(w => w.DiseaseId == item.Id).Select(a => a.MedicineId).ToList();
                        foreach (var i in m.MedicineIds) { m.MedicineNames.Add(db.Medicines.Where(w => w.Id == i).Select(s => s.Name).FirstOrDefault()); }

                        m.SymptomIds = db.DiseaseSymptoms.Where(w => w.DiseaseId == item.Id).Select(a => a.symptomId).ToList();
                        foreach (var i in m.SymptomIds) { m.SymptomNames.Add(db.Symptoms.Where(w => w.Id == i).Select(n => n.Name).FirstOrDefault()); }
                        myList.Add(m);
                    

                }

                return (myList);
            


        }
        public DieseaseVM GetDieaseById(int id)
        {
            var myDiseseVM = mapper.Map<DieseaseVM>(db.Diseases.FirstOrDefault(f => f.Id == id));

            myDiseseVM.AnimalName = db.Animals.Where(W => W.Id == myDiseseVM.AnimalId).Select(s => s.Name).FirstOrDefault();
            myDiseseVM.MedicineNames = new List<string>();
            myDiseseVM.SymptomNames = new List<string>();

            myDiseseVM.MedicineIds = db.DiseaseMedicines.Where(w => w.DiseaseId == myDiseseVM.Id).Select(a => a.MedicineId).ToList();
            foreach (var i in myDiseseVM.MedicineIds) { myDiseseVM.MedicineNames.Add(db.Medicines.Where(w => w.Id == i).Select(s => s.Name).FirstOrDefault()); }

            myDiseseVM.SymptomIds = db.DiseaseSymptoms.Where(w => w.DiseaseId == myDiseseVM.Id).Select(a => a.symptomId).ToList();
            foreach (var i in myDiseseVM.SymptomIds) { myDiseseVM.SymptomNames.Add(db.Symptoms.Where(w => w.Id == i).Select(n => n.Name).FirstOrDefault()); }
            return myDiseseVM ; 
        }
        public void CreateDisease(DieseaseVM model)
        {
            Disease d = mapper.Map<Disease>(model);


            db.Diseases.Add(d);
            db.SaveChanges();

            foreach (var item in model.MedicineIds)
            {
                DiseasMedicine dm = new DiseasMedicine()
                {
                    DiseaseId = d.Id,
                    MedicineId = item
                };
                db.DiseaseMedicines.Add(dm);
                db.SaveChanges();
            }

            foreach (var item in model.SymptomIds)
            {
                DiseaseSymptom ds = new DiseaseSymptom()
                {
                    DiseaseId = d.Id,
                    symptomId = item
                };
                db.DiseaseSymptoms.Add(ds);
                db.SaveChanges();
            }


        }
        #endregion

        #region Medicines 
        public List<MedicineVM> GetAllMedicines()
        {
            var MedicineList = new List<MedicineVM>();
            foreach (var item in db.Medicines.ToList())
            {
                MedicineVM m = mapper.Map<MedicineVM>(item);
                m.DieasesNames = new List<string>();
                m.DieasesIds = db.DiseaseMedicines.Where(a => a.MedicineId == item.Id).Select(s => s.DiseaseId).ToList();
                foreach (var n in m.DieasesIds)
                {
                    m.DieasesNames.Add(db.Diseases.Where(w => w.Id == n).Select(s => s.Name).FirstOrDefault());
                }
                MedicineList.Add(m);
            }
            return (MedicineList);
        }
        public List<MedicineVM> GetAllMedicines(string search) => GetAllMedicines().Where(a => a.Name.Contains(search) || a.KeyWords.Contains(search)).ToList();
        public MedicineVM GetMedicineById(int id)
        {
            var myMedicine = mapper.Map<MedicineVM>(db.Medicines.FirstOrDefault(f => f.Id == id));
            myMedicine.DieasesIds = db.DiseaseMedicines.Where(w => w.MedicineId == id).Select(s => s.DiseaseId).ToList();
            myMedicine.DieasesNames = new List<string>();
            foreach (var i in myMedicine.DieasesIds) { myMedicine.DieasesNames.Add(db.Diseases.Where(w => w.Id == i).Select(s => s.Name).FirstOrDefault()); }

            return myMedicine;
        }
        public void CreateMedicine(MedicineVM model)
        {
            db.Medicines.Add(mapper.Map<Medicine>(model));
            db.SaveChanges();
        }
        
        #endregion

        #region Symptoms 
        public List<SymptomVM> GetAllSymptoms()
        {

            var SymptomList = new List<SymptomVM>();

            foreach (var item in db.Symptoms.ToList())
            {
                SymptomVM m = mapper.Map<SymptomVM>(item);

                m.DieasesNames = new List<string>();
                m.DieasesIds = db.DiseaseSymptoms.Where(w => w.symptomId == item.Id).Select(s => s.DiseaseId ).ToList();
                foreach (var n in m.DieasesIds)
                {
                    m.DieasesNames.Add(db.Diseases.Where(w => w.Id == n).Select(s => s.Name).FirstOrDefault());
                }



                SymptomList.Add(m);
            }


            return (SymptomList);



        }
        //public List<SymptomVM> GetAllSymptoms(string search) => GetAllSymptoms().Where(w => w.Name.Contains(search) || w.KeyWords.Contains(search)).ToList();
        public List<SymptomVM> GetAllSymptoms(string search)
        {
            var SymptomList = new List<SymptomVM>();

            foreach (var item in db.Symptoms.Where(w => w.Name.Contains(search) || w.KeyWords.Contains(search)).ToList())
            {
                SymptomVM m = mapper.Map<SymptomVM>(item);

                m.DieasesNames = new List<string>();
                m.DieasesIds = db.DiseaseSymptoms.Where(w => w.symptomId == item.Id).Select(s => s.DiseaseId).ToList();
                foreach (var n in m.DieasesIds)
                {
                    m.DieasesNames.Add(db.Diseases.Where(w => w.Id == n).Select(s => s.Name).FirstOrDefault());
                }



                SymptomList.Add(m);
            }


            return (SymptomList);


        }


        public SymptomVM GetSymptomById(int id)
        {
            var mySymptom = mapper.Map<SymptomVM>(db.Symptoms.FirstOrDefault(f => f.Id == id));
            mySymptom.DieasesIds = db.DiseaseSymptoms.Where(w => w.symptomId == id).Select(s => s.DiseaseId).ToList();
            mySymptom.DieasesNames = new List<string>();
            foreach (var i in mySymptom.DieasesIds) { mySymptom.DieasesNames.Add(db.Diseases.Where(w => w.Id == i).Select(s => s.Name).FirstOrDefault()); }

            return mySymptom;
        }
        public void CreateSymptom(SymptomVM model)
        {
            db.Symptoms.Add(mapper.Map<Symptom>(model));
            db.SaveChanges();
        }


        #endregion



        public List<string> DiseaseAutoCmplt(string prefix)
        {
            return db.Diseases.Where(w => w.Name.Contains(prefix)).Select(a => a.Name).ToList();
        }


        public void CreateFAQ(FAQVM model)
        {
            
            db.fAQs.Add(mapper.Map<FAQ>(model));
            db.SaveChanges();
        }
        public List<FAQVM> GetFAQS()
        {
            var FAQList = new List<FAQVM>();
            foreach(var item in db.fAQs)
            {
                FAQList.Add(mapper.Map<FAQVM>(item));
            }
            return FAQList;
        }
        public List<FAQVM> GetSearchedFAQS(string search)
        {
            var searchedList = db.fAQs.Where(a => a.Question.Contains(search) || a.Answer.Contains(search)).ToList();
            var FAQList = new List<FAQVM>();
            foreach (var item in searchedList)
            {
                FAQList.Add(mapper.Map<FAQVM>(item));
            }
            return FAQList;

        }


    }
}
