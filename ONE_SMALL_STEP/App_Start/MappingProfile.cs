using AutoMapper;
using ONE_SMALL_STEP.Core.Domain;
using ONE_SMALL_STEP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //create a map
            //Mapper.CreateMap<Person, PersonViewModel>()
            //    .ForMember(dest => dest.PersonTypeName, opt => opt.MapFrom(src => src.PersonType.PersonTypeName));

            Mapper.CreateMap<Person, PersonViewModel>()
            .ForMember(dest => dest.PersonType, opt => opt.MapFrom(src => src.PersonType.PersonTypeName));
            //.ForMember(dest => dest., opt => opt.MapFrom(src => src.LastName));
            //Mapper.CreateMap<Person, PersonViewModel>().ReverseMap();

            Mapper.CreateMap<CreatePersonViewModel,Person>().ReverseMap();


            Mapper.CreateMap<Person, EditPersonViewModel>()
            .ForMember(dest => dest.PersonTypes, opt => opt.MapFrom(src => src.PersonType.PersonTypeName));

            Mapper.CreateMap<EditPersonViewModel, Person>().ReverseMap();


            Mapper.CreateMap<Person, DeletePersonViewModel>()
            .ForMember(dest => dest.PersonTypeName, opt => opt.MapFrom(src => src.PersonType.PersonTypeName));

            Mapper.CreateMap<DeletePersonViewModel, Person>().ReverseMap();


            Mapper.CreateMap<PersonType, PersonTypeViewModel>();

            Mapper.CreateMap<MessageType, MessageTypeViewModel>();


            Mapper.CreateMap<MessageType, EditMessageTypeViewModel>()
            .ForMember(dest => dest.MessageTypeName, opt => opt.MapFrom(src => src.MessageTypeName));

            Mapper.CreateMap<EditMessageTypeViewModel, MessageType>().ReverseMap();



           // Mapper.CreateMap<MessageType, MessageTypeCreateViewModel>()
           //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.m));
           // Mapper.CreateMap<MessageTypeCreateViewModel, MessageType>().ReverseMap();


            Mapper.CreateMap<Message, EditMessageViewModel>()
            .ForMember(dest => dest.MessageTypes, opt => opt.MapFrom(src => src.MessageType.MessageTypeName));
            Mapper.CreateMap<EditMessageViewModel, Message>().ReverseMap();


            Mapper.CreateMap<Message, MessageViewModel>()
            .ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.MessageType.MessageTypeName));

            //Mapper.CreateMap<MessageViewModel, Message>().ReverseMap();





            //Mapper.CreateMap<Person, EditPersonViewModel>()




            //.ForMember(dest => dest.PersonTypeName, opt => opt.MapFrom(src => src.PersonType.PersonTypeName));
            //.ForMember(dest => dest., opt => opt.MapFrom(src => src.LastName));
            //Mapper.CreateMap<Person, PersonViewModel>().ReverseMap();
            //Mapper.CreateMap<CreatePersonViewModel, Person>().ReverseMap();


            //.ForMember(dest => dest.PersonTypeName, opt => opt.MapFrom(src => src.PersonType.PersonTypeName));

            //Mapper.CreateMap<PersonType, PersonViewModel>();
            //user the created map

        }


        //createm
        //public static void RegisterMaps()
        //{
        //    Mapper.Initialize(config =>
        //    {
        //        Create
        //    })
        //}
    }
}