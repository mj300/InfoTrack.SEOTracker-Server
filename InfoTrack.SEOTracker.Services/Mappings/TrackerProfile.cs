﻿using AutoMapper;
using InfoTrack.SEOTracker.Data.Models;
using InfoTrack.SEOTracker.Domain.DTO;

namespace InfoTrack.SEOTracker.Services.Mappings
{
   public class TrackerProfile : Profile
   {
      public TrackerProfile()
      {
         CreateMap<TrackerHistoryDto, TrackerHistory>().ReverseMap();
         CreateMap<TrackerDto, Tracker>().ReverseMap();
      }
   }
}
