using GenZCoders.Application.Abstractions.Presistance;
using GenZCoders.Domain.Entities;
using GenZCoders.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenZCoders.Infrastructure.Repositories
{
    public class CourseRepo : GenericRepo<Course>, ICourseRepo
    {
        public CourseRepo(GenZDbContext context) : base(context) { }

        public async Task<Course?> GetCourseByIdWithProgramAsync(int id)
        {
            return await _context.Courses.Include(c => c.Program)
            .FirstOrDefaultAsync(c => c.Id == id);
        }


    }
}
