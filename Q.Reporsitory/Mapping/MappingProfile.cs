using AutoMapper;
using Q.EF;
using Q.EF.Models;
using Q.VM;
using Q.VM.ViewModels;

namespace Q.Reporsitory.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile() { 
            CreateMap<BookMaster, BookMasterVM>().ReverseMap();
            CreateMap<BooksDetail, BooksDetailVM>().ReverseMap();
            CreateMap<BorrowingBook, BorrowingBookVM>().ReverseMap();
            CreateMap<LkAuthor, LkAuthorVM>().ReverseMap();
            CreateMap<LkBookStatus, LkBookStatusVM>().ReverseMap();
            CreateMap<LkFormat, LkFormatVM>().ReverseMap();
            CreateMap<LkPubilsher, LkPubilsherVM>().ReverseMap();
            CreateMap<LkTrasnslator, LkTrasnslatorVM>().ReverseMap();
            CreateMap<LkWarnng, LkWarnngVM>().ReverseMap();
            CreateMap<PurchseingBook, PurchseingBookVM>().ReverseMap();
            CreateMap<Read, ReadVM>().ReverseMap();
            CreateMap<UserLibrary, UserLibraryVM>().ReverseMap();
            CreateMap<User, UserVM>().ReverseMap();
            CreateMap<Warning, WarningVM>().ReverseMap();
            
            
          
           
            
            
            
            
            
        }
    }
}
