using Application.ViewModels;
using AutoMapper;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class FlatProfile:Profile
    {
        public FlatProfile()
        {
            CreateMap<Flat, FlatViewModel>()
                .ForMember(destination => destination.UserName, operation => operation.MapFrom(source => source.User.Name + source.User.Surname))
                .ForMember(destination => destination.UserId, operation => operation.MapFrom(source => source.UserId))
                .ForMember(destination => destination.Block, operation => operation.MapFrom(source => source.Block))
                .ForMember(destination => destination.FloorNo, operation => operation.MapFrom(source => source.FloorNo))
                .ForMember(destination => destination.FlatNo, operation => operation.MapFrom(source => source.FlatNo))
                .ForMember(destination => destination.IsEmpty, operation => operation.MapFrom(source => source.IsEmpty))
                .ForMember(destination => destination.RoomType, operation => operation.MapFrom(source => source.RoomType));

            CreateMap<FlatViewModel, Flat>()
               .ForMember(destination => destination.UserId, operation => operation.MapFrom(source => source.UserId))
               //.ForMember(destination => destination.User.Name, operation => operation.MapFrom(source => source.UserName))
               //burada name'i almak gerek mi?
               // split kullanılabilir mi?
               .ForMember(destination => destination.Block, operation => operation.MapFrom(source => source.Block))
               .ForMember(destination => destination.FloorNo, operation => operation.MapFrom(source => source.FloorNo))
               .ForMember(destination => destination.FlatNo, operation => operation.MapFrom(source => source.FlatNo))
               .ForMember(destination => destination.IsEmpty, operation => operation.MapFrom(source => source.IsEmpty))
               .ForMember(destination => destination.RoomType, operation => operation.MapFrom(source => source.RoomType));

        }
    }
}
