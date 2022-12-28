using AdvertisementApp.Common;
using AdvertisementApp.Dtos.İnterfaces;
using AdvertisementApp.Dtos.ProvidedServiceDtos;
using AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Business.İnterfaces
{
    public interface IService<CreateDto, UpdateDto, ListDto>
        where CreateDto : class, IDto, new()
        where UpdateDto : class, IDto, new()
        where ListDto : class, IDto, new()
        where T : BaseEntity

    {
        Task<IResponse<CreateDto>> CreateAsync(CreateDto dto);
        Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto);
        Task<IResponse<IDto>> GetByIdAsync<IDto>(int id);
        Task<IResponse> RemoveAsync(int id);
        Task<IResponse<List<ListDto>>> GetAllAsync();


    }



}
