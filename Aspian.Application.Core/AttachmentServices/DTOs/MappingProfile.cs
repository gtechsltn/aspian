using Aspian.Domain.AttachmentModel;
using AutoMapper;

namespace Aspian.Application.Core.AttachmentServices.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AttachmentDto, Attachment>();
            CreateMap<FileUploadResult, Attachment>();
            CreateMap<FileUploadResult, AttachmentDto>();
        }
    }
}