using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectBackEndDemo.Areas.Sensor.Data;
using ProjectBackEndDemo.Areas.Sensor.Models;
using ProjectBackEndDemo.DAL.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Sensor.SensorRep
{
    public class SensorRep : ISensorRep
    {
        private readonly DbContainer db;
        private readonly IMapper mapper;

        public SensorRep( DbContainer db , IMapper mapper )
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddSensorData(SensorDataVM model)
        {
            SensorData newone = mapper.Map<SensorData>(model);
            db.SensorDatas.Add(newone);
            db.SaveChanges();
        }

        public SensorDataVM GetSensorData(int Id)
        {
            SensorData mysesordata = db.SensorDatas.Where(a => a.Id == Id)
                .Include(a=> a.Animal )
                .Include(d=> d.Disease)
                .FirstOrDefault();
          SensorDataVM  mysesordataVM = mapper.Map<SensorDataVM>(mysesordata);
            mysesordataVM.AnimalName = mysesordata.Animal.Name;
            mysesordataVM.DiseaseName = mysesordata.Disease.Name;
            return mysesordataVM;

        }
    }
}
