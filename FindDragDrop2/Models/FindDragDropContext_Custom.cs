using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDragDrop2.Models.Entities
{
    public partial class FindDragDropContext
    {
        public FindDragDropContext(DbContextOptions<FindDragDropContext> c) : base(c)
        {

        }

        public void AddItem()
        {
            Item.Add(new Entities.Item { Image = "test.jpg", Word = "ord" });
            SaveChanges();
        }
    }
}
