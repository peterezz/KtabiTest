using KtabiTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KtabiTest.Repository
{
    public class OfferManger
    {
        private readonly KitabiContext dbContext;
        private BaseRepo<CourseAppointment> _Rebo;
        public OfferManger(KitabiContext DbContext)
        {
    
        dbContext = DbContext;
            _Rebo = new BaseRepo<CourseAppointment>(DbContext);
        }

        public IQueryable<CourseAppointment> getall()
        {
            var data = _Rebo.GetMany(null, appoinment => appoinment.Teacher, appoinment => appoinment.Course);
            return data;
        }
    }
}
