﻿using Ödev2.Business.Abstracts;
using Ödev2.DataAccess.Abstracts;
using Ödev2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2.Business.Concretes;
class CourseManager : ICourseManager
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(int courseId)
    {
        _courseDal.Delete(courseId);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
}
