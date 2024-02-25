using Ödev2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2.Business.Abstracts;

public interface ICategoryManager
{
    List<Category> GetAll();
    void Add(Category category);
    void Update(Category category);
    void Delete(int categoryId);
}
