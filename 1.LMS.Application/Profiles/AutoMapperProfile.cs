using _0.LMS.Domain.AggregateModels.SubjectModels;
using _0.LMS.Domain.AggregateModels.SubscriptionModels;
using _1.LMS.Application.Commands.User.LogInUser;
using _1.LMS.Application.Commands.User.SignUpUser;
using _1.LMS.Application.Queries.Subject.GetSubjectByUser;
using _1.LMS.Application.Queries.User.GetUserByName;
using AutoMapper;

namespace _1.LMS.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Subject, GetSubjectByUserDto>();
            CreateMap<UserApplication, UserForReturnDto>();
            CreateMap<UserApplication, LogInUserForReturnDto>();
            CreateMap<SignUpUserCommand, UserApplication>();
        }
    }
}