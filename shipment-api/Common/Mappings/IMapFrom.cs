using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shipment_api.Common.Mappings
{
    interface IMapFrom<TEntity> where TEntity: class
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(TEntity), GetType());
    }
}
