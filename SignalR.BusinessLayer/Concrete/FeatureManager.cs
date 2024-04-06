using SignalIR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SıgnalR.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _FeatureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _FeatureDal = featureDal;
        }
        void IGenericService<Feature>.TAdd(Feature entity)
        {
            _FeatureDal.Add(entity);
        }

        void IGenericService<Feature>.TDelete(Feature entity)
        {
            _FeatureDal.Delete(entity);
        }

        Feature IGenericService<Feature>.TGetById(int id)
        {
            return _FeatureDal.GetById(id);
        }

        List<Feature> IGenericService<Feature>.TGetListAll()
        {
            return _FeatureDal.GetListAll();
        }

        void IGenericService<Feature>.TUpdate(Feature entity)
        {
           _FeatureDal.Update(entity);
        }
    }
}
