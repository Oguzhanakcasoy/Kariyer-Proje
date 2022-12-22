using AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.DataAccess.İnterfaces
{
    public  interface IRepository<T> where T : BaseEntity
    {
    }
}
