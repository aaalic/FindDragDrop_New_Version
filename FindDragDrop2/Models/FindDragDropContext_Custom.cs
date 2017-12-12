using FindDragDrop2.Models.ViewModels;
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

       
        public IndexVM GetAllItems()
        {
            return new IndexVM
            {
                ItemList = Item
                .Select(w => new ItemVM
                {
                    Image = w.Image,
                    Word = w.Word,
                    WordSE = w.WordSe,
                    WordLV = w.WordLv
                })
                .ToArray()
            };
        }
    }
}
