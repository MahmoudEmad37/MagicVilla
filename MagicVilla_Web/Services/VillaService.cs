﻿using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;

namespace MagicVilla_Web.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;
        public VillaService(IHttpClientFactory clientFactory,IConfiguration configuration):base(clientFactory)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> CreateAsync<T>(VillaCreateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.POST,
                data = dto,
                token = token,
                url = villaUrl + "/api/VillaAPI/CreateVilla"
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.DELETE,
                token = token,
                url = villaUrl + "/api/VillaAPI/DeleteVilla/" + id
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.GET,
                token = token,
                url = villaUrl + "/api/VillaAPI/GetVillas"
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.GET,
                token = token,
                url = villaUrl + "/api/VillaAPI/GetVillaById/" + id
            });
        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                apiType = SD.ApiType.PUT,
                data = dto,
                token=token,
                url = villaUrl + "/api/VillaAPI/UpdateVilla/"+dto.id
            });
        }
    }
}
