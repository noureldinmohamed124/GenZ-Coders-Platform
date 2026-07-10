using GenZCoders.Application.Modules.EnrollmentApplications.Commands.CreateEnrollmentApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenZCoders.Application.Abstractions
{
    public interface IFileStorageService
    {
        Task<string> UploadAsync(UploadedFile file);

        Task DeleteAsync(string fileUrl);
    }
}
