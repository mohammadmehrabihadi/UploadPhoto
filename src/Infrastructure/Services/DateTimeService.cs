using UploadPhoto.Application.Common.Interfaces;

namespace UploadPhoto.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
