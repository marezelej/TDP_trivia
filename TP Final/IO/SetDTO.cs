using System.Collections.Generic;
using TP_Final.IO;

namespace TP_Final
{
    public class SetDTO
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public IEnumerable<CategoryDTO> Categories { get; internal set; }
        public IEnumerable<DiffucultyDTO> Difficulties { get; internal set; }
        public int MaxQuantity { get; internal set; }
    }
}