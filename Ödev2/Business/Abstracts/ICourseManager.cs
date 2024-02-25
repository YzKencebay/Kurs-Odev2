using Ödev2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2.Business.Abstracts;

public interface ICourseManager
{
    List<Course> GetAll();
    void Add(Course course);
    void Update(Course course);
    void Delete(int courseId);
}
