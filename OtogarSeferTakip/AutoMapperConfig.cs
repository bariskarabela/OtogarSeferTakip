﻿using AutoMapper;
using OtogarSeferTakip.Entities;
using OtogarSeferTakip.Models;

namespace OtogarSeferTakip
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<User, EditUserModel>().ReverseMap();

            CreateMap<Tako, TakoModel>().ReverseMap();

            CreateMap<Bus, AddBusModel>().ReverseMap();
            CreateMap<Bus, EditBusModel>().ReverseMap();
            CreateMap<DrivingLicence, DrivingLicenceModel>().ReverseMap();


        }
    }
}
