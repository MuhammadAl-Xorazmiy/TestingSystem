﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestingSystem.Domain.Configurations;
using TestingSystem.Domain.Entities.Courses;
using TestingSystem.Service.DTOs.Courses;

namespace TestingSystem.Service.Interfaces
{
    public interface ICourseService
    {
        ValueTask<CourseForViewDTO> CreateAsync(CourseForCreationDTO courseForCreationDTO);

        ValueTask<CourseForViewDTO> UpdateAsync(int id, CourseForCreationDTO courseForCreationDTO);

        ValueTask<bool> DeleteAsync(int id);

        ValueTask<IEnumerable<CourseForViewDTO>> GetAllAsync(
            PaginationParams @params,
            Expression<Func<Course, bool>> expression = null);

        ValueTask<CourseForViewDTO> GetAsync(Expression<Func<Course, bool>> expression);
    }
}